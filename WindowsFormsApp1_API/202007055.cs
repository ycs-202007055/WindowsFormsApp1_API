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
            axKHOpenAPI1.SendOrder("", "0000", 계좌번호콤보.Text, 1, "005380", 1, int.Parse(label21.Text), "00", "");
        }
        private void 매도_매도버튼_Click(object sender, EventArgs e)
        {

        }
    }
}