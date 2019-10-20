using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassWinFormProject
{
    public partial class _10202_FormColor : Form
    {
        public _10202_FormColor()
        {
            InitializeComponent();
            InitializeTime();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Random a = new Random();
            Random b = new Random();
            Random c = new Random();
            int x = a.Next(0, 255);
            int y = b.Next(0, 100) / 2;

            Color c1 = Color.FromArgb(x, 1, y);
            this.BackColor = c1;
        }

        private void InitializeTime()
        {
            timer1.Interval = 1000;
            timer1.Enabled = true;
            timer1.Start();
        }
    }
}