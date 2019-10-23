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
    public partial class _10202_SlideShow : Form
    {
        public _10202_SlideShow()
        {
            InitializeComponent();
        }

        private void _10202_SlideShow_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            if (pictureBox1.Visible == true)
            {
                pictureBox1.Visible = false;
                label2.Text = "鹿港的老厝";
                pictureBox2.Visible = true;
            }
            else if (pictureBox2.Visible == true)
            {
                pictureBox2.Visible = false;
                label2.Text = "日月潭";
                pictureBox3.Visible = true;
            }
            else if (pictureBox3.Visible == true)
            {
                pictureBox3.Visible = false;
                label2.Text = "合歡山";
                pictureBox4.Visible = true;
            }
            else if (pictureBox4.Visible == true)
            {
                pictureBox4.Visible = false;
                label2.Text = "阿里山";
                pictureBox5.Visible = true;
            }
            else if (pictureBox5.Visible == true)
            {
                pictureBox5.Visible = false;
                label2.Text = "台南台江";
                pictureBox6.Visible = true;
            }
            else if (pictureBox6.Visible == true)
            {
                pictureBox6.Visible = false;
                label2.Text = "阿里山";
                pictureBox7.Visible = true;
            }
            else if (pictureBox7.Visible == true)
            {
                pictureBox7.Visible = false;
                label2.Text = "清境";
                pictureBox8.Visible = true;
            }
            else if (pictureBox8.Visible == true)
            {
                pictureBox8.Visible = false;
                label2.Text = "中正紀念堂";
                pictureBox9.Visible = true;
            }
            else if (pictureBox9.Visible == true)
            {
                pictureBox9.Visible = false;
                label2.Text = "高鐵台中站";
                pictureBox10.Visible = true;
            }
            else if (pictureBox10.Visible == true)
            {
                pictureBox10.Visible = false;
                label2.Text = "中正紀念堂";
                pictureBox11.Visible = true;
            }
            else if (pictureBox11.Visible == true)
            {
                pictureBox11.Visible = false;
                label2.Text = "十分大瀑布";
                pictureBox12.Visible = true;
            }
            else if (pictureBox12.Visible == true)
            {
                pictureBox12.Visible = false;
                label2.Text = "101";
                pictureBox13.Visible = true;
            }
            else if (pictureBox13.Visible == true)
            {
                pictureBox13.Visible = false;
                label2.Text = "象山";
                pictureBox14.Visible = true;
            }
            else if (pictureBox14.Visible == true)
            {
                pictureBox14.Visible = false;
                label2.Text = "黃金瀑布";
                pictureBox15.Visible = true;
            }
            else if (pictureBox15.Visible == true)
            {
                pictureBox15.Visible = false;
                label2.Text = "奇美博物館";
                pictureBox1.Visible = true;
            }
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
            ClassMainForm1 main = new ClassMainForm1();
            this.Visible = false;
            main.Show();
        }
    }
}