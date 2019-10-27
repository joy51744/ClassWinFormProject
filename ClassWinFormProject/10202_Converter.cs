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
    public partial class _10202_Converter : Form
    {
        public _10202_Converter()
        {
            InitializeComponent();
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
            ClassMainForm1 main = new ClassMainForm1();
            this.Visible = false;
            main.Show();
        }

        private void 單位轉換ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _10202_UnitConverter unitConverter = new _10202_UnitConverter();
            this.Visible = false;
            unitConverter.Show();
        }

        private void 格式轉換ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _10202_FormatConverter format = new _10202_FormatConverter();
            this.Visible = false;
            format.Show();
        }

        private void 日期轉換ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _10202_DateTimeConvert dateTime = new _10202_DateTimeConvert();
            this.Visible = false;
            dateTime.Show();
        }

        private void 語言轉換ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _10202_LanguageConvert language = new _10202_LanguageConvert();
            this.Visible = false;
            language.Show();
        }
    }
}