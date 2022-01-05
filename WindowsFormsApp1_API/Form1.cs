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
        // 싱글톤패턴
        private static Form1 _Instance = null;
        public static Form1 Instance
        {
            get
            {
                if (_Instance == null) _Instance = new Form1();
                return _Instance;
            }
        }
        private Form1()
        {
            InitializeComponent();
            axKHOpenAPI1.OnReceiveRealData += OnReceiveRealData;
            ConstructorA();
            ConstructorB();

        }

        public void OnEventConnect(object sender, AxKHOpenAPILib._DKHOpenAPIEvents_OnEventConnectEvent e)
        {
            OnEventConnectA(sender,e);
            OnEventConnectB(sender,e);

        }



        public void onReceiveTrData(object sender, AxKHOpenAPILib._DKHOpenAPIEvents_OnReceiveTrDataEvent e)
        {
            OnReceiveA(sender,e);
            OnReceiveB(sender,e);
        }

        public void OnReceiveRealData(object sender, AxKHOpenAPILib._DKHOpenAPIEvents_OnReceiveRealDataEvent e)
        {
            OnReceiveRealDataA(sender, e);
            OnReceiveRealDataB(sender, e);
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void 매수_주_Click(object sender, EventArgs e)
        {
            if(주_선택.Visible == true)
                주_선택.Visible = false;
            else
                주_선택.Visible = true;
        }

        private void 매도_주_Click(object sender, EventArgs e)
        {
            if (주_선택.Visible == true)
                주_선택.Visible = false;
            else
                주_선택.Visible = true;
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void chart1_AxisViewChanged(object sender, System.Windows.Forms.DataVisualization.Charting.ViewEventArgs e)
        {

        }
    }
}