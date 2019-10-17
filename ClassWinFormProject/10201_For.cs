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
    public partial class _10201_For : Form
    {
        public _10201_For()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i, j, result;
            string output = "";
            // 第一層
            for (i = 1; i <= 10; i++)
            {
                j = 1;
                do  // 第二層
                {
                    result = i * j;
                    output += i + "*" + j + "=" + result + "\t";
                    j++;
                } while (j <= 9);
                output += "\r\n";
            }
            textBoxOutput.Text = output;
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
            ClassMainForm main = new ClassMainForm();
            this.Visible = false;
            main.Show();
        }
    }
}