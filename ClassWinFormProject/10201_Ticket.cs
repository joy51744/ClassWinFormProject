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
    public partial class _10201_Ticket : Form
    {
        public _10201_Ticket()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            string str1, date1, date2;
            str1 = "您訂購";
            date1 = dtpDate.Value.Month.ToString() + "/" + dtpDate.Value.Day.ToString();
            str1 += date1 + " ";
            str1 += cbxTime.Text + '\n';
            str1 += cbxStart.Text + " 到 ";
            str1 += cbxArrival.Text + '\n';
            str1 += "車票" + nudTicket.Value.ToString() + "張 \n";
            date2 = DateTime.Today.AddDays(2).Month.ToString() + "/" + DateTime.Today.AddDays(2).Day.ToString();
            str1 += "請於 " + date2 + " 23:00 前取票 !";
            MessageBox.Show(str1);
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
            ClassMainForm main = new ClassMainForm();
            this.Visible = false;
            main.Show();
        }
    }
}