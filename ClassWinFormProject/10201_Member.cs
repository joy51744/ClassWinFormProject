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
    public partial class _10201_Member : Form
    {
        public _10201_Member()
        {
            InitializeComponent();
        }

        private void buttonEnter_Click(object sender, EventArgs e)
        {
            string gender = "性別：", interest = "興趣：", msg;

            if (radioButtonMale.Checked) gender += radioButtonMale.Text;
            if (radioButtonFemale.Checked) gender += radioButtonFemale.Text;

            if (checkBox會計學.Checked) interest += checkBox會計學.Text + "、";
            if (checkBox經濟學.Checked) interest += checkBox經濟學.Text + "、";
            if (checkBox多媒體.Checked) interest += checkBox多媒體.Text + "、";
            if (checkBox程式設計.Checked) interest += checkBox程式設計.Text + "、";
            if (checkBox網頁設計.Checked) interest += checkBox網頁設計.Text + "、";
            if (checkBox3D動畫.Checked) interest += checkBox3D動畫.Text + "、";
            if (checkBox影片製作.Checked) interest += checkBox影片製作.Text + "、";

            msg = textBoxName.Text + "\n" + textBoxPassword.Text + "\n" + gender + "\n" + interest;
            DialogResult dr = MessageBox.Show(msg, "會員資訊", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes) MessageBox.Show("您已填寫成功,謝謝您", "填寫成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
            ClassMainForm main = new ClassMainForm();
            this.Visible = false;
            main.Show();
        }
    }
}