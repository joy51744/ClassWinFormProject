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
    public partial class _10201_String : Form
    {
        public _10201_String()
        {
            InitializeComponent();
        }

        private void _10201_String_Load(object sender, EventArgs e)
        {
            string str1 = string.Format("{0:N1}", 56789);
            string str2 = string.Format("{0:N2}", 56789);
            string str3 = string.Format("{0:N3}", 56789);
            string str4 = string.Format("{0:F1}", 56789);
            string str5 = (56789 / 100).ToString("#0.00");
            string str6 = string.Format("{0:C1}", 56789);
            string str8 = string.Format("{0:C2}", 56789);
            string str7 = string.Format("{0:P2}", 0.69723);
            label1.Text = "String.Format各種字串格式:" + "\r\n" +
                "一、{N}:整數位數" + "\r\n" +
                "1." + str1.ToString() + "\r\n" +
                "2." + str2.ToString() + "\r\n" +
                "3." + str3.ToString() + "\r\n" +
                "二、{F}/#:小數點位數" + "\r\n" +
                "4." + str4.ToString() + "\r\n" +
                "5." + str5 + "\r\n" +
                "三、{C}:貨幣" + "\r\n" +
                "6." + str6.ToString() + "\r\n" +
                "7." + str8.ToString() + "\r\n" +
                "四、{P}:百分比" + "\r\n" +
                "8." + str7.ToString();
        }

        private void 日期輸入ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _10201_DateTime main = new _10201_DateTime();
            this.Visible = false;
            main.Show();
        }

        private void ToolStripLabel2_Click(object sender, EventArgs e)
        {
            ClassMainForm main = new ClassMainForm();
            this.Visible = false;
            main.Show();
        }
    }
}