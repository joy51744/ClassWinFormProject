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
    public partial class _10201_IF : Form
    {
        public _10201_IF()
        {
            InitializeComponent();
        }

        private void buttonEnter_Click(object sender, EventArgs e)
        {
            int a;
            a = int.Parse(textBox1.Text);

            if (a % 2 == 0)
            //a = a / 2;
            {
                labelMessage.Text = textBox1.Text + " 是偶數";
                labelMessage.ForeColor = System.Drawing.Color.Green;
            }

            if (a % 2 != 0)
            //a = a / 2;
            {
                labelMessage.Text = textBox1.Text + " 不是偶數";
                labelMessage.ForeColor = System.Drawing.Color.Red;
            }
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
            ClassMainForm main = new ClassMainForm();
            this.Visible = false;
            main.Show();
        }
    }
}