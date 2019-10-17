namespace ClassWinFormProject
{
    partial class _10201_Money
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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.txt50 = new System.Windows.Forms.TextBox();
            this.txt100 = new System.Windows.Forms.TextBox();
            this.chk10 = new System.Windows.Forms.CheckBox();
            this.chk50 = new System.Windows.Forms.CheckBox();
            this.chk100 = new System.Windows.Forms.CheckBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt1 = new System.Windows.Forms.TextBox();
            this.chk1 = new System.Windows.Forms.CheckBox();
            this.txt1000 = new System.Windows.Forms.TextBox();
            this.chk1000 = new System.Windows.Forms.CheckBox();
            this.txt500 = new System.Windows.Forms.TextBox();
            this.chk500 = new System.Windows.Forms.CheckBox();
            this.txt10 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.toolStripSeparator1,
            this.toolStripSeparator2});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(533, 25);
            this.toolStrip1.TabIndex = 70;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(31, 22);
            this.toolStripLabel1.Text = "離開";
            this.toolStripLabel1.Click += new System.EventHandler(this.toolStripLabel1_Click);
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(141, 61);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(90, 22);
            this.txtAmount.TabIndex = 66;
            this.txtAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txt50
            // 
            this.txt50.Location = new System.Drawing.Point(166, 45);
            this.txt50.Name = "txt50";
            this.txt50.Size = new System.Drawing.Size(43, 22);
            this.txt50.TabIndex = 7;
            this.txt50.Text = "0";
            this.txt50.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txt100
            // 
            this.txt100.Location = new System.Drawing.Point(115, 45);
            this.txt100.Name = "txt100";
            this.txt100.Size = new System.Drawing.Size(43, 22);
            this.txt100.TabIndex = 5;
            this.txt100.Text = "0";
            this.txt100.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // chk10
            // 
            this.chk10.AutoSize = true;
            this.chk10.Location = new System.Drawing.Point(213, 21);
            this.chk10.Name = "chk10";
            this.chk10.Size = new System.Drawing.Size(42, 16);
            this.chk10.TabIndex = 3;
            this.chk10.Text = "$10";
            this.chk10.UseVisualStyleBackColor = true;
            // 
            // chk50
            // 
            this.chk50.AutoSize = true;
            this.chk50.Location = new System.Drawing.Point(165, 21);
            this.chk50.Name = "chk50";
            this.chk50.Size = new System.Drawing.Size(42, 16);
            this.chk50.TabIndex = 2;
            this.chk50.Text = "$50";
            this.chk50.UseVisualStyleBackColor = true;
            // 
            // chk100
            // 
            this.chk100.AutoSize = true;
            this.chk100.Location = new System.Drawing.Point(117, 21);
            this.chk100.Name = "chk100";
            this.chk100.Size = new System.Drawing.Size(48, 16);
            this.chk100.TabIndex = 0;
            this.chk100.Text = "$100";
            this.chk100.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(363, 57);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(72, 27);
            this.button2.TabIndex = 68;
            this.button2.Text = "清除";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(274, 57);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(72, 27);
            this.button1.TabIndex = 67;
            this.button1.Text = "兌換";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt1);
            this.groupBox1.Controls.Add(this.chk1);
            this.groupBox1.Controls.Add(this.txt1000);
            this.groupBox1.Controls.Add(this.chk1000);
            this.groupBox1.Controls.Add(this.txt500);
            this.groupBox1.Controls.Add(this.chk500);
            this.groupBox1.Controls.Add(this.txt10);
            this.groupBox1.Controls.Add(this.txt50);
            this.groupBox1.Controls.Add(this.txt100);
            this.groupBox1.Controls.Add(this.chk10);
            this.groupBox1.Controls.Add(this.chk50);
            this.groupBox1.Controls.Add(this.chk100);
            this.groupBox1.Location = new System.Drawing.Point(102, 107);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(312, 78);
            this.groupBox1.TabIndex = 69;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "兌換種類";
            // 
            // txt1
            // 
            this.txt1.Location = new System.Drawing.Point(263, 46);
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(43, 22);
            this.txt1.TabIndex = 15;
            this.txt1.Text = "0";
            this.txt1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // chk1
            // 
            this.chk1.AutoSize = true;
            this.chk1.Location = new System.Drawing.Point(263, 22);
            this.chk1.Name = "chk1";
            this.chk1.Size = new System.Drawing.Size(36, 16);
            this.chk1.TabIndex = 14;
            this.chk1.Text = "$1";
            this.chk1.UseVisualStyleBackColor = true;
            // 
            // txt1000
            // 
            this.txt1000.Location = new System.Drawing.Point(13, 47);
            this.txt1000.Name = "txt1000";
            this.txt1000.Size = new System.Drawing.Size(43, 22);
            this.txt1000.TabIndex = 13;
            this.txt1000.Text = "0";
            this.txt1000.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // chk1000
            // 
            this.chk1000.AutoSize = true;
            this.chk1000.Location = new System.Drawing.Point(8, 22);
            this.chk1000.Name = "chk1000";
            this.chk1000.Size = new System.Drawing.Size(54, 16);
            this.chk1000.TabIndex = 12;
            this.chk1000.Text = "$1000";
            this.chk1000.UseVisualStyleBackColor = true;
            // 
            // txt500
            // 
            this.txt500.Location = new System.Drawing.Point(67, 46);
            this.txt500.Name = "txt500";
            this.txt500.Size = new System.Drawing.Size(43, 22);
            this.txt500.TabIndex = 11;
            this.txt500.Text = "0";
            this.txt500.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // chk500
            // 
            this.chk500.AutoSize = true;
            this.chk500.Location = new System.Drawing.Point(62, 21);
            this.chk500.Name = "chk500";
            this.chk500.Size = new System.Drawing.Size(48, 16);
            this.chk500.TabIndex = 10;
            this.chk500.Text = "$500";
            this.chk500.UseVisualStyleBackColor = true;
            // 
            // txt10
            // 
            this.txt10.Location = new System.Drawing.Point(213, 45);
            this.txt10.Name = "txt10";
            this.txt10.Size = new System.Drawing.Size(43, 22);
            this.txt10.TabIndex = 8;
            this.txt10.Text = "0";
            this.txt10.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(63, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 12);
            this.label3.TabIndex = 65;
            this.label3.Text = "兌換金額$：";
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
            // _10201_Money
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 223);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Name = "_10201_Money";
            this.Text = "C#課程專案 | 錢幣兌換";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.TextBox txt50;
        private System.Windows.Forms.TextBox txt100;
        private System.Windows.Forms.CheckBox chk10;
        private System.Windows.Forms.CheckBox chk50;
        private System.Windows.Forms.CheckBox chk100;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt1;
        private System.Windows.Forms.CheckBox chk1;
        private System.Windows.Forms.TextBox txt1000;
        private System.Windows.Forms.CheckBox chk1000;
        private System.Windows.Forms.TextBox txt500;
        private System.Windows.Forms.CheckBox chk500;
        private System.Windows.Forms.TextBox txt10;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
    }
}