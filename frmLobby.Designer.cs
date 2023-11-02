namespace AhmedAbdelsalamAssgt
{
    partial class frmLobby
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblWins = new System.Windows.Forms.Label();
            this.lblLobby = new System.Windows.Forms.Label();
            this.lblP1Wins = new System.Windows.Forms.Label();
            this.lblP2Wins = new System.Windows.Forms.Label();
            this.txbxPlayer2 = new System.Windows.Forms.TextBox();
            this.txbxPlayer1 = new System.Windows.Forms.TextBox();
            this.btnCreateGame = new System.Windows.Forms.Button();
            this.btnExitLobby = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(117, 137);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(44, 13);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Players:";
            // 
            // lblWins
            // 
            this.lblWins.AutoSize = true;
            this.lblWins.Location = new System.Drawing.Point(270, 137);
            this.lblWins.Name = "lblWins";
            this.lblWins.Size = new System.Drawing.Size(34, 13);
            this.lblWins.TabIndex = 1;
            this.lblWins.Text = "Wins:";
            // 
            // lblLobby
            // 
            this.lblLobby.AutoSize = true;
            this.lblLobby.Font = new System.Drawing.Font("Microsoft Uighur", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLobby.Location = new System.Drawing.Point(106, 54);
            this.lblLobby.Name = "lblLobby";
            this.lblLobby.Size = new System.Drawing.Size(148, 83);
            this.lblLobby.TabIndex = 4;
            this.lblLobby.Text = "Lobby";
            // 
            // lblP1Wins
            // 
            this.lblP1Wins.AutoSize = true;
            this.lblP1Wins.ForeColor = System.Drawing.Color.Red;
            this.lblP1Wins.Location = new System.Drawing.Point(269, 166);
            this.lblP1Wins.Name = "lblP1Wins";
            this.lblP1Wins.Size = new System.Drawing.Size(35, 13);
            this.lblP1Wins.TabIndex = 5;
            this.lblP1Wins.Text = "label1";
            // 
            // lblP2Wins
            // 
            this.lblP2Wins.AutoSize = true;
            this.lblP2Wins.ForeColor = System.Drawing.Color.Blue;
            this.lblP2Wins.Location = new System.Drawing.Point(269, 196);
            this.lblP2Wins.Name = "lblP2Wins";
            this.lblP2Wins.Size = new System.Drawing.Size(35, 13);
            this.lblP2Wins.TabIndex = 6;
            this.lblP2Wins.Text = "label1";
            // 
            // txbxPlayer2
            // 
            this.txbxPlayer2.ForeColor = System.Drawing.Color.Blue;
            this.txbxPlayer2.Location = new System.Drawing.Point(120, 189);
            this.txbxPlayer2.Name = "txbxPlayer2";
            this.txbxPlayer2.ReadOnly = true;
            this.txbxPlayer2.Size = new System.Drawing.Size(100, 20);
            this.txbxPlayer2.TabIndex = 3;
            // 
            // txbxPlayer1
            // 
            this.txbxPlayer1.ForeColor = System.Drawing.Color.Red;
            this.txbxPlayer1.Location = new System.Drawing.Point(120, 163);
            this.txbxPlayer1.Name = "txbxPlayer1";
            this.txbxPlayer1.ReadOnly = true;
            this.txbxPlayer1.Size = new System.Drawing.Size(100, 20);
            this.txbxPlayer1.TabIndex = 2;
            // 
            // btnCreateGame
            // 
            this.btnCreateGame.Location = new System.Drawing.Point(120, 229);
            this.btnCreateGame.Name = "btnCreateGame";
            this.btnCreateGame.Size = new System.Drawing.Size(184, 23);
            this.btnCreateGame.TabIndex = 7;
            this.btnCreateGame.Text = "Create Game";
            this.btnCreateGame.UseVisualStyleBackColor = true;
            this.btnCreateGame.Click += new System.EventHandler(this.btnCreateGame_Click);
            // 
            // btnExitLobby
            // 
            this.btnExitLobby.Location = new System.Drawing.Point(120, 275);
            this.btnExitLobby.Name = "btnExitLobby";
            this.btnExitLobby.Size = new System.Drawing.Size(184, 23);
            this.btnExitLobby.TabIndex = 8;
            this.btnExitLobby.Text = "End";
            this.btnExitLobby.UseVisualStyleBackColor = true;
            this.btnExitLobby.Click += new System.EventHandler(this.btnExitLobby_Click);
            // 
            // frmLobby
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 361);
            this.Controls.Add(this.btnExitLobby);
            this.Controls.Add(this.btnCreateGame);
            this.Controls.Add(this.lblP2Wins);
            this.Controls.Add(this.lblP1Wins);
            this.Controls.Add(this.lblLobby);
            this.Controls.Add(this.txbxPlayer2);
            this.Controls.Add(this.txbxPlayer1);
            this.Controls.Add(this.lblWins);
            this.Controls.Add(this.lblTitle);
            this.Name = "frmLobby";
            this.Text = "Six Of One Lobby Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblWins;
        private System.Windows.Forms.Label lblLobby;
        private System.Windows.Forms.Label lblP1Wins;
        private System.Windows.Forms.Label lblP2Wins;
        private System.Windows.Forms.TextBox txbxPlayer2;
        private System.Windows.Forms.TextBox txbxPlayer1;
        private System.Windows.Forms.Button btnCreateGame;
        private System.Windows.Forms.Button btnExitLobby;
    }
}