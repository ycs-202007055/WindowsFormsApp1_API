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
        void ConstructorA()
        {
            고가.Text = "ㅇ";
        }

        void OnReceiveA(object sender, AxKHOpenAPILib._DKHOpenAPIEvents_OnReceiveTrDataEvent e)
        {

        }

        void OnEventConnectA(object sender, AxKHOpenAPILib._DKHOpenAPIEvents_OnEventConnectEvent e)
        {

        }

    }
}