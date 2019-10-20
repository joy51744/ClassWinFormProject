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
    public partial class ClassMainForm1 : Form
    {
        public ClassMainForm1()
        {
            InitializeComponent();
        }

        private void toolStripLabel2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("PortfolioMainForm.exe");
        }

        private void buttonLotto_Click(object sender, EventArgs e)
        {
            _10201_Lotto lotto = new _10201_Lotto();
            this.Visible = false;
            lotto.Show();
        }

        private void buttonName_Click(object sender, EventArgs e)
        {
        }

        private void buttonString_Click(object sender, EventArgs e)
        {
            _10201_String @string = new _10201_String();
            this.Visible = false;
            @string.Show();
        }

        private void buttonString1_Click(object sender, EventArgs e)
        {
            _10201_String1 @string = new _10201_String1();
            this.Visible = false;
            @string.Show();
        }

        private void buttonDateTime_Click(object sender, EventArgs e)
        {
            _10202_DateTime dateTime = new _10202_DateTime();
            this.Visible = false;
            dateTime.Show();
        }

        private void buttonSort_Click(object sender, EventArgs e)
        {
            _10201_Sort sort = new _10201_Sort();
            this.Visible = false;
            sort.Show();
        }
    }
}