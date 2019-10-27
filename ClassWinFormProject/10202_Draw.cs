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
    public partial class _10202_Draw : Form
    {
        public _10202_Draw()
        {
            InitializeComponent();
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
            ClassMainForm1 main = new ClassMainForm1();
            this.Visible = false;
            main.Show();
        }
    }
}