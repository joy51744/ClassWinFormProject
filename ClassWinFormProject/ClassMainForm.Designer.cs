namespace ClassWinFormProject
{
    partial class ClassMainForm
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.buttonMoney = new System.Windows.Forms.Button();
            this.buttonCompounding = new System.Windows.Forms.Button();
            this.buttonFor = new System.Windows.Forms.Button();
            this.buttonWhile = new System.Windows.Forms.Button();
            this.buttonLogic = new System.Windows.Forms.Button();
            this.buttonIF = new System.Windows.Forms.Button();
            this.buttonTicket = new System.Windows.Forms.Button();
            this.buttonStatistic = new System.Windows.Forms.Button();
            this.buttonTimer = new System.Windows.Forms.Button();
            this.buttonMarquee = new System.Windows.Forms.Button();
            this.buttonMember = new System.Windows.Forms.Button();
            this.buttonTextCalculate = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.buttonString = new System.Windows.Forms.Button();
            this.buttonHello = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonLotto = new System.Windows.Forms.Button();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(31, 22);
            this.toolStripLabel2.Text = "離開";
            this.toolStripLabel2.Click += new System.EventHandler(this.toolStripLabel2_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(109, 22);
            this.toolStripMenuItem2.Text = "10202";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2});
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(44, 22);
            this.toolStripLabel1.Text = "專案";
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
            this.toolStrip1.TabIndex = 77;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // buttonMoney
            // 
            this.buttonMoney.Font = new System.Drawing.Font("標楷體", 14.25F, System.Drawing.FontStyle.Bold);
            this.buttonMoney.Location = new System.Drawing.Point(643, 383);
            this.buttonMoney.Name = "buttonMoney";
            this.buttonMoney.Size = new System.Drawing.Size(130, 45);
            this.buttonMoney.TabIndex = 75;
            this.buttonMoney.Text = "錢幣兌換";
            this.buttonMoney.UseVisualStyleBackColor = true;
            this.buttonMoney.Click += new System.EventHandler(this.buttonMoney_Click);
            // 
            // buttonCompounding
            // 
            this.buttonCompounding.Font = new System.Drawing.Font("標楷體", 14.25F, System.Drawing.FontStyle.Bold);
            this.buttonCompounding.Location = new System.Drawing.Point(643, 288);
            this.buttonCompounding.Name = "buttonCompounding";
            this.buttonCompounding.Size = new System.Drawing.Size(130, 45);
            this.buttonCompounding.TabIndex = 74;
            this.buttonCompounding.Text = "複利計算";
            this.buttonCompounding.UseVisualStyleBackColor = true;
            this.buttonCompounding.Click += new System.EventHandler(this.buttonCompounding_Click);
            // 
            // buttonFor
            // 
            this.buttonFor.Font = new System.Drawing.Font("標楷體", 14.25F, System.Drawing.FontStyle.Bold);
            this.buttonFor.Location = new System.Drawing.Point(643, 193);
            this.buttonFor.Name = "buttonFor";
            this.buttonFor.Size = new System.Drawing.Size(130, 45);
            this.buttonFor.TabIndex = 73;
            this.buttonFor.Text = "九九乘法表";
            this.buttonFor.UseVisualStyleBackColor = true;
            this.buttonFor.Click += new System.EventHandler(this.buttonFor_Click);
            // 
            // buttonWhile
            // 
            this.buttonWhile.Font = new System.Drawing.Font("標楷體", 14.25F, System.Drawing.FontStyle.Bold);
            this.buttonWhile.Location = new System.Drawing.Point(643, 98);
            this.buttonWhile.Name = "buttonWhile";
            this.buttonWhile.Size = new System.Drawing.Size(130, 45);
            this.buttonWhile.TabIndex = 72;
            this.buttonWhile.Text = "溫度轉換";
            this.buttonWhile.UseVisualStyleBackColor = true;
            this.buttonWhile.Click += new System.EventHandler(this.buttonWhile_Click);
            // 
            // buttonLogic
            // 
            this.buttonLogic.Font = new System.Drawing.Font("標楷體", 14.25F, System.Drawing.FontStyle.Bold);
            this.buttonLogic.Location = new System.Drawing.Point(437, 383);
            this.buttonLogic.Name = "buttonLogic";
            this.buttonLogic.Size = new System.Drawing.Size(130, 45);
            this.buttonLogic.TabIndex = 71;
            this.buttonLogic.Text = "邏輯判斷";
            this.buttonLogic.UseVisualStyleBackColor = true;
            this.buttonLogic.Click += new System.EventHandler(this.buttonLogic_Click);
            // 
            // buttonIF
            // 
            this.buttonIF.Font = new System.Drawing.Font("標楷體", 14.25F, System.Drawing.FontStyle.Bold);
            this.buttonIF.Location = new System.Drawing.Point(437, 288);
            this.buttonIF.Name = "buttonIF";
            this.buttonIF.Size = new System.Drawing.Size(130, 45);
            this.buttonIF.TabIndex = 70;
            this.buttonIF.Text = "偶數判斷";
            this.buttonIF.UseVisualStyleBackColor = true;
            this.buttonIF.Click += new System.EventHandler(this.buttonIF_Click);
            // 
            // buttonTicket
            // 
            this.buttonTicket.Font = new System.Drawing.Font("標楷體", 14.25F, System.Drawing.FontStyle.Bold);
            this.buttonTicket.Location = new System.Drawing.Point(437, 193);
            this.buttonTicket.Name = "buttonTicket";
            this.buttonTicket.Size = new System.Drawing.Size(130, 45);
            this.buttonTicket.TabIndex = 69;
            this.buttonTicket.Text = "高鐵購票";
            this.buttonTicket.UseVisualStyleBackColor = true;
            this.buttonTicket.Click += new System.EventHandler(this.buttonTicket_Click);
            // 
            // buttonStatistic
            // 
            this.buttonStatistic.Font = new System.Drawing.Font("標楷體", 14.25F, System.Drawing.FontStyle.Bold);
            this.buttonStatistic.Location = new System.Drawing.Point(437, 98);
            this.buttonStatistic.Name = "buttonStatistic";
            this.buttonStatistic.Size = new System.Drawing.Size(130, 45);
            this.buttonStatistic.TabIndex = 68;
            this.buttonStatistic.Text = "便當統計";
            this.buttonStatistic.UseVisualStyleBackColor = true;
            this.buttonStatistic.Click += new System.EventHandler(this.buttonStatistic_Click);
            // 
            // buttonTimer
            // 
            this.buttonTimer.Font = new System.Drawing.Font("標楷體", 14.25F, System.Drawing.FontStyle.Bold);
            this.buttonTimer.Location = new System.Drawing.Point(231, 383);
            this.buttonTimer.Name = "buttonTimer";
            this.buttonTimer.Size = new System.Drawing.Size(130, 45);
            this.buttonTimer.TabIndex = 67;
            this.buttonTimer.Text = "計時器";
            this.buttonTimer.UseVisualStyleBackColor = true;
            this.buttonTimer.Click += new System.EventHandler(this.buttonTimer_Click);
            // 
            // buttonMarquee
            // 
            this.buttonMarquee.Font = new System.Drawing.Font("標楷體", 14.25F, System.Drawing.FontStyle.Bold);
            this.buttonMarquee.Location = new System.Drawing.Point(231, 288);
            this.buttonMarquee.Name = "buttonMarquee";
            this.buttonMarquee.Size = new System.Drawing.Size(130, 45);
            this.buttonMarquee.TabIndex = 66;
            this.buttonMarquee.Text = "跑馬燈";
            this.buttonMarquee.UseVisualStyleBackColor = true;
            this.buttonMarquee.Click += new System.EventHandler(this.buttonMarquee_Click);
            // 
            // buttonMember
            // 
            this.buttonMember.Font = new System.Drawing.Font("標楷體", 14.25F, System.Drawing.FontStyle.Bold);
            this.buttonMember.Location = new System.Drawing.Point(231, 193);
            this.buttonMember.Name = "buttonMember";
            this.buttonMember.Size = new System.Drawing.Size(130, 45);
            this.buttonMember.TabIndex = 65;
            this.buttonMember.Text = "會員資訊";
            this.buttonMember.UseVisualStyleBackColor = true;
            this.buttonMember.Click += new System.EventHandler(this.buttonMember_Click);
            // 
            // buttonTextCalculate
            // 
            this.buttonTextCalculate.Font = new System.Drawing.Font("標楷體", 14.25F, System.Drawing.FontStyle.Bold);
            this.buttonTextCalculate.Location = new System.Drawing.Point(231, 98);
            this.buttonTextCalculate.Name = "buttonTextCalculate";
            this.buttonTextCalculate.Size = new System.Drawing.Size(130, 45);
            this.buttonTextCalculate.TabIndex = 64;
            this.buttonTextCalculate.Text = "基本運算";
            this.buttonTextCalculate.UseVisualStyleBackColor = true;
            this.buttonTextCalculate.Click += new System.EventHandler(this.ButtonTextCalculate_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("標楷體", 14.25F, System.Drawing.FontStyle.Bold);
            this.button3.Location = new System.Drawing.Point(25, 288);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(130, 45);
            this.button3.TabIndex = 63;
            this.button3.Text = "數字排序";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.ButtonSort_Click);
            // 
            // buttonString
            // 
            this.buttonString.Font = new System.Drawing.Font("標楷體", 14.25F, System.Drawing.FontStyle.Bold);
            this.buttonString.Location = new System.Drawing.Point(25, 193);
            this.buttonString.Name = "buttonString";
            this.buttonString.Size = new System.Drawing.Size(130, 45);
            this.buttonString.TabIndex = 62;
            this.buttonString.Text = "格式輸入";
            this.buttonString.UseVisualStyleBackColor = true;
            this.buttonString.Click += new System.EventHandler(this.ButtonString_Click);
            // 
            // buttonHello
            // 
            this.buttonHello.Font = new System.Drawing.Font("標楷體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.buttonHello.Location = new System.Drawing.Point(25, 98);
            this.buttonHello.Name = "buttonHello";
            this.buttonHello.Size = new System.Drawing.Size(130, 45);
            this.buttonHello.TabIndex = 61;
            this.buttonHello.Text = "打招呼";
            this.buttonHello.UseVisualStyleBackColor = true;
            this.buttonHello.Click += new System.EventHandler(this.buttonHello_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(283, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(233, 33);
            this.label1.TabIndex = 60;
            this.label1.Text = "C# Class Project";
            // 
            // buttonLotto
            // 
            this.buttonLotto.Font = new System.Drawing.Font("標楷體", 14.25F, System.Drawing.FontStyle.Bold);
            this.buttonLotto.Location = new System.Drawing.Point(25, 383);
            this.buttonLotto.Name = "buttonLotto";
            this.buttonLotto.Size = new System.Drawing.Size(130, 45);
            this.buttonLotto.TabIndex = 78;
            this.buttonLotto.Text = "樂透";
            this.buttonLotto.UseVisualStyleBackColor = true;
            this.buttonLotto.Click += new System.EventHandler(this.buttonLotto_Click);
            // 
            // ClassMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonLotto);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.buttonMoney);
            this.Controls.Add(this.buttonCompounding);
            this.Controls.Add(this.buttonFor);
            this.Controls.Add(this.buttonWhile);
            this.Controls.Add(this.buttonLogic);
            this.Controls.Add(this.buttonIF);
            this.Controls.Add(this.buttonTicket);
            this.Controls.Add(this.buttonStatistic);
            this.Controls.Add(this.buttonTimer);
            this.Controls.Add(this.buttonMarquee);
            this.Controls.Add(this.buttonMember);
            this.Controls.Add(this.buttonTextCalculate);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.buttonString);
            this.Controls.Add(this.buttonHello);
            this.Controls.Add(this.label1);
            this.Name = "ClassMainForm";
            this.Text = "馬顥心 | C#課程專案";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripDropDownButton toolStripLabel1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.Button buttonMoney;
        private System.Windows.Forms.Button buttonCompounding;
        private System.Windows.Forms.Button buttonFor;
        private System.Windows.Forms.Button buttonWhile;
        private System.Windows.Forms.Button buttonLogic;
        private System.Windows.Forms.Button buttonIF;
        private System.Windows.Forms.Button buttonTicket;
        private System.Windows.Forms.Button buttonStatistic;
        private System.Windows.Forms.Button buttonTimer;
        private System.Windows.Forms.Button buttonMarquee;
        private System.Windows.Forms.Button buttonMember;
        private System.Windows.Forms.Button buttonTextCalculate;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button buttonString;
        private System.Windows.Forms.Button buttonHello;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonLotto;
    }
}

