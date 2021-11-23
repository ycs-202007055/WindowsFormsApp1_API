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
    public partial class Form1 : Form
    {
        void ConstructorB()
        { 
            label10.Text = "test";
            axKHOpenAPI1.OnEventConnect += OnEventConnect;
            axKHOpenAPI1.CommConnect();
            axKHOpenAPI1.OnReceiveTrData += onReceiveTrData;
            
        }

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
        }




        void OnReceiveB(object sender, AxKHOpenAPILib._DKHOpenAPIEvents_OnReceiveTrDataEvent e)
        {

            
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
        private void button15_Click(object sender, EventArgs e)
        {
            매수_수량.Value = 0;
        }
    }
}