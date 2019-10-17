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
    public partial class _10201_Compounding : Form
    {
        public _10201_Compounding()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double principal, rate, interest; //本金,利率,利息
            int endyear, year = 1; //結束年限, 第幾年

            principal = Convert.ToDouble(principalTB.Text);
            rate = Convert.ToDouble(rateTB.Text) / 100.0;
            endyear = Convert.ToInt32(endyearTB.Text);

            do
            {
                interest = principal * rate; //利息=本金*利率
                principal += interest; //本利和=本金+利息
                year++;
            } while (year <= endyear);

            //resultTB.Text = "NT$：" + principal;
            resultTB.Text = endyear + " 年後本利和：" + principal.ToString("C0");
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
            ClassMainForm main = new ClassMainForm();
            this.Visible = false;
            main.Show();
        }
    }
}