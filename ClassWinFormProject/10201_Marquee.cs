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
    public partial class _10201_Marquee : Form
    {
        private string wk_txt = "我是馬顥心,歡迎參觀我的作品集,請多多指教。";

        public _10201_Marquee()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            string wk_one = wk_txt.Substring(0, 1); //第一個字
            wk_txt = wk_txt.Substring(1, wk_txt.Length - 1) + wk_one; //新字串每次從第二個字開始抓，然後把之前抓的第一個字補在最後
            label1.Text = wk_txt;
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
            ClassMainForm main = new ClassMainForm();
            this.Visible = false;
            main.Show();
        }
    }
}