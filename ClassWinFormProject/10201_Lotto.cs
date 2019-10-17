using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassWinFormProject
{
    public partial class _10201_Lotto : Form
    {
        private Random ran = new Random();
        private int[] num = new int[43];//42個樂透號碼
        private int[] ans = new int[7];//6個樂透號碼答案
        private int r, tmp, a;

        public _10201_Lotto()
        {
            InitializeComponent();
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
            ClassMainForm main = new ClassMainForm();
            this.Visible = false;
            main.Show();
        }

        private void btn_choose_Click(object sender, EventArgs e)
        {
            int i;
            resetNum();
            //運用雙迴圈,產生六個樂透號碼
            for (i = 1; i <= 6; i++)
            {
                //製作效果,讓for loop的結果,每次都能夠顯示出來
                //此迴圈用意為挑選某一項num[j]
                for (int j = 1; j <= 200; j++)
                {
                    r = j % 200;
                    Thread.Sleep(1);//每(1/1000秒)取得一次狀態,使用時須先導入using System.Threading;
                    Application.DoEvents();//將狀態停止並顯示出來
                    label1.Text = ran.Next(1, 44 - i).ToString();//範圍自行設定(大於等於1&&小於44-i)
                    a = Convert.ToInt32(label1.Text);
                }
                if (r == 0)
                {//洗牌演算法,將挑重的號碼與最後一號交換,並繼續"洗牌"
                    tmp = num[a];
                    num[a] = num[43 - i];
                    num[43 - i] = tmp;
                    ans[i] = num[43 - i];
                    textBox1.Text += "第" + i + "個中獎的號碼為: " + ans[i].ToString() + "\r\n" + "\r\n";
                }
            }
        }

        private void resetNum()
        {
            textBox1.Text = "";
            for (int i = 1; i < 43; i++) //將數字填入num[i]
            {
                num[i] = i;
            }
        }
    }
}