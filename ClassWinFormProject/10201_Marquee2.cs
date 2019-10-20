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
    public partial class _10201_Marquee2 : Form
    {
        public _10201_Marquee2()
        {
            InitializeComponent();
        }

        private void buttonEnter_Click(object sender, EventArgs e)
        {
            label1.Text = textBox1.Text;
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = label1.Text.Substring(1) + label1.Text.Substring(0, 1);
            //label1.Text = label1.Text.Substring(label1.Text.Length - 1, 1) + label1.Text.Substring(0, label1.Text.Length - 1);
        }

        private void 跑馬燈1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _10201_Marquee marquee = new _10201_Marquee();
            this.Visible = false;
            marquee.Show();
        }

        private void toolStripLabel2_Click(object sender, EventArgs e)
        {
            MainForm main = new MainForm();
            this.Visible = false;
            main.Show();
        }
    }
}