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
        public StockItem(string StockCode)
        {
            InitializeComponent();
 

            StockName = "현대차";
            CurrentPrice = "1000";
            FluRate = "0.1";
            DayToDay = "100";
            TradingVolume = "100";
            this.StockCode = StockCode;


  
        }

        private string StockName_;      // 주식명
        private string CurrentPrice_;   // 현재가
        private string FluRate_;        // 등락률
        private string DayToDay_;       // 전일대비
        private string TradingVolume_;  // 거래대금
        private string StockCode;          // 종목 코드

        public string StockName
        {
            get { return StockName_; }
            set 
            {
                StockName_ = value;
                종목명.Text = StockName_; 
            }
        }
        public string CurrentPrice
        {
            get { return CurrentPrice_; }
            set 
            {
                CurrentPrice_ = value;
                현재가.Text = string.Format("{0:#,##0}", int.Parse(CurrentPrice_));
            }
        }
       
        
        
        public string FluRate
        {
            get { return FluRate_; }
            set {
                FluRate_ = value;

                float FluRatef = float.Parse(FluRate_);
                if (FluRatef > 0)
                {
                    등락률.ForeColor = Color.Red;
                    전일대비.ForeColor = Color.Red;
                    현재가.ForeColor = Color.Red;
                }
                else if (FluRatef < 0)
                {
                    등락률.ForeColor = Color.Blue;
                    전일대비.ForeColor = Color.Blue;
                    현재가.ForeColor = Color.Blue;
                }
                else
                {
                    등락률.ForeColor = Color.Black;
                    전일대비.ForeColor = Color.Black;
                    현재가.ForeColor = Color.Black;
                }
                char sign = '\0';
                if (FluRatef > 0) sign = '+';
                else if (FluRatef < 0) sign = '-';

                등락률.Text = sign + FluRate_ + "%";
            }
        }
        public string DayToDay
        {
            get { return DayToDay_; }
            set {
                DayToDay_ = value;   
                string DayToDays = string.Format("{0:#,##0}", DayToDay_);
                전일대비.Text = DayToDays;
            }
        }
        public string TradingVolume
        {
            get { return TradingVolume_; }
            set 
            {
                TradingVolume_ = value;
                거래대금.Text = string.Format("{0:#,##0}", int.Parse(TradingVolume_)) + "백만";
            }
        }

        private void StockItem_Paint(object sender, PaintEventArgs e)
        {
            

        }
    }
   
    

}
