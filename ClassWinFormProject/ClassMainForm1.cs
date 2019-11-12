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
    public partial class ClassMainForm1 : Form
    {
        public ClassMainForm1()
        {
            InitializeComponent();
        }

        private void toolStripLabel2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("PortfolioMainForm.exe");
            this.Visible = false;
        }

        private void buttonLotto_Click(object sender, EventArgs e)
        {
            _10201_Lotto lotto = new _10201_Lotto();
            this.Visible = false;
            lotto.Show();
        }

        private void buttonName_Click(object sender, EventArgs e)
        {
            _10202_Name name = new _10202_Name();
            this.Visible = false;
            name.Show();
        }

        private void buttonString_Click(object sender, EventArgs e)
        {
            _10201_String @string = new _10201_String();
            this.Visible = false;
            @string.Show();
        }

        private void buttonString1_Click(object sender, EventArgs e)
        {
            _10201_String1 @string = new _10201_String1();
            this.Visible = false;
            @string.Show();
        }

        private void buttonDateTime_Click(object sender, EventArgs e)
        {
            _10202_DateTime dateTime = new _10202_DateTime();
            this.Visible = false;
            dateTime.Show();
        }

        private void buttonSort_Click(object sender, EventArgs e)
        {
            _10201_Sort sort = new _10201_Sort();
            this.Visible = false;
            sort.Show();
        }

        private void buttonSlideShow_Click(object sender, EventArgs e)
        {
            _10202_SlideShow slideShow = new _10202_SlideShow();
            this.Visible = false;
            slideShow.Show();
        }

        private void buttonImageView_Click(object sender, EventArgs e)
        {
            _10202_ImageView watermark = new _10202_ImageView();
            this.Visible = false;
            watermark.Show();
        }

        private void buttonFornColor_Click(object sender, EventArgs e)
        {
            _10202_FormColor formColor = new _10202_FormColor();
            this.Visible = false;
            formColor.Show();
        }

        private void buttonBrowser_Click(object sender, EventArgs e)
        {
            _10202_Browser browser = new _10202_Browser();
            this.Visible = false;
            browser.Show();
        }

        private void buttonOpen_Click(object sender, EventArgs e)
        {
            _10202_Open open = new _10202_Open();
            this.Visible = false;
            open.Show();
        }

        private void buttonRWD_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("RWD.exe");
        }

        private void buttonConverter_Click(object sender, EventArgs e)
        {
            _10202_Converter converter = new _10202_Converter();
            this.Visible = false;
            converter.Show();
        }

        private void buttonPOS_Click(object sender, EventArgs e)
        {
            _10202_POS pos = new _10202_POS();
            this.Visible = false;
            pos.Show();
        }

        private void buttonNotepad_Click(object sender, EventArgs e)
        {
            _10202_Notepad notepad = new _10202_Notepad();
            this.Visible = false;
            notepad.Show();
        }

        private void buttonDraw_Click(object sender, EventArgs e)
        {
            _10202_Draw draw = new _10202_Draw();
            this.Visible = false;
            draw.Show();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            ClassMainForm main = new ClassMainForm();
            this.Visible = false;
            main.Show();
        }
    }
}