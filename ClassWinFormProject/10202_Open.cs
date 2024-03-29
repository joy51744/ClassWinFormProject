﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassWinFormProject
{
    public partial class _10202_Open : Form
    {
        public _10202_Open()
        {
            InitializeComponent();
        }

        private void buttonOpen_Click(object sender, EventArgs e)
        {
            DateTime now = System.DateTime.Now;
            openFileDialog1.ShowDialog();
            string filename = openFileDialog1.FileName;
            string readfile = File.ReadAllText(filename);
            richTextBox1.Text = readfile + "\r\n" + now.ToShortDateString();
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
            ClassMainForm1 main = new ClassMainForm1();
            this.Visible = false;
            main.Show();
        }
    }
}