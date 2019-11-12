using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ClassWinFormProject
{
    public partial class _10202_ImageView : Form
    {
        public _10202_ImageView()
        {
            InitializeComponent();
        }

        private string folderDirPath;
        private string picDirPath = null;
        private List<string> imagesList;

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
            ClassMainForm1 main = new ClassMainForm1();
            this.Visible = false;
            main.Show();
        }

        private void buttonOpen_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1 = new FolderBrowserDialog();
            folderBrowserDialog1.ShowDialog();
            this.folderDirPath = this.folderBrowserDialog1.SelectedPath;
            this.ShowList();
        }

        private void ShowList()
        {
            string[] fileList = Directory.GetFiles(this.folderDirPath);
            this.imagesList = new List<string>();
            for (int i = 0; i < fileList.Length; i++)
            {
                if (fileList[i].EndsWith(".jpg") || fileList[i].EndsWith(".png") || fileList[i].EndsWith(".JPG") || fileList[i].EndsWith(".PNG"))
                {
                    this.imagesList.Add(fileList[i]);
                }
            }
            this.treeView1.Nodes.Clear();
            foreach (string fileName in this.imagesList)
            {
                TreeNode node = new TreeNode(fileName);
                this.treeView1.Nodes.Add(node);
            }
        }

        private void treeView1_DoubleClick(object sender, EventArgs e)
        {
            picDirPath = this.treeView1.SelectedNode.Text;
            pictureBox1.Image = Image.FromFile(picDirPath);
        }

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            ClassMainForm1 main = new ClassMainForm1();
            this.Visible = false;
            main.Show();
        }
    }
}