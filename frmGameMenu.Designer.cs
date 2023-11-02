namespace AhmedAbdelsalamAssgt
{
    partial class frmGameMenu
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
            this.lblGameTitle = new System.Windows.Forms.Label();
            this.btnPlayMulti = new System.Windows.Forms.Button();
            this.btnPlayBot = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblGameTitle
            // 
            this.lblGameTitle.AutoSize = true;
            this.lblGameTitle.Font = new System.Drawing.Font("Microsoft Uighur", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGameTitle.Location = new System.Drawing.Point(99, 93);
            this.lblGameTitle.Name = "lblGameTitle";
            this.lblGameTitle.Size = new System.Drawing.Size(234, 83);
            this.lblGameTitle.TabIndex = 2;
            this.lblGameTitle.Text = "Six Of One";
            // 
            // btnPlayMulti
            // 
            this.btnPlayMulti.Location = new System.Drawing.Point(113, 179);
            this.btnPlayMulti.Name = "btnPlayMulti";
            this.btnPlayMulti.Size = new System.Drawing.Size(195, 23);
            this.btnPlayMulti.TabIndex = 3;
            this.btnPlayMulti.Text = "Play with human friend";
            this.btnPlayMulti.UseVisualStyleBackColor = true;
            this.btnPlayMulti.Click += new System.EventHandler(this.btnPlayMulti_Click);
            // 
            // btnPlayBot
            // 
            this.btnPlayBot.Location = new System.Drawing.Point(113, 208);
            this.btnPlayBot.Name = "btnPlayBot";
            this.btnPlayBot.Size = new System.Drawing.Size(195, 23);
            this.btnPlayBot.TabIndex = 4;
            this.btnPlayBot.Text = "Play with bot friend";
            this.btnPlayBot.UseVisualStyleBackColor = true;
            this.btnPlayBot.Click += new System.EventHandler(this.btnPlayBot_Click);
            // 
            // frmGameMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 361);
            this.Controls.Add(this.btnPlayBot);
            this.Controls.Add(this.btnPlayMulti);
            this.Controls.Add(this.lblGameTitle);
            this.Name = "frmGameMenu";
            this.Text = "Six Of One Dice Game Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblGameTitle;
        private System.Windows.Forms.Button btnPlayMulti;
        private System.Windows.Forms.Button btnPlayBot;
    }
}