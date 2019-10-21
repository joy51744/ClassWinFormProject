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
    public partial class _10202_BubbleSort : Form
    {
        public _10202_BubbleSort()
        {
            InitializeComponent();
        }

        private void buttonSort_Click(object sender, EventArgs e)
        {
            int[] myArray = new int[] { 5, 30, 70, 65, 80 };
            textBoxBefore.Text = "排序前：";
            textBoxAfter.Text = "排序後：";
        }
    }
}