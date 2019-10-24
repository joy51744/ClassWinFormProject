using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Text;

namespace ClassWinFormProject
{
    public partial class _10202_Progress : Form
    {
        public _10202_Progress()
        {
            InitializeComponent();
        }

        private int ProgressMinimum = 0;
        private int ProgressMaximum = 100;
        private int ProgressValue = 0;


        private void BtnGo_Click(object sender, EventArgs e)
        {
            ProgressValue = 0;
            picProgress.Refresh();
            tmrWork.Enabled = true;
        }

        private void TmrWork_Tick(object sender, EventArgs e)
        {
            ProgressValue += 4;
            if (ProgressValue > ProgressMaximum)
            {
                ProgressValue = 0;
                tmrWork.Enabled = false;
            }
            picProgress.Refresh();
        }

        private void PicProgress_Paint(object sender, PaintEventArgs e)
        {
            // Clear the background.
            e.Graphics.Clear(picProgress.BackColor);

            // Draw the progress bar.
            float fraction =
                (float)(ProgressValue - ProgressMinimum) /
                (ProgressMaximum - ProgressMinimum);
            int wid = (int)(fraction * picProgress.ClientSize.Width);
            e.Graphics.FillRectangle(
                Brushes.LightGreen, 0, 0, wid,
                picProgress.ClientSize.Height);

            // Draw the text.
            e.Graphics.TextRenderingHint =
                TextRenderingHint.AntiAliasGridFit;
            using (StringFormat sf = new StringFormat())
            {
                sf.Alignment = StringAlignment.Center;
                sf.LineAlignment = StringAlignment.Center;
                int percent = (int)(fraction * 100);
                e.Graphics.DrawString(
                    percent.ToString() + "%",
                    this.Font, Brushes.Black,
                    picProgress.ClientRectangle, sf);
            }
        }
    }
}
