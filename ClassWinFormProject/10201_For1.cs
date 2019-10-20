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
    public partial class _10201_For1 : Form
    {
        public _10201_For1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i, j;
            string output = "";
            // 第一層
            for (i = 1; i <= 9; i++)
            {
                // 第二層
                for (j = 1; j <= i; j++)
                    output += j;
                output += "\r\n";
            }
            textBox1.Text = output;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int i, j;
            string output = "";

            //第一層
            for (i = 9; i >= 1; i--)
            {
                //第二層
                for (j = 1; j <= i; j++)
                    output += j;
                output += "\r\n";
            }
            textBox1.Text = output;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int i, j, k, numOfStars = 1;
            string output = "";
            // 第一層
            for (i = 9; i >= 1; i--)
            {
                // 第二層
                for (j = 1; j <= i; j++)
                    // 是否顯示
                    if (j == i)
                    {
                        output += " ";
                        // 第三層
                        for (k = 1; k <= numOfStars; k++)
                            output += "*"; // 顯示
                    }
                    else
                        output += "  ";  // 顯示空白字元
                numOfStars += 2; // 每次左右增加二個字元
                output += "\r\n";
            }
            textBox1.Text = output;
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
            ClassMainForm main = new ClassMainForm();
            this.Visible = false;
            main.Show();
        }
    }
}