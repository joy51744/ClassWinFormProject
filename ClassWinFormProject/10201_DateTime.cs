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
    public partial class _10201_DateTime : Form
    {
        public _10201_DateTime()
        {
            InitializeComponent();
        }

        private void _10201_DateTime_Load(object sender, EventArgs e)
        {
            DateTime date1 = new DateTime(2019, 6, 2, 19, 7, 5);

            string d = string.Format("{0:d}", date1);
            string dd = string.Format("{0:dd}", date1);
            string ddd = string.Format("{0:ddd}", date1);
            string dddd = string.Format("{0:dddd}", date1);
            string hh = string.Format("{0:hh}", date1);
            string HH = string.Format("{0:HH}", date1);
            string mm = string.Format("{0:mm}", date1);
            string M = string.Format("{0:M}", date1);
            string MM = string.Format("{0:MM}", date1);
            string MMM = string.Format("{0:MMM}", date1);
            string MMMM = string.Format("{0:MMMM}", date1);
            string s = string.Format("{0:s}", date1);
            string ss = string.Format("{0:ss}", date1);

            label1.Text = "顯示時間為: " + "2019/6/2 19:7:5" + "\r\n" +
                          "一、d:天數有關格式規範" + "\r\n" +
                            "  {d}表示單一位數的天數會格式化為沒有前置零:" + d + "\r\n" +
                            "  {dd}表示單一位數的天數會格式化為有前置零:" + dd + "\r\n" +
                            "  {ddd}表示星期幾的縮寫名稱:" + ddd + "\r\n" +
                            "  {dddd}表示星期幾的縮寫名稱:" + dddd + "\r\n" +
                          "二、h:小時有關格式規範" + "\r\n" +
                            "  {hh}表示12小時制:" + hh + "\r\n" +
                            "  {HH}表示24小時制:" + HH + "\r\n" +
                          "三、m有關格式規範" + "\r\n" +
                            "  {mm}表示分鐘會格式化為有前置零:" + mm + "\r\n" +
                            "  {M}表示月份會格式化為沒有前置零:" + M + "\r\n" +
                            "  {MM}表示月份會格式化為有前置零:" + MM + "\r\n" +
                            "  {MMM}表示縮寫月份:" + MMM + "\r\n" +
                            "  {MMMM}表示示完整月份:" + MMMM + "\r\n" +
                          "四、秒數有關格式規範" + "\r\n" +
                            "  {s}表示:" + s + "\r\n" +
                            "  {ss}表示秒數會格式化為有前置零:" + ss + "\r\n";
        }

        private void toolStripLabel2_Click(object sender, EventArgs e)
        {
            ClassMainForm main = new ClassMainForm();
            this.Visible = false;
            main.Show();
        }

        private void 字串輸入ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _10201_String main = new _10201_String();
            this.Visible = false;
            main.Show();
        }
    }
}