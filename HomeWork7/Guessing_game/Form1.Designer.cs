namespace Guessing_game
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.newGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnEnterNum = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label0 = new System.Windows.Forms.Label();
            this.lbMessage = new System.Windows.Forms.Label();
            this.lbYNum = new System.Windows.Forms.Label();
            this.lbGNum = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCheck = new System.Windows.Forms.Button();
            this.lbTryCount = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newGameToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(480, 62);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // newGameToolStripMenuItem
            // 
            this.newGameToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.newGameToolStripMenuItem.Font = new System.Drawing.Font("Gabriola", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.newGameToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(142)))), ((int)(((byte)(171)))));
            this.newGameToolStripMenuItem.Name = "newGameToolStripMenuItem";
            this.newGameToolStripMenuItem.Size = new System.Drawing.Size(134, 58);
            this.newGameToolStripMenuItem.Text = "New game";
            this.newGameToolStripMenuItem.Click += new System.EventHandler(this.newGameToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.exitToolStripMenuItem.Font = new System.Drawing.Font("Gabriola", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.exitToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(142)))), ((int)(((byte)(171)))));
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(75, 58);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // btnEnterNum
            // 
            this.btnEnterNum.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(209)))), ((int)(((byte)(202)))));
            this.btnEnterNum.Font = new System.Drawing.Font("Gabriola", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnEnterNum.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(91)))), ((int)(((byte)(124)))));
            this.btnEnterNum.Location = new System.Drawing.Point(26, 367);
            this.btnEnterNum.Name = "btnEnterNum";
            this.btnEnterNum.Size = new System.Drawing.Size(233, 109);
            this.btnEnterNum.TabIndex = 7;
            this.btnEnterNum.Text = "Enter number";
            this.btnEnterNum.UseVisualStyleBackColor = false;
            this.btnEnterNum.Click += new System.EventHandler(this.btnEnterNum_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(238)))));
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lbTryCount);
            this.groupBox1.Controls.Add(this.label0);
            this.groupBox1.Controls.Add(this.lbMessage);
            this.groupBox1.Controls.Add(this.lbYNum);
            this.groupBox1.Controls.Add(this.lbGNum);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(26, 65);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(425, 284);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            // 
            // label0
            // 
            this.label0.AutoSize = true;
            this.label0.BackColor = System.Drawing.Color.Transparent;
            this.label0.Font = new System.Drawing.Font("Segoe Print", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label0.Location = new System.Drawing.Point(12, 131);
            this.label0.Name = "label0";
            this.label0.Size = new System.Drawing.Size(379, 37);
            this.label0.TabIndex = 10;
            this.label0.Text = "Guess the number from 1 to 100:";
            // 
            // lbMessage
            // 
            this.lbMessage.AutoSize = true;
            this.lbMessage.BackColor = System.Drawing.Color.Transparent;
            this.lbMessage.Font = new System.Drawing.Font("Segoe Print", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbMessage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(188)))), ((int)(((byte)(198)))));
            this.lbMessage.Location = new System.Drawing.Point(12, 16);
            this.lbMessage.MaximumSize = new System.Drawing.Size(400, 75);
            this.lbMessage.Name = "lbMessage";
            this.lbMessage.Size = new System.Drawing.Size(213, 37);
            this.lbMessage.TabIndex = 9;
            this.lbMessage.Text = "Start a new game.";
            // 
            // lbYNum
            // 
            this.lbYNum.AutoSize = true;
            this.lbYNum.BackColor = System.Drawing.Color.Transparent;
            this.lbYNum.Font = new System.Drawing.Font("Segoe Print", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbYNum.Location = new System.Drawing.Point(12, 242);
            this.lbYNum.Name = "lbYNum";
            this.lbYNum.Size = new System.Drawing.Size(50, 37);
            this.lbYNum.TabIndex = 4;
            this.lbYNum.Text = "***";
            // 
            // lbGNum
            // 
            this.lbGNum.AutoSize = true;
            this.lbGNum.BackColor = System.Drawing.Color.Transparent;
            this.lbGNum.Font = new System.Drawing.Font("Segoe Print", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbGNum.Location = new System.Drawing.Point(12, 168);
            this.lbGNum.Name = "lbGNum";
            this.lbGNum.Size = new System.Drawing.Size(50, 37);
            this.lbGNum.TabIndex = 2;
            this.lbGNum.Text = "***";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 205);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(280, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "You think the number is:";
            // 
            // btnCheck
            // 
            this.btnCheck.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(209)))), ((int)(((byte)(202)))));
            this.btnCheck.Font = new System.Drawing.Font("Gabriola", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCheck.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(91)))), ((int)(((byte)(124)))));
            this.btnCheck.Location = new System.Drawing.Point(297, 367);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(154, 109);
            this.btnCheck.TabIndex = 10;
            this.btnCheck.Text = "Check";
            this.btnCheck.UseVisualStyleBackColor = false;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // lbTryCount
            // 
            this.lbTryCount.AutoSize = true;
            this.lbTryCount.BackColor = System.Drawing.Color.Transparent;
            this.lbTryCount.Font = new System.Drawing.Font("Segoe Print", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbTryCount.Location = new System.Drawing.Point(185, 94);
            this.lbTryCount.Name = "lbTryCount";
            this.lbTryCount.Size = new System.Drawing.Size(32, 37);
            this.lbTryCount.TabIndex = 11;
            this.lbTryCount.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe Print", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(12, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(167, 37);
            this.label3.TabIndex = 12;
            this.label3.Text = "Attempts left:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(238)))));
            this.ClientSize = new System.Drawing.Size(480, 504);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnEnterNum);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Guessing Game";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem newGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Button btnEnterNum;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label0;
        private System.Windows.Forms.Label lbMessage;
        private System.Windows.Forms.Label lbGNum;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label lbYNum;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.Label lbTryCount;
        private System.Windows.Forms.Label label3;
    }
}

