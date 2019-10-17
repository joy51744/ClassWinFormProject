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
    public partial class _10201_Timer1 : Form
    {
        private System.Timers.Timer Mytimer;
        private long TimeCount;

        //定義委託
        public delegate void SetControlValue(long value);

        public _10201_Timer1()
        {
            InitializeComponent();
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            timer1.Start();
            TimeCount = 0;
        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Invoke(new SetControlValue(ShowTime), TimeCount);
            TimeCount++;
        }

        private void ShowTime(long t)
        {
            TimeSpan temp = new TimeSpan(0, 0, (int)t);
            labelTimer.Text = string.Format("{0:00}:{1:00}:{2:00}", temp.Hours, temp.Minutes, temp.Seconds);
        }

        private void _10201_Timer1_Load(object sender, EventArgs e)
        {
            int interval = 1000;
            Mytimer = new System.Timers.Timer(interval);
            Mytimer.AutoReset = true;
            Mytimer.Elapsed += new System.Timers.ElapsedEventHandler(timer1_Tick);
        }

        private void 計時器1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _10201_Timer timer = new _10201_Timer();
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