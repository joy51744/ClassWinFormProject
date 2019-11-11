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
    public partial class _10202_Converter : Form
    {
        public _10202_Converter()
        {
            InitializeComponent();
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
            ClassMainForm1 main = new ClassMainForm1();
            this.Visible = false;
            main.Show();
        }

        private void 單位轉換ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _10202_UnitConverter unitConverter = new _10202_UnitConverter();
            this.Visible = false;
            unitConverter.Show();
        }

        private void button16To10_Click(object sender, EventArgs e)
        {
            string myBrinary = textBox1.Text;
            int myNum = Convert.ToInt32(myBrinary, 16);
            textBox2.Text = Convert.ToString(myNum, 10);
        }

        private void button2To10_Click(object sender, EventArgs e)
        {
            string myBrinary = textBox1.Text;
            int myNum = Convert.ToInt32(myBrinary, 2);
            textBox2.Text = myNum.ToString();
        }

        private void button2To8_Click(object sender, EventArgs e)
        {
            string myBrinary = textBox1.Text;
            int myNum = Convert.ToInt32(myBrinary, 2);
            textBox2.Text = Convert.ToString(myNum, 8);
        }

        private void button2To16_Click(object sender, EventArgs e)
        {
            string myBrinary = textBox1.Text;
            int myNum = Convert.ToInt32(myBrinary, 2);
            textBox2.Text = Convert.ToString(myNum, 16);
        }

        private void button8To2_Click(object sender, EventArgs e)
        {
            string myBrinary = textBox1.Text;
            int myNum = Convert.ToInt32(myBrinary, 8);
            textBox2.Text = Convert.ToString(myNum, 2);
        }

        private void button8To10_Click(object sender, EventArgs e)
        {
            string myBrinary = textBox1.Text;
            int myNum = Convert.ToInt32(myBrinary, 8);
            textBox2.Text = Convert.ToString(myNum, 10);
        }

        private void button8To16_Click(object sender, EventArgs e)
        {
            string myBrinary = textBox1.Text;
            int myNum = Convert.ToInt32(myBrinary, 8);
            textBox2.Text = Convert.ToString(myNum, 16);
        }

        private void button10To2_Click(object sender, EventArgs e)
        {
            string myBrinary = textBox1.Text;
            int myNum = Convert.ToInt32(myBrinary, 10);
            textBox2.Text = Convert.ToString(myNum, 2);
        }

        private void button10To8_Click(object sender, EventArgs e)
        {
            string myBrinary = textBox1.Text;
            int myNum = Convert.ToInt32(myBrinary, 10);
            textBox2.Text = Convert.ToString(myNum, 8);
        }

        private void button10To16_Click(object sender, EventArgs e)
        {
            string myBrinary = textBox1.Text;
            int myNum = Convert.ToInt32(myBrinary, 10);
            textBox2.Text = Convert.ToString(myNum, 16);
        }

        private void button16To2_Click(object sender, EventArgs e)
        {
            string myBrinary = textBox1.Text;
            int myNum = Convert.ToInt32(myBrinary, 16);
            textBox2.Text = Convert.ToString(myNum, 2);
        }

        private void button16To8_Click(object sender, EventArgs e)
        {
            string myBrinary = textBox1.Text;
            int myNum = Convert.ToInt32(myBrinary, 16);
            textBox2.Text = Convert.ToString(myNum, 8);
        }
    }
}