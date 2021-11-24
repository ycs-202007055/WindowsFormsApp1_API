using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


// https://wikidocs.net/17615

namespace WindowsFormsApp1_API
{
    public partial class Form1 
    {
        void ConstructorA()
        {


        }

        void OnReceiveA(object sender, AxKHOpenAPILib._DKHOpenAPIEvents_OnReceiveTrDataEvent e)
        {
            if (e.sRQName == "종목정보")
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
                if (DaytoDay > 0) 전일대비.ForeColor = Color.Red;
                else if (DaytoDay < 0) 전일대비.ForeColor = Color.Blue;
                else 전일대비.ForeColor = Color.Black;
                전일대비.Text = string.Format("{0:#,##0}", Math.Abs(DaytoDay));

                string FluRate = axKHOpenAPI1.GetCommData(e.sTrCode, e.sRQName, 0, "등락율");
                float FluRatef = float.Parse(FluRate);
                if (FluRatef > 0) 등락률.ForeColor = Color.Red;
                else if (FluRatef < 0) 등락률.ForeColor = Color.Blue;
                else 등락률.ForeColor = Color.Black;
                등락률.Text = FluRate + "%";



            }
            else if (e.sRQName == "종목정보_거래대금")
            {
                int Trading_Value = int.Parse(axKHOpenAPI1.GetCommData(e.sTrCode, e.sRQName, 0, "거래대금"));
                거래대금.Text = string.Format("{0:#,##0}", Trading_Value);
            }
            else if(e.sRQName == "체결정보")
            {
                체결강도.Text = axKHOpenAPI1.GetCommData(e.sTrCode, e.sRQName, 0, "체결강도");
            }
            else if(e.sRQName == "관심종목")
            {
                //((StockItem)종목리스트.Controls[StockTRNum]).CurrentPrice = "48449";
                //label3.Text = axKHOpenAPI1.GetCommData(e.sTrCode, e.sRQName, 0, "현재가");
            }
        }

        void OnEventConnectA(object sender, AxKHOpenAPILib._DKHOpenAPIEvents_OnEventConnectEvent e)
        {
            // 주식 정보 표시 ( 차트 오른쪽 )
            axKHOpenAPI1.SetInputValue("종목코드", "005380");
            axKHOpenAPI1.CommRqData("종목정보", "opt10001", 0, "0000");

            axKHOpenAPI1.SetInputValue("종목코드", "005380");
            axKHOpenAPI1.CommRqData("체결정보", "opt10003", 0, "0000");

            axKHOpenAPI1.SetInputValue("종목코드", "005380");
            axKHOpenAPI1.SetInputValue("기준일자", DateTime.Now.ToString("yyyyMMdd"));
            axKHOpenAPI1.SetInputValue("수정주가구분", "0");
            axKHOpenAPI1.CommRqData("종목정보_거래대금", "opt10081", 0, "0000");
            

            // 관심 종목
            String StockList = axKHOpenAPI1.GetCodeListByMarket("0");
            axKHOpenAPI1.CommKwRqData(StockList,0,100,0,"종목리스트","0000");

            
           

        }
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

                // 종목 리스트 (관심 종목)
                /*
                int count = Math.Min(종목리스트.Controls.Count, 100);
                for (int i = 0; i < count; i++)
                {
                    ((StockItem)종목리스트.Controls[i]).CurrentPrice = axKHOpenAPI1.GetCommRealData(e.sRealKey, 10);
                    ((StockItem)종목리스트.Controls[i]).FluRate = axKHOpenAPI1.GetCommRealData(e.sRealKey, 12);
                    ((StockItem)종목리스트.Controls[i]).DayToDay = axKHOpenAPI1.GetCommRealData(e.sRealKey, 11);
                    ((StockItem)종목리스트.Controls[i]).TradingVolume = axKHOpenAPI1.GetCommRealData(e.sRealKey, 17);

                }*/
            }
        }

    }
}