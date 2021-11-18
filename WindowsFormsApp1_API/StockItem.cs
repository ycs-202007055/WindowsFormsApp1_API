using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1_API
{
    public partial class StockItem : UserControl
    {
        public StockItem()
        {
            InitializeComponent();
        }

        public string StockName
        {
            get { return 종목명.Text; }
            set { 종목명.Text = value; }
        }
        public string CurrentPrice
        {
            get { return 현재가.Text; }
            set 
            {
               // 현재가.Text = string.Format("{0:#,##0}", int.Parse(value));
            }
        }
        public string FluRate
        {
            get { return 등락률.Text; }
            set {
                float FluRatef = float.Parse(value);
                if (FluRatef > 0) 등락률.ForeColor = Color.Red;
                else if (FluRatef < 0) 등락률.ForeColor = Color.Blue;
                else 등락률.ForeColor = Color.Black;

                char sign = '\0';
                if (FluRatef > 0) sign = '+';
                else if (FluRatef < 0) sign = '-';

                등락률.Text = sign + value + "%";
            }
        }
        public string DayToDay
        {
            get { return 전일대비.Text; }
            set {
                
                int DayToDayi = (int)float.Parse(value);       
                string DayToDays = string.Format("{0:#,##0}", DayToDayi);
                if (DayToDayi > 0) 전일대비.ForeColor = Color.Red;
                else if (DayToDayi < 0) 전일대비.ForeColor = Color.Blue;
                else 전일대비.ForeColor = Color.Black;

                전일대비.Text = DayToDays;
            }
        }
        public string TradingVolume
        {
            get { return 거래대금.Text; }
            set { 거래대금.Text = string.Format("{0:#,##0}", int.Parse(value)) + "백만"; ; }
        }
    }
   
    

}
