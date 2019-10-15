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
    public partial class ClassMainForm : Form
    {
        public ClassMainForm()
        {
            InitializeComponent();
        }

        private void toolStripLabel2_Click(object sender, EventArgs e)
        {
            MainForm main = new MainForm();
            this.Visible = false;
            main.Show();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            ClassMainForm1 main = new ClassMainForm1();
            this.Visible = false;
            main.Show();
        }

        private void buttonHello_Click(object sender, EventArgs e)
        {
            _10201_Hello hello = new _10201_Hello();
            this.Visible = false;
            hello.Show();
        }
    }
}