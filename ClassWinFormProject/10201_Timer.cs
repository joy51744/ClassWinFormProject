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
    public partial class _10201_Timer : Form
    {
        private int counter = 0;

        public _10201_Timer()
        {
            InitializeComponent();
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            counter++;
            labelTimer.Text = "" + counter;
        }

        private void 計時器2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _10201_Timer1 timer = new _10201_Timer1();
            this.Visible = false;
            timer.Show();
        }

        private void toolStripLabel2_Click(object sender, EventArgs e)
        {
            ClassMainForm main = new ClassMainForm();
            this.Visible = false;
            main.Show();
        }
    }
}