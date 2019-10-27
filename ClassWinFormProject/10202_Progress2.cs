using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassWinFormProject
{
    public partial class _10202_Progress2 : Form
    {
        public _10202_Progress2()
        {
            InitializeComponent();
        }

        private void buttonRun_Click(object sender, EventArgs e)
        {
            for (int i = 1; i <= 100; i++)
            {
                Thread.Sleep(5);
                circularProgressBar1.Value = i;
                circularProgressBar1.Update();
            }
        }

        private void _10202_Progress2_Load(object sender, EventArgs e)
        {
            circularProgressBar1.Value = 0;
            circularProgressBar1.Minimum = 0;
            circularProgressBar1.Maximum = 100;
        }

        private void 進度條2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _10202_Progress progress = new _10202_Progress();
            this.Visible = false;
            progress.Show();
        }
    }
}