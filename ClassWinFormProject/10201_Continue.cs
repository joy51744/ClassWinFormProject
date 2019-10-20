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
    public partial class _10201_Continue : Form
    {
        public _10201_Continue()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int total = 0;
            int max, i = 0;

            max = Convert.ToInt32(textBox1.Text);
            while (i < max)
            {
                i += 1;
                if (i % 2 == 0)
                {
                    continue;
                }
                total += i;
            }
            textBox2.Text = total.ToString();
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
            ClassMainForm main = new ClassMainForm();
            this.Visible = false;
            main.Show();
        }
    }
}