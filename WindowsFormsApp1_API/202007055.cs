﻿using System;
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
    public partial class Form1 : Form
    {

        chartdata chart; // 차트 출력 클래스 생성
        
        //
        // 계좌별주문체결현황요청
        //








        //
        // 접속 하자마자 예수금, 종목들 세팅 (계좌평가현황요청)
        //
        public void Account_setting(AxKHOpenAPILib.AxKHOpenAPI e)
        {
            //계좌번호 = 전문 조회할 보유계좌번호
             e.SetInputValue("계좌번호", 계좌번호콤보.Text);
            //비밀번호 = 사용안함(공백)
            e.SetInputValue("비밀번호", "");
            //상장폐지조회구분 = 0:전체, 1:상장폐지종목제외
            e.SetInputValue("상장폐지조회구분", "1");
            //비밀번호입력매체구분 = 00
            e.SetInputValue("비밀번호입력매체구분", "00");

            e.CommRqData("계좌초기화", "OPW00004", 0, "0000");
        }






        //
        // 차트 클래스, 함수
        //
        public class chartdata
        {
            public AxKHOpenAPILib.AxKHOpenAPI e;
            public int now_price; // 현재가
            public int hight_price; // 고가
            public int row_price; // 저가
            public int start_price; // 시가
            public String day; // 일자


            public chartdata // 생성자
            (AxKHOpenAPILib.AxKHOpenAPI e)
            {
                this.e = e;
            }

            public void chartCall()
            {
                e.SetInputValue("종목코드", "005380");
                e.SetInputValue("기준일자", "20211123");
                e.SetInputValue("수정주가구분", "0");
                e.CommRqData("chart", "opt10081", 0, "0000"); // ("내가 지정한 Rq이름", tr, 0, "화면번호");
                //e.CommData(e.sTrCode, e.sRQName, 0, "현재가");
            }
        };

        void ConstructorB()
        { 
            
            axKHOpenAPI1.OnEventConnect += OnEventConnect;
            axKHOpenAPI1.CommConnect();
            axKHOpenAPI1.OnReceiveTrData += onReceiveTrData;

            
            chart = new chartdata(axKHOpenAPI1); // 차트출력 클래스 생성
        }

        //
        // 로그인 이벤트
        //
        public void OnEventConnectB(object sender, AxKHOpenAPILib._DKHOpenAPIEvents_OnEventConnectEvent e)
        {
            String[] Acount = axKHOpenAPI1.GetLoginInfo("ACCLIST").Split(';');
            int i = 0;

            while (i < Acount.Length - 1)
            {
                계좌번호콤보.Items.Add(Acount[i]);
                i++;
            }
            계좌번호콤보.SelectedIndex = 0;
            axKHOpenAPI1.SetInputValue("계좌번호", 계좌번호콤보.Text);
            axKHOpenAPI1.SetInputValue("비밀번호", "");
            axKHOpenAPI1.SetInputValue("비밀번호입력매체구분", "00");
            axKHOpenAPI1.SetInputValue("조회구분", "2");
            axKHOpenAPI1.CommRqData("RQName", "opw00001", 0, "0000");


            Account_setting(axKHOpenAPI1);
        }

   


        void OnReceiveB(object sender, AxKHOpenAPILib._DKHOpenAPIEvents_OnReceiveTrDataEvent e) // CommRQdate()
        {
            if (e.sRQName == "chart")
            {
                chart.now_price = int.Parse(axKHOpenAPI1.GetCommData(e.sTrCode, e.sRQName, 0, "현재가")); // 현재가
                chart.hight_price = int.Parse(axKHOpenAPI1.GetCommData(e.sTrCode, e.sRQName, 0, "고가")); // 고가
                chart.row_price = int.Parse(axKHOpenAPI1.GetCommData(e.sTrCode, e.sRQName, 0, "저가"));   // 저가
                chart.start_price = int.Parse(axKHOpenAPI1.GetCommData(e.sTrCode, e.sRQName, 0, "시가")); // 시가
                chart.day = axKHOpenAPI1.GetCommData(e.sTrCode, e.sRQName, 0, "일자");                    // 일자

                chart1.Series["price"].YValueMembers = "now_price,row_price,hight_price";
                chart1.Series["price"].XValueMember = "day";

                chart1.Series["price"].Points.Add(chart.now_price);
                chart1.Series["price"].Points.Add(chart.row_price);
                chart1.Series["price"].Points.Add(chart.hight_price);


            }
            else if (e.sRQName == "계좌초기화")
            {
                label9.Text = string.Format("{0:#,##0}", int.Parse(axKHOpenAPI1.GetCommData(e.sTrCode, e.sRQName, 0, "예수금")));
                label24.Text = string.Format("{0:#,##0}", int.Parse(axKHOpenAPI1.GetCommData(e.sTrCode, e.sRQName, 0, "D+2추정예수금")));
                label10.Text = string.Format("{0:#,##0}", int.Parse(axKHOpenAPI1.GetCommData(e.sTrCode, e.sRQName, 0, "총매입금액")));
                label26.Text = string.Format("{0:#,##0}", int.Parse(axKHOpenAPI1.GetCommData(e.sTrCode, e.sRQName, 0, "평가금액")));
                label28.Text = string.Format("{0:#,##0}", int.Parse(axKHOpenAPI1.GetCommData(e.sTrCode, e.sRQName, 0, "손익금액")));
                label30.Text = (float.Parse(axKHOpenAPI1.GetCommData(e.sTrCode, e.sRQName, 0, "손익율")) / (float)10000).ToString();
                label32.Text = string.Format("{0:#,##0}", int.Parse(axKHOpenAPI1.GetCommData(e.sTrCode, e.sRQName, 0, "추정예탁자산")));
            }

            //-------------------------------------이 밑으로는 if문으로 RQName 구분 넣을 것

        }
        
        public void OnReceiveRealDataB(object sender, AxKHOpenAPILib._DKHOpenAPIEvents_OnReceiveRealDataEvent e)
        { 
            
        }

        private void 매수_매수버튼_Click(object sender, EventArgs e)
        {
            String temp = 현재가.Text.Replace(",", ""); // (텍스트에서 첫번째 인수를 찾고 두번째 인수로 교체 )
            if (매수_시장가.Checked == true)
            {   // (사용자 구분요청명(""), 화면번호(0000), 계좌번호, 주문유형(신규매수,매수취소 등등), 주식종목코드, 주문수량, 주문단가, 거래구분, 원주문번호)
                axKHOpenAPI1.SendOrder("" /*사용자 구분요청*/, 
                    "0000" /*화면번호*/, 
                    계좌번호콤보.Text /*계좌번호*/, 
                    1 /*주문유형*/, 
                    "005380" /*종목코드*/, 
                    (int)매수_수량.Value /*주문수량*/,
                    int.Parse(temp) /*주문단가*/,
                    "03" /*거래구분 (시장가, 지정가 등등)*/,
                    "" /*원주문번호*/);
            }
            else
            {
                axKHOpenAPI1.SendOrder("", "0000", 계좌번호콤보.Text, 1, "005380", 1, int.Parse(temp), "00", "");
            }
            

        }

        private void 매도_매도버튼_Click(object sender, EventArgs e)
        {
            
        }

        private void 매수_현재가_CheckedChanged(object sender, EventArgs e)
        {
            String temp = 현재가.Text.Replace(",", "");
            if (매수_현재가.Checked == true)
                매수_가격.Value = int.Parse(temp);
            else
                매수_가격.Value = 0;
           
        }
        private void 매수_시장가_CheckedChanged(object sender, EventArgs e)
        {
            if (매수_시장가.Checked == true)
            {
                매수_가격.Enabled = false;
            }
            else
            {
                매수_가격.Enabled = true;
            }
        }
        private void button15_Click(object sender, EventArgs e) // 매수_주_0
        {
            매수_수량.Value = 0;
        }

        private void button16_Click(object sender, EventArgs e) // 매수_주_1
        {
            매수_수량.Value += 1;
        }

        private void button17_Click(object sender, EventArgs e) // 매수_주_5
        {
            매수_수량.Value += 5;
        }

        private void button18_Click(object sender, EventArgs e) // 매수_주_10
        {
            매수_수량.Value += 10;
        }

        private void button19_Click(object sender, EventArgs e) // 매수_주_50
        {
            매수_수량.Value += 50;
        }

        private void button20_Click(object sender, EventArgs e) // 매수_주_100
        {
            매수_수량.Value += 100;
        }

        private void button26_Click(object sender, EventArgs e) // 매수_주_200
        {
            매수_수량.Value += 200;
        }

        private void button25_Click(object sender, EventArgs e) // 매수_주_300
        {
            매수_수량.Value += 300;
        }

        private void button24_Click(object sender, EventArgs e) // 매수_주_400
        {
            매수_수량.Value += 400;
        }

        private void button23_Click(object sender, EventArgs e) // 매수_주_500
        {
            매수_수량.Value += 500;
        }

        private void button22_Click(object sender, EventArgs e) // 매수_주_1000
        {
            매수_수량.Value += 1000;
        }

        private void 검색버튼_Click(object sender, EventArgs e)
        {
            chart.chartCall();
        }







    }
}