using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassWinFormProject
{
    public partial class _10202_Notepad : Form
    {
        private String filePath = null;

        public _10202_Notepad()
        {
            InitializeComponent();
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
            ClassMainForm1 main = new ClassMainForm1();
            this.Visible = false;
            main.Show();
        }

        public static String fileToText(String filePath)
        {
            StreamReader file = new StreamReader(filePath);
            String text = file.ReadToEnd();
            file.Close();
            return text;
        }

        public static void textToFile(String filePath, String text)
        {
            StreamWriter file = new StreamWriter(filePath);
            file.Write(text);
            file.Close();
        }

        private void 開啟新檔ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
            filePath = null;
        }

        private void 開啟舊檔ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                String text = fileToText(openFileDialog1.FileName);
                richTextBox1.Text = text;
                filePath = openFileDialog1.FileName;
            }
        }

        private void 儲存檔案ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (filePath == null)
            {
                dialogSaveFile();
            }
            else
            {
                textToFile(filePath, richTextBox1.Text);
            }
        }

        private void 另存新檔ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dialogSaveFile();
        }

        private void dialogSaveFile()
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                textToFile(saveFileDialog1.FileName, richTextBox1.Text);
                filePath = saveFileDialog1.FileName;
            }
        }
    }
}