namespace Guessing_game
{
    partial class EnterNumber
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EnterNumber));
            this.label2 = new System.Windows.Forms.Label();
            this.tbEnterNum = new System.Windows.Forms.TextBox();
            this.btnEnterNum = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe Print", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(229, 37);
            this.label2.TabIndex = 1;
            this.label2.Text = "Enter your number:";
            // 
            // tbEnterNum
            // 
            this.tbEnterNum.Font = new System.Drawing.Font("Segoe Print", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbEnterNum.Location = new System.Drawing.Point(73, 62);
            this.tbEnterNum.MaxLength = 3;
            this.tbEnterNum.Name = "tbEnterNum";
            this.tbEnterNum.Size = new System.Drawing.Size(100, 45);
            this.tbEnterNum.TabIndex = 2;
            this.tbEnterNum.Text = "100";
            this.tbEnterNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnEnterNum
            // 
            this.btnEnterNum.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(209)))), ((int)(((byte)(202)))));
            this.btnEnterNum.Font = new System.Drawing.Font("Gabriola", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnEnterNum.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(91)))), ((int)(((byte)(124)))));
            this.btnEnterNum.Location = new System.Drawing.Point(54, 127);
            this.btnEnterNum.Name = "btnEnterNum";
            this.btnEnterNum.Size = new System.Drawing.Size(142, 65);
            this.btnEnterNum.TabIndex = 8;
            this.btnEnterNum.Text = "Ok";
            this.btnEnterNum.UseVisualStyleBackColor = false;
            this.btnEnterNum.Click += new System.EventHandler(this.btnEnterNum_Click);
            // 
            // EnterNumber
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(238)))));
            this.ClientSize = new System.Drawing.Size(254, 218);
            this.Controls.Add(this.btnEnterNum);
            this.Controls.Add(this.tbEnterNum);
            this.Controls.Add(this.label2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EnterNumber";
            this.Text = "Enter Number";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbEnterNum;
        private System.Windows.Forms.Button btnEnterNum;
    }
}