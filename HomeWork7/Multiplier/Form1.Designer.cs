namespace Multiplier
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
            this.gameRulesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnMulti = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnSBack = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label0 = new System.Windows.Forms.Label();
            this.lbMessage = new System.Windows.Forms.Label();
            this.lbGSteps = new System.Windows.Forms.Label();
            this.lbYSteps = new System.Windows.Forms.Label();
            this.lbYNum = new System.Windows.Forms.Label();
            this.lbGNum = new System.Windows.Forms.Label();
            this.lbYour = new System.Windows.Forms.Label();
            this.lbSteps = new System.Windows.Forms.Label();
            this.lbNumber = new System.Windows.Forms.Label();
            this.lbGoal = new System.Windows.Forms.Label();
            this.btnPlus = new System.Windows.Forms.Button();
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
            this.gameRulesToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(584, 62);
            this.menuStrip1.TabIndex = 0;
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
            // gameRulesToolStripMenuItem
            // 
            this.gameRulesToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.gameRulesToolStripMenuItem.Font = new System.Drawing.Font("Gabriola", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gameRulesToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(142)))), ((int)(((byte)(171)))));
            this.gameRulesToolStripMenuItem.Name = "gameRulesToolStripMenuItem";
            this.gameRulesToolStripMenuItem.Size = new System.Drawing.Size(146, 58);
            this.gameRulesToolStripMenuItem.Text = "Game rules";
            this.gameRulesToolStripMenuItem.Click += new System.EventHandler(this.gameRulesToolStripMenuItem_Click);
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
            // btnMulti
            // 
            this.btnMulti.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(209)))), ((int)(((byte)(202)))));
            this.btnMulti.Font = new System.Drawing.Font("Gabriola", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnMulti.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(91)))), ((int)(((byte)(124)))));
            this.btnMulti.Location = new System.Drawing.Point(386, 241);
            this.btnMulti.Name = "btnMulti";
            this.btnMulti.Size = new System.Drawing.Size(154, 109);
            this.btnMulti.TabIndex = 2;
            this.btnMulti.Text = "x2";
            this.btnMulti.UseVisualStyleBackColor = false;
            this.btnMulti.Click += new System.EventHandler(this.btnMulti_Click);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(209)))), ((int)(((byte)(202)))));
            this.btnReset.Font = new System.Drawing.Font("Gabriola", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnReset.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(91)))), ((int)(((byte)(124)))));
            this.btnReset.Location = new System.Drawing.Point(386, 406);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(154, 109);
            this.btnReset.TabIndex = 3;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnSBack
            // 
            this.btnSBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(209)))), ((int)(((byte)(202)))));
            this.btnSBack.Font = new System.Drawing.Font("Gabriola", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSBack.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(91)))), ((int)(((byte)(124)))));
            this.btnSBack.Location = new System.Drawing.Point(36, 406);
            this.btnSBack.Name = "btnSBack";
            this.btnSBack.Size = new System.Drawing.Size(292, 109);
            this.btnSBack.TabIndex = 4;
            this.btnSBack.Text = "Step back";
            this.btnSBack.UseVisualStyleBackColor = false;
            this.btnSBack.Click += new System.EventHandler(this.btnSBack_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(238)))));
            this.groupBox1.Controls.Add(this.label0);
            this.groupBox1.Controls.Add(this.lbMessage);
            this.groupBox1.Controls.Add(this.lbGSteps);
            this.groupBox1.Controls.Add(this.lbYSteps);
            this.groupBox1.Controls.Add(this.lbYNum);
            this.groupBox1.Controls.Add(this.lbGNum);
            this.groupBox1.Controls.Add(this.lbYour);
            this.groupBox1.Controls.Add(this.lbSteps);
            this.groupBox1.Controls.Add(this.lbNumber);
            this.groupBox1.Controls.Add(this.lbGoal);
            this.groupBox1.Location = new System.Drawing.Point(36, 76);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(292, 274);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            // 
            // label0
            // 
            this.label0.AutoSize = true;
            this.label0.BackColor = System.Drawing.Color.Transparent;
            this.label0.Font = new System.Drawing.Font("Segoe Print", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label0.Location = new System.Drawing.Point(41, 16);
            this.label0.Name = "label0";
            this.label0.Size = new System.Drawing.Size(33, 37);
            this.label0.TabIndex = 10;
            this.label0.Text = "~";
            this.label0.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbMessage
            // 
            this.lbMessage.AutoSize = true;
            this.lbMessage.BackColor = System.Drawing.Color.Transparent;
            this.lbMessage.Font = new System.Drawing.Font("Segoe Print", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbMessage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(188)))), ((int)(((byte)(198)))));
            this.lbMessage.Location = new System.Drawing.Point(41, 142);
            this.lbMessage.MaximumSize = new System.Drawing.Size(260, 115);
            this.lbMessage.Name = "lbMessage";
            this.lbMessage.Size = new System.Drawing.Size(213, 37);
            this.lbMessage.TabIndex = 9;
            this.lbMessage.Text = "Start a new game.";
            this.lbMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbGSteps
            // 
            this.lbGSteps.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbGSteps.AutoSize = true;
            this.lbGSteps.BackColor = System.Drawing.Color.Transparent;
            this.lbGSteps.Font = new System.Drawing.Font("Segoe Print", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbGSteps.Location = new System.Drawing.Point(208, 60);
            this.lbGSteps.Name = "lbGSteps";
            this.lbGSteps.Size = new System.Drawing.Size(32, 37);
            this.lbGSteps.TabIndex = 8;
            this.lbGSteps.Text = "0";
            this.lbGSteps.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbYSteps
            // 
            this.lbYSteps.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbYSteps.AutoSize = true;
            this.lbYSteps.BackColor = System.Drawing.Color.Transparent;
            this.lbYSteps.Font = new System.Drawing.Font("Segoe Print", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbYSteps.Location = new System.Drawing.Point(208, 105);
            this.lbYSteps.Name = "lbYSteps";
            this.lbYSteps.Size = new System.Drawing.Size(32, 37);
            this.lbYSteps.TabIndex = 7;
            this.lbYSteps.Text = "0";
            this.lbYSteps.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbYNum
            // 
            this.lbYNum.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbYNum.AutoSize = true;
            this.lbYNum.BackColor = System.Drawing.Color.Transparent;
            this.lbYNum.Font = new System.Drawing.Font("Segoe Print", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbYNum.Location = new System.Drawing.Point(111, 105);
            this.lbYNum.Name = "lbYNum";
            this.lbYNum.Size = new System.Drawing.Size(32, 37);
            this.lbYNum.TabIndex = 6;
            this.lbYNum.Text = "0";
            this.lbYNum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbGNum
            // 
            this.lbGNum.AutoSize = true;
            this.lbGNum.BackColor = System.Drawing.Color.Transparent;
            this.lbGNum.Font = new System.Drawing.Font("Segoe Print", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbGNum.Location = new System.Drawing.Point(111, 60);
            this.lbGNum.Name = "lbGNum";
            this.lbGNum.Size = new System.Drawing.Size(32, 37);
            this.lbGNum.TabIndex = 5;
            this.lbGNum.Text = "0";
            this.lbGNum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbYour
            // 
            this.lbYour.AutoSize = true;
            this.lbYour.BackColor = System.Drawing.Color.Transparent;
            this.lbYour.Font = new System.Drawing.Font("Segoe Print", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbYour.Location = new System.Drawing.Point(13, 105);
            this.lbYour.Name = "lbYour";
            this.lbYour.Size = new System.Drawing.Size(67, 37);
            this.lbYour.TabIndex = 4;
            this.lbYour.Text = "Your";
            this.lbYour.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbSteps
            // 
            this.lbSteps.AutoSize = true;
            this.lbSteps.BackColor = System.Drawing.Color.Transparent;
            this.lbSteps.Font = new System.Drawing.Font("Segoe Print", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbSteps.Location = new System.Drawing.Point(203, 16);
            this.lbSteps.Name = "lbSteps";
            this.lbSteps.Size = new System.Drawing.Size(74, 37);
            this.lbSteps.TabIndex = 3;
            this.lbSteps.Text = "Steps";
            this.lbSteps.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbNumber
            // 
            this.lbNumber.AutoSize = true;
            this.lbNumber.BackColor = System.Drawing.Color.Transparent;
            this.lbNumber.Font = new System.Drawing.Font("Segoe Print", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbNumber.Location = new System.Drawing.Point(95, 16);
            this.lbNumber.Name = "lbNumber";
            this.lbNumber.Size = new System.Drawing.Size(102, 37);
            this.lbNumber.TabIndex = 2;
            this.lbNumber.Text = "Number";
            this.lbNumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbGoal
            // 
            this.lbGoal.AutoSize = true;
            this.lbGoal.BackColor = System.Drawing.Color.Transparent;
            this.lbGoal.Font = new System.Drawing.Font("Segoe Print", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbGoal.Location = new System.Drawing.Point(16, 60);
            this.lbGoal.Name = "lbGoal";
            this.lbGoal.Size = new System.Drawing.Size(63, 37);
            this.lbGoal.TabIndex = 0;
            this.lbGoal.Text = "Goal";
            this.lbGoal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnPlus
            // 
            this.btnPlus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(209)))), ((int)(((byte)(202)))));
            this.btnPlus.Font = new System.Drawing.Font("Gabriola", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnPlus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(91)))), ((int)(((byte)(124)))));
            this.btnPlus.Location = new System.Drawing.Point(386, 76);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(154, 109);
            this.btnPlus.TabIndex = 1;
            this.btnPlus.Text = "+1";
            this.btnPlus.UseVisualStyleBackColor = false;
            this.btnPlus.Click += new System.EventHandler(this.btnPlus_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(238)))));
            this.ClientSize = new System.Drawing.Size(584, 562);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnSBack);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnMulti);
            this.Controls.Add(this.btnPlus);
            this.Controls.Add(this.menuStrip1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Multiplier";
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
        private System.Windows.Forms.ToolStripMenuItem gameRulesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Button btnMulti;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnSBack;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbGoal;
        private System.Windows.Forms.Button btnPlus;
        private System.Windows.Forms.Label lbSteps;
        private System.Windows.Forms.Label lbNumber;
        private System.Windows.Forms.Label label0;
        private System.Windows.Forms.Label lbMessage;
        private System.Windows.Forms.Label lbGSteps;
        private System.Windows.Forms.Label lbYSteps;
        private System.Windows.Forms.Label lbYNum;
        private System.Windows.Forms.Label lbGNum;
        private System.Windows.Forms.Label lbYour;
    }
}

