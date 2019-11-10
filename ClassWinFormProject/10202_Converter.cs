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

        private void buttonCharTo16_Click(object sender, EventArgs e)
        {
            try
            {
                string[] array10 = textBox1.Text.Trim().Split(' ');
                int[] charArr = ConvertCharTo10(array10);
                string[] array16 = Convert10To16(charArr);
                for (int i = 0; i < array16.Length; i++)
                {
                    textBox2.Text += array16[i] + " ";
                }
            }
            catch (Exception)
            {
                MessageBox.Show("請輸入正確數值");
            }
        }

        private string[] Convert10To16(int[] strArr)
        {
            string[] array16 = null;
            try
            {
                if (strArr != null && strArr.Length > 0)
                {
                    array16 = new string[strArr.Length];
                    for (int i = 0; i < strArr.Length; i++)
                    {
                        array16[i] = Convert.ToString(strArr[i], 16);
                    }
                }
                return array16;
            }
            catch (Exception ex)
            {
                return array16;
            }
        }

        private int[] ConvertCharTo10(string[] strArr)
        {
            int[] charArr = null;
            try
            {
                string str = null;
                if (strArr != null && strArr.Length > 0)
                {
                    for (int i = 0; i < strArr.Length; i++)
                    {
                        if (strArr[i].Trim() != null)
                        {
                            str += strArr[i];
                        }
                    }
                    charArr = new int[str.Length];
                    for (int i = 0; i < str.Length; i++)
                    {
                        charArr[i] = Convert.ToInt32(str[i]);
                    }
                }
                return charArr;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return charArr;
            }
        }

        private void button16ToChar_Click(object sender, EventArgs e)
        {
        }
    }
}