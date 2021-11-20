using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1_API
{
    class DoubleBufferedFlow : FlowLayoutPanel
    {
        public DoubleBufferedFlow()
        {
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer | 
            ControlStyles.UserPaint |
            ControlStyles.AllPaintingInWmPaint, true);

            this.UpdateStyles();
        } 




    }
}
