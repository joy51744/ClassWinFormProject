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
    public partial class _10202_Name : Form
    {
        public _10202_Name()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button1.Text == "開  始")
            {
                timer1.Enabled = true;
                button1.Text = "停  止";
            }
            else
            {
                timer1.Enabled = false;
                button1.Text = "開  始";
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            string[] name = {"黃曉明","楊  穎","鄧  超","孫  儷","董子健","孫  怡",
                "張雪迎","童  瑤","楊  爍","王黎雯","董  潔","潘粵明","王  凱","劉  濤",
                "翟天臨","張鈞甯","吳秀波","江鎧同","唐藝昕","張若昀","焦俊艷","高以翔",
                "李  現","楊 紫","鄧  倫","佟麗亞","陳思誠","李  晨","范冰冰","雷佳音"};
            Random rand = new Random();
            int count = rand.Next(0, name.Length - 1);
            labelName.Text = name[count];
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
            ClassMainForm1 main = new ClassMainForm1();
            this.Visible = false;
            main.Show();
        }
    }
}