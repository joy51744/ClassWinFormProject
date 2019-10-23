namespace ClassWinFormProject
{
    partial class ClassMainForm1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClassMainForm1));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.buttonFornColor = new System.Windows.Forms.Button();
            this.buttonSlideShow = new System.Windows.Forms.Button();
            this.buttonSort = new System.Windows.Forms.Button();
            this.buttonString1 = new System.Windows.Forms.Button();
            this.buttonDateTime = new System.Windows.Forms.Button();
            this.buttonString = new System.Windows.Forms.Button();
            this.buttonLotto = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonPOS = new System.Windows.Forms.Button();
            this.buttonConverter = new System.Windows.Forms.Button();
            this.buttonProgress = new System.Windows.Forms.Button();
            this.buttonOpen = new System.Windows.Forms.Button();
            this.buttonBrowser = new System.Windows.Forms.Button();
            this.buttonWatermark = new System.Windows.Forms.Button();
            this.buttonName = new System.Windows.Forms.Button();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.toolStripSeparator1,
            this.toolStripSeparator2,
            this.toolStripLabel2});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 95;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2});
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(44, 22);
            this.toolStripLabel1.Text = "專案";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(109, 22);
            this.toolStripMenuItem2.Text = "10201";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(31, 22);
            this.toolStripLabel2.Text = "離開";
            this.toolStripLabel2.Click += new System.EventHandler(this.toolStripLabel2_Click);
            // 
            // buttonFornColor
            // 
            this.buttonFornColor.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.buttonFornColor.Location = new System.Drawing.Point(437, 97);
            this.buttonFornColor.Name = "buttonFornColor";
            this.buttonFornColor.Size = new System.Drawing.Size(130, 45);
            this.buttonFornColor.TabIndex = 105;
            this.buttonFornColor.Text = "視窗顏色變換";
            this.buttonFornColor.UseVisualStyleBackColor = true;
            this.buttonFornColor.Click += new System.EventHandler(this.buttonFornColor_Click);
            // 
            // buttonSlideShow
            // 
            this.buttonSlideShow.Font = new System.Drawing.Font("標楷體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.buttonSlideShow.Location = new System.Drawing.Point(231, 288);
            this.buttonSlideShow.Name = "buttonSlideShow";
            this.buttonSlideShow.Size = new System.Drawing.Size(130, 45);
            this.buttonSlideShow.TabIndex = 103;
            this.buttonSlideShow.Text = "圖片輪播";
            this.buttonSlideShow.UseVisualStyleBackColor = true;
            this.buttonSlideShow.Click += new System.EventHandler(this.buttonSlideShow_Click);
            // 
            // buttonSort
            // 
            this.buttonSort.Font = new System.Drawing.Font("標楷體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.buttonSort.Location = new System.Drawing.Point(231, 193);
            this.buttonSort.Name = "buttonSort";
            this.buttonSort.Size = new System.Drawing.Size(130, 45);
            this.buttonSort.TabIndex = 102;
            this.buttonSort.Text = "陣列排序";
            this.buttonSort.UseVisualStyleBackColor = true;
            this.buttonSort.Click += new System.EventHandler(this.buttonSort_Click);
            // 
            // buttonString1
            // 
            this.buttonString1.Font = new System.Drawing.Font("標楷體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.buttonString1.Location = new System.Drawing.Point(25, 383);
            this.buttonString1.Name = "buttonString1";
            this.buttonString1.Size = new System.Drawing.Size(130, 45);
            this.buttonString1.TabIndex = 100;
            this.buttonString1.Text = "字串";
            this.buttonString1.UseVisualStyleBackColor = true;
            this.buttonString1.Click += new System.EventHandler(this.buttonString1_Click);
            // 
            // buttonDateTime
            // 
            this.buttonDateTime.Font = new System.Drawing.Font("標楷體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.buttonDateTime.Location = new System.Drawing.Point(231, 97);
            this.buttonDateTime.Name = "buttonDateTime";
            this.buttonDateTime.Size = new System.Drawing.Size(130, 45);
            this.buttonDateTime.TabIndex = 101;
            this.buttonDateTime.Text = "日期時間";
            this.buttonDateTime.UseVisualStyleBackColor = true;
            this.buttonDateTime.Click += new System.EventHandler(this.buttonDateTime_Click);
            // 
            // buttonString
            // 
            this.buttonString.Font = new System.Drawing.Font("標楷體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.buttonString.Location = new System.Drawing.Point(25, 288);
            this.buttonString.Name = "buttonString";
            this.buttonString.Size = new System.Drawing.Size(130, 45);
            this.buttonString.TabIndex = 99;
            this.buttonString.Text = "格式輸入";
            this.buttonString.UseVisualStyleBackColor = true;
            this.buttonString.Click += new System.EventHandler(this.buttonString_Click);
            // 
            // buttonLotto
            // 
            this.buttonLotto.Font = new System.Drawing.Font("標楷體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.buttonLotto.Location = new System.Drawing.Point(25, 98);
            this.buttonLotto.Name = "buttonLotto";
            this.buttonLotto.Size = new System.Drawing.Size(130, 45);
            this.buttonLotto.TabIndex = 97;
            this.buttonLotto.Text = "樂透";
            this.buttonLotto.UseVisualStyleBackColor = true;
            this.buttonLotto.Click += new System.EventHandler(this.buttonLotto_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("王漢宗顏楷體繁", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(300, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(240, 29);
            this.label1.TabIndex = 96;
            this.label1.Text = "C# Class Project";
            // 
            // buttonPOS
            // 
            this.buttonPOS.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonPOS.BackgroundImage")));
            this.buttonPOS.Font = new System.Drawing.Font("標楷體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.buttonPOS.Location = new System.Drawing.Point(645, 193);
            this.buttonPOS.Name = "buttonPOS";
            this.buttonPOS.Size = new System.Drawing.Size(130, 45);
            this.buttonPOS.TabIndex = 110;
            this.buttonPOS.Text = "POS系統";
            this.buttonPOS.UseVisualStyleBackColor = true;
            // 
            // buttonConverter
            // 
            this.buttonConverter.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonConverter.BackgroundImage")));
            this.buttonConverter.Font = new System.Drawing.Font("標楷體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.buttonConverter.Location = new System.Drawing.Point(643, 97);
            this.buttonConverter.Name = "buttonConverter";
            this.buttonConverter.Size = new System.Drawing.Size(130, 45);
            this.buttonConverter.TabIndex = 109;
            this.buttonConverter.Text = "轉換器";
            this.buttonConverter.UseVisualStyleBackColor = true;
            this.buttonConverter.Click += new System.EventHandler(this.buttonConverter_Click);
            // 
            // buttonProgress
            // 
            this.buttonProgress.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonProgress.BackgroundImage")));
            this.buttonProgress.Font = new System.Drawing.Font("標楷體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.buttonProgress.Location = new System.Drawing.Point(437, 383);
            this.buttonProgress.Name = "buttonProgress";
            this.buttonProgress.Size = new System.Drawing.Size(130, 45);
            this.buttonProgress.TabIndex = 108;
            this.buttonProgress.Text = "進度條";
            this.buttonProgress.UseVisualStyleBackColor = true;
            this.buttonProgress.Click += new System.EventHandler(this.buttonProgress_Click);
            // 
            // buttonOpen
            // 
            this.buttonOpen.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonOpen.BackgroundImage")));
            this.buttonOpen.Font = new System.Drawing.Font("標楷體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.buttonOpen.Location = new System.Drawing.Point(437, 288);
            this.buttonOpen.Name = "buttonOpen";
            this.buttonOpen.Size = new System.Drawing.Size(130, 45);
            this.buttonOpen.TabIndex = 107;
            this.buttonOpen.Text = "開啟文件";
            this.buttonOpen.UseVisualStyleBackColor = true;
            this.buttonOpen.Click += new System.EventHandler(this.buttonOpen_Click);
            // 
            // buttonBrowser
            // 
            this.buttonBrowser.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonBrowser.BackgroundImage")));
            this.buttonBrowser.Font = new System.Drawing.Font("標楷體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.buttonBrowser.Location = new System.Drawing.Point(437, 193);
            this.buttonBrowser.Name = "buttonBrowser";
            this.buttonBrowser.Size = new System.Drawing.Size(130, 45);
            this.buttonBrowser.TabIndex = 106;
            this.buttonBrowser.Text = "簡易瀏覽器";
            this.buttonBrowser.UseVisualStyleBackColor = true;
            this.buttonBrowser.Click += new System.EventHandler(this.buttonBrowser_Click);
            // 
            // buttonWatermark
            // 
            this.buttonWatermark.BackgroundImage = global::ClassWinFormProject.Properties.Resources._01;
            this.buttonWatermark.Font = new System.Drawing.Font("標楷體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.buttonWatermark.Location = new System.Drawing.Point(231, 383);
            this.buttonWatermark.Name = "buttonWatermark";
            this.buttonWatermark.Size = new System.Drawing.Size(130, 45);
            this.buttonWatermark.TabIndex = 104;
            this.buttonWatermark.Text = "圖片浮水印";
            this.buttonWatermark.UseVisualStyleBackColor = true;
            this.buttonWatermark.Click += new System.EventHandler(this.buttonWatermark_Click);
            // 
            // buttonName
            // 
            this.buttonName.Font = new System.Drawing.Font("標楷體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.buttonName.Location = new System.Drawing.Point(25, 193);
            this.buttonName.Name = "buttonName";
            this.buttonName.Size = new System.Drawing.Size(130, 45);
            this.buttonName.TabIndex = 98;
            this.buttonName.Text = "點名系統";
            this.buttonName.UseVisualStyleBackColor = true;
            this.buttonName.Click += new System.EventHandler(this.buttonName_Click);
            // 
            // ClassMainForm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonPOS);
            this.Controls.Add(this.buttonConverter);
            this.Controls.Add(this.buttonProgress);
            this.Controls.Add(this.buttonOpen);
            this.Controls.Add(this.buttonBrowser);
            this.Controls.Add(this.buttonFornColor);
            this.Controls.Add(this.buttonWatermark);
            this.Controls.Add(this.buttonSlideShow);
            this.Controls.Add(this.buttonSort);
            this.Controls.Add(this.buttonString1);
            this.Controls.Add(this.buttonDateTime);
            this.Controls.Add(this.buttonString);
            this.Controls.Add(this.buttonName);
            this.Controls.Add(this.buttonLotto);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "ClassMainForm1";
            this.Text = "馬顥心 | C#課程專案";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripLabel1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.Button buttonPOS;
        private System.Windows.Forms.Button buttonConverter;
        private System.Windows.Forms.Button buttonProgress;
        private System.Windows.Forms.Button buttonOpen;
        private System.Windows.Forms.Button buttonBrowser;
        private System.Windows.Forms.Button buttonFornColor;
        private System.Windows.Forms.Button buttonWatermark;
        private System.Windows.Forms.Button buttonSlideShow;
        private System.Windows.Forms.Button buttonSort;
        private System.Windows.Forms.Button buttonString1;
        private System.Windows.Forms.Button buttonDateTime;
        private System.Windows.Forms.Button buttonString;
        private System.Windows.Forms.Button buttonName;
        private System.Windows.Forms.Button buttonLotto;
        private System.Windows.Forms.Label label1;
    }
}