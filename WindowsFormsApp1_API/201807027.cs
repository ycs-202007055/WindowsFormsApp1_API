using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Text.RegularExpressions;
using System.Windows.Forms;



// https://wikidocs.net/17615

namespace WindowsFormsApp1_API
{
    
    public partial class Form1 
    {
        private List<string[]> StockList = new List<string[]>();
        private string SearchedList = "";               // 검색된 종목코드들의 총 문자열 ( 123456;789101;... )
        private int SearchedList_Count = 0;             // 검색된 종목의 총 개수
        private int SearchedList_Index = 1;             // 종목리스트 현재 페이지
        private int SearchedList_MaxIndex =  1;          // 종목리스트 총 페이지
        
        void ConstructorA()
        {
            종목리스트.SortCompare += customSortCompare;
        }


        // *************************************************************************************
        //                                  로그인 이벤트
        // ************************************************************************************
        void OnEventConnectA(object sender, AxKHOpenAPILib._DKHOpenAPIEvents_OnEventConnectEvent e)
        {
            Console.WriteLine("//////////////////////////로그인//////////////////////////");
            // 종목 정보
            UpdateStockInfo("000020");
            

            // 종목리스트
            SearchedList = axKHOpenAPI1.GetCodeListByMarket("0");
        
            string[] SplitedList = SearchedList.Split(';');
            int Count = Math.Min(SplitedList.Length - 1 , 100);
            SearchedList_Count = SplitedList.Length - 1;
            SearchedList_Index = 1;
            // 모든 종목들의 코드와 이름을 배열에 저장
            for (int i=0; i<SplitedList.Length;i++)
            {
                String Code = SplitedList[i];
                StockList.Add(new string[2] { axKHOpenAPI1.GetMasterCodeName(Code),Code});
            }
            
            // 종목리스트 요청
            string ShownList = SearchedList.Substring(0, Count * 7);
            axKHOpenAPI1.CommKwRqData(ShownList,0,Count,0,"종목리스트","0000");

            SearchedList_Index = 1;
            종목리스트_페이지.Text = "1";
            종목리스트_최대페이지.Text = ((SearchedList_Count - 1) / 100 + 1).ToString();




        }
        // *************************************************************************************
        //                                  TR데이터 수신 이벤트
        // ************************************************************************************
        void OnReceiveA(object sender, AxKHOpenAPILib._DKHOpenAPIEvents_OnReceiveTrDataEvent e)
        {
            if (e.sRQName == "종목정보")
            {
                updateStockInfoRcv(e);
            }
            else if (e.sRQName == "종목정보_거래대금")
            {
                int Trading_Value = int.Parse(axKHOpenAPI1.GetCommData(e.sTrCode, e.sRQName, 0, "거래대금"));
                거래대금.Text = string.Format("{0:#,##0}", Trading_Value);
            }
            else if (e.sRQName == "체결정보")
            {
                체결강도.Text = axKHOpenAPI1.GetCommData(e.sTrCode, e.sRQName, 0, "체결강도");
            }

            // ********************
            // 종목 리스트
            // ********************
            if (e.sRQName == "종목리스트")
            {
                종목리스트.Rows.Clear();
                int StockCount = axKHOpenAPI1.GetRepeatCnt(e.sTrCode, e.sRQName);
                if (StockCount <= 0) return;

                updateStockListRcv(e);
            }
        }


        // *************************************************************************************
        //                                  실시간 데이터 이벤트
        // ************************************************************************************
        public void OnReceiveRealDataA(object sender, AxKHOpenAPILib._DKHOpenAPIEvents_OnReceiveRealDataEvent e)
        {
            if (e.sRealType == "주식체결")
            {
                // 종목 정보
                int CurrentPrice = int.Parse(axKHOpenAPI1.GetCommRealData(e.sRealKey, 10));
                현재가.Text = string.Format("{0:#,##0}", CurrentPrice);

                int DaytoDay = int.Parse(axKHOpenAPI1.GetCommRealData(e.sRealKey, 11));
                if (DaytoDay > 0) 전일대비.ForeColor = Color.Red;
                else if (DaytoDay < 0) 전일대비.ForeColor = Color.Blue;
                else 전일대비.ForeColor = Color.Black;
                전일대비.Text = string.Format("{0:#,##0}", Math.Abs(DaytoDay));

                int Trading_Volume = int.Parse(axKHOpenAPI1.GetCommRealData(e.sRealKey, 13));
                거래량.Text = string.Format("{0:#,##0}", Trading_Volume);

                int HighPrice = int.Parse(axKHOpenAPI1.GetCommRealData(e.sRealKey, 17));
                고가.Text = string.Format("{0:#,##0}", HighPrice);

                int LowPrice = int.Parse(axKHOpenAPI1.GetCommRealData(e.sRealKey, 18));
                저가.Text = string.Format("{0:#,##0}", Math.Abs(LowPrice));

                int Trading_Value = int.Parse(axKHOpenAPI1.GetCommRealData(e.sRealKey, 14));
                거래대금.Text = string.Format("{0:#,##0}", Trading_Value);

                string FluRate = axKHOpenAPI1.GetCommRealData(e.sRealKey, 12);
                float FluRatef = float.Parse(FluRate);
                if (FluRatef > 0) 등락률.ForeColor = Color.Red;
                else if (FluRatef < 0) 등락률.ForeColor = Color.Blue;
                else 등락률.ForeColor = Color.Black;
                등락률.Text = FluRate + "%";


                체결강도.Text = axKHOpenAPI1.GetCommRealData(e.sRealKey, 228);


            }
        }





        private void 종목리스트_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index < 0) return;

            if(종목리스트["종목리스트_종목코드", index].Value != null)
                UpdateStockInfo(종목리스트["종목리스트_종목코드", index].Value.ToString());
        }





        // 선택중인 종목 정보를 변경
        public void UpdateStockInfo(string StockCode)
        {
            // 주식 정보 표시 ( 차트 오른쪽 )
            axKHOpenAPI1.SetInputValue("종목코드", StockCode);
            axKHOpenAPI1.CommRqData("종목정보", "opt10001", 0, "0000");

            axKHOpenAPI1.SetInputValue("종목코드", StockCode);
            axKHOpenAPI1.CommRqData("체결정보", "opt10003", 0, "0000");

            axKHOpenAPI1.SetInputValue("종목코드", StockCode);
            axKHOpenAPI1.SetInputValue("기준일자", DateTime.Now.ToString("yyyyMMdd"));
            axKHOpenAPI1.SetInputValue("수정주가구분", "0");
            axKHOpenAPI1.CommRqData("종목정보_거래대금", "opt10081", 0, "0000");

            //
            //chart1.Series.Clear();
            chart1.Series[0].Points.Clear();
            chart1.Series[1].Points.Clear();
            axKHOpenAPI1.SetInputValue("종목코드", StockCode);
            axKHOpenAPI1.SetInputValue("시작일자", DateTime.Now.ToString("yyyyMMdd"));
            axKHOpenAPI1.SetInputValue("수정주가구분", "0");
            axKHOpenAPI1.CommRqData("setchart", "opt10081", 0, "0000");
            //

            종목정보.Text = StockCode;
        }






        public void updateStockInfoRcv(AxKHOpenAPILib._DKHOpenAPIEvents_OnReceiveTrDataEvent e)
        {
                
                종목명.Text = axKHOpenAPI1.GetCommData(e.sTrCode, e.sRQName, 0, "종목명").Trim();

                int HighPrice = int.Parse(axKHOpenAPI1.GetCommData(e.sTrCode, e.sRQName, 0, "고가"));
                고가.Text = string.Format("{0:#,##0}", Math.Abs(HighPrice));

                int LowPrice = int.Parse(axKHOpenAPI1.GetCommData(e.sTrCode, e.sRQName, 0, "저가"));
                저가.Text = string.Format("{0:#,##0}", Math.Abs(LowPrice));

                int CurrentPrice = int.Parse(axKHOpenAPI1.GetCommData(e.sTrCode, e.sRQName, 0, "현재가"));
                현재가.Text = string.Format("{0:#,##0}", Math.Abs(CurrentPrice));

                int Trading_Volume = int.Parse(axKHOpenAPI1.GetCommData(e.sTrCode, e.sRQName, 0, "거래량"));
                거래량.Text = string.Format("{0:#,##0}", Trading_Volume);

                int DaytoDay = int.Parse(axKHOpenAPI1.GetCommData(e.sTrCode, e.sRQName, 0, "전일대비"));
                if (DaytoDay > 0)
                {
                    전일대비.ForeColor = Color.Red;
                    등락률.ForeColor = Color.Red;
                }
                else if (DaytoDay < 0)
                {
                    전일대비.ForeColor = Color.Blue;
                    등락률.ForeColor = Color.Blue;
                }
                else
                {
                    전일대비.ForeColor = Color.Black;
                    등락률.ForeColor = Color.Black;
                }
                전일대비.Text = string.Format("{0:#,##0}", Math.Abs(DaytoDay));

                등락률.Text = axKHOpenAPI1.GetCommData(e.sTrCode, e.sRQName, 0, "등락율") + "%";

        }


        static void updateStockListRcv(object param)
        {
            AxKHOpenAPILib._DKHOpenAPIEvents_OnReceiveTrDataEvent e = (AxKHOpenAPILib._DKHOpenAPIEvents_OnReceiveTrDataEvent)param;
            AxKHOpenAPILib.AxKHOpenAPI axKHOpenAPI1 =  Form1.Instance.getAPI();
            DataGridView 종목리스트 = Form1.Instance.getStockList();
            
            int count = axKHOpenAPI1.GetRepeatCnt(e.sTrCode, e.sRQName);
            for (int i = 0; i < count; i++)
            {

                int index = 종목리스트.Rows.Add();

                종목리스트["종목리스트_거래대금", index].Value = index.ToString();
                종목리스트["종목리스트_종목명", index].Value = axKHOpenAPI1.GetCommData(e.sTrCode, e.sRQName, i, "종목명").Trim();

                int CurrentPrice = int.Parse(axKHOpenAPI1.GetCommData(e.sTrCode, e.sRQName, i, "현재가"));
                종목리스트["종목리스트_현재가", index].Value = string.Format("{0:#,##0}", Math.Abs(CurrentPrice));

                int DaytoDay = int.Parse(axKHOpenAPI1.GetCommData(e.sTrCode, e.sRQName, i, "전일대비"));
                if (DaytoDay > 0) 종목리스트["종목리스트_전일대비", index].Style.ForeColor = Color.Red;
                else if (DaytoDay < 0) 종목리스트["종목리스트_전일대비", index].Style.ForeColor = Color.Blue;
                else 종목리스트["종목리스트_전일대비", index].Style.ForeColor = Color.Black;
                종목리스트["종목리스트_전일대비", index].Value = string.Format("{0:#,##0}", Math.Abs(DaytoDay));

                string FluRate = axKHOpenAPI1.GetCommData(e.sTrCode, e.sRQName, i, "등락율").Trim();
                float FluRatef = float.Parse(FluRate);
                if (FluRatef > 0) 종목리스트["종목리스트_등락률", index].Style.ForeColor = Color.Red;
                else if (FluRatef < 0) 종목리스트["종목리스트_등락률", index].Style.ForeColor = Color.Blue;
                else 종목리스트["종목리스트_등락률", index].Style.ForeColor = Color.Black;
                종목리스트["종목리스트_등락률", index].Value = FluRate + "%";

                종목리스트["종목리스트_종목코드", index].Value = axKHOpenAPI1.GetCommData(e.sTrCode, e.sRQName, i, "종목코드").Trim();

            }

        }

        public DataGridView getStockList()
        {
            return 종목리스트;
        }
        public AxKHOpenAPILib.AxKHOpenAPI getAPI()
        {
            return axKHOpenAPI1;
        }


        // 종목리스트에서 속성별 정렬방법 정의
        private void customSortCompare(object sender, DataGridViewSortCompareEventArgs e)
        {
            switch(e.Column.Index)
            {
                case 1:
                    {
                        string s_a = e.CellValue1.ToString();
                        string s_b = e.CellValue2.ToString();
                        e.SortResult = s_a.CompareTo(s_b);
                    }
                    break;
                case 2:
                case 3:
                case 4:
                case 5:
                    {

                        float f_a = float.Parse(string.Join("", e.CellValue1.ToString().Split(',','%')));
                        float f_b = float.Parse(string.Join("", e.CellValue2.ToString().Split(',', '%')));
                        e.SortResult = f_a.CompareTo(f_b);
                    }
                    break;
                default:
                    break;
            }

            e.Handled = true;

        }

        private void 종목리스트_검색입력_KeyDown(object sender, KeyEventArgs e)
        {
            
            if (e.KeyCode == Keys.Enter)
            {
                종목리스트_검색버튼_Click(sender, e);
            }

        }

        private void 종목리스트_검색버튼_Click(object sender, EventArgs e)
        {
            string target = 종목리스트_검색입력.Text;

            List<string[]> FoundList = StockList.Where(Stock => Regex.IsMatch(Stock[0], target)).ToList();
            if (FoundList.Count < 1) return;

            // 종목리스트
            SearchedList = "";
            SearchedList_Count = FoundList.Count;

            for (int i = 0; i < FoundList.Count; i++)
            {
                SearchedList += FoundList[i][1] + ";";
            }

            int Count = Math.Min(FoundList.Count, 100);

            string ShownList = SearchedList.Substring(0, Count * 7);
            // 종목리스트 요청
            axKHOpenAPI1.CommKwRqData(ShownList, 0, Count, 0, "종목리스트", "0010");

            SearchedList_Index = 1;
            종목리스트_페이지.Text = "1";
            종목리스트_최대페이지.Text = ((SearchedList_Count - 1) / 100 + 1).ToString();
        }

        private void SearchIndexChanged(int TargetPage)
        {
            if (TargetPage > ((SearchedList_Count - 1) / 100 + 1) || TargetPage <= 0)// 타겟 페이지가 최대 페이지를 넘어갈경우 리턴
            {
                종목리스트_페이지.Text = SearchedList_Index.ToString();
                return;
            }

            int Count = Math.Min(SearchedList_Count - (TargetPage - 1) * 100, 100);

            string ShownList = SearchedList.Substring((TargetPage - 1) * 100 * 7, Count * 7);
            // 종목리스트 요청
            axKHOpenAPI1.CommKwRqData(ShownList, 0, Count, 0, "종목리스트", "0010");

            SearchedList_Index = TargetPage;
            종목리스트_페이지.Text = TargetPage.ToString();
        }

        private void 종목리스트_인덱스_Click(object sender, EventArgs e)
        {
            Button ClickedButton = (Button)sender;

            int TargetPage = 1;

            if (ClickedButton == 종목리스트_다음) TargetPage = SearchedList_Index + 1;
            else TargetPage = SearchedList_Index - 1;

            SearchIndexChanged(TargetPage);

            
        }


        private void 종목리스트_페이지_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (종목리스트_페이지.Text == null) return;
                int TargetPage = int.Parse(종목리스트_페이지.Text.ToString());
                SearchIndexChanged(TargetPage);
            }

        }
        private void NumericCheck_KeyPress(object sender, KeyPressEventArgs e)
        {
            //숫자만 입력되도록 필터링
            if (!(char.IsDigit(e.KeyChar) || e.KeyChar == Convert.ToChar(Keys.Back)))    //숫자와 백스페이스를 제외한 나머지는 입력중지
            {
                e.Handled = true;
            }
        }
    }

}