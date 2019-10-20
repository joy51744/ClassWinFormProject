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
    public partial class _10201_String1 : Form
    {
        public _10201_String1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int len;
            len = textBoxInput.Text.Length;
            textBoxOutput.Text = len.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBoxOutput.Text = textBoxInput.Text.ToLower();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBoxOutput.Text = textBoxInput.Text.ToUpper();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (radioButtonTrim.Checked)
            {
                textBoxOutput.Text = textBoxInput.Text.Trim();
            }
            if (radioButtonTrimEnd.Checked)
            {
                textBoxOutput.Text = textBoxInput.Text.TrimEnd();
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