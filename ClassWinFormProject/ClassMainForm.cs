﻿using System;
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

        private void buttonHello_Click(object sender, EventArgs e)
        {
            _10201_Hello hello = new _10201_Hello();
            this.Visible = false;
            hello.Show();
        }

        private void buttonTextCalculate_Click(object sender, EventArgs e)
        {
            _10201_TextCalculate calculate = new _10201_TextCalculate();
            this.Visible = false;
            calculate.Show();
        }

        private void buttonStatistic_Click(object sender, EventArgs e)
        {
            _10201_Statistic statistic = new _10201_Statistic();
            this.Visible = false;
            statistic.Show();
        }

        private void buttonTextBox_Click(object sender, EventArgs e)
        {
            _10201_TextBox textBox = new _10201_TextBox();
            this.Visible = false;
            textBox.Show();
        }

        private void button_Click(object sender, EventArgs e)
        {
            _10201_Member member = new _10201_Member();
            this.Visible = false;
            member.Show();
        }

        private void buttonTicket_Click(object sender, EventArgs e)
        {
            _10201_Ticket ticket = new _10201_Ticket();
            this.Visible = false;
            ticket.Show();
        }

        private void buttonTimer_Click(object sender, EventArgs e)
        {
            _10201_Timer timer = new _10201_Timer();
            this.Visible = false;
            timer.Show();
        }

        private void buttonMarquee_Click(object sender, EventArgs e)
        {
            _10201_Marquee marquee = new _10201_Marquee();
            this.Visible = false;
            marquee.Show();
        }

        private void buttonLogic_Click(object sender, EventArgs e)
        {
            _10201_Logic logic = new _10201_Logic();
            this.Visible = false;
            logic.Show();
        }

        private void buttonIf_Click(object sender, EventArgs e)
        {
            _10201_IF iF = new _10201_IF();
            this.Visible = false;
            iF.Show();
        }

        private void buttonWhile_Click(object sender, EventArgs e)
        {
            _10201_While @while = new _10201_While();
            this.Visible = false;
            @while.Show();
        }

        private void buttonFor_Click(object sender, EventArgs e)
        {
            _10201_For @for = new _10201_For();
            this.Visible = false;
            @for.Show();
        }

        private void buttonFor1_Click(object sender, EventArgs e)
        {
            _10201_For1 @for = new _10201_For1();
            this.Visible = false;
            @for.Show();
        }

        private void buttonCompounding_Click(object sender, EventArgs e)
        {
            _10201_Compounding compounding = new _10201_Compounding();
            this.Visible = false;
            compounding.Show();
        }

        private void buttonMoney_Click(object sender, EventArgs e)
        {
            _10201_Money money = new _10201_Money();
            this.Visible = false;
            money.Show();
        }

        private void buttonContinue_Click(object sender, EventArgs e)
        {
            _10201_Continue @continue = new _10201_Continue();
            this.Visible = false;
            @continue.Show();
        }

        private void toolStripLabel2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("PortfolioMainForm.exe");
            this.Visible = false;
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            ClassMainForm1 main = new ClassMainForm1();
            this.Visible = false;
            main.Show();
        }
    }
}