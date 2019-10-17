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
    public partial class _10201_Sort : Form
    {
        public _10201_Sort()
        {
            InitializeComponent();
        }

        private int[] a = new int[5];

        private int i = 0;

        private void _10201_Sort_Load(object sender, EventArgs e)
        {
            labelSort.Text = "排序前的數字陣列：";
        }

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            if (i < 5)
            {
                a[i] = Convert.ToInt32(textBox1.Text);
                labelSort.Text += Convert.ToString(a[i]) + " ";
                i++;
                textBox1.Text = "";
            }
        }

        private void ButtonSort_Click(object sender, EventArgs e)
        {
            Array.Sort(a);
            labelSort.Text += "\n 排序後的數字陣列: " + a[0] + " " + a[1] + " " + a[2] + " " + a[3] + " " + a[4];
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
            ClassMainForm main = new ClassMainForm();
            this.Visible = false;
            main.Show();
        }
    }
}