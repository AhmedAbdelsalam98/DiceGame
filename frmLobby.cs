using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//This form shows the lobby and win scoreboard for players
//By Ahmed Abdelsalam. Last Edited: 31/5/2020.
namespace AhmedAbdelsalamAssgt
{
    public partial class frmLobby : Form
    {
        string sName1, sName2;
        int iWins1 = 0, iWins2 = 0;
        bool bot;

        //default constructor
        public frmLobby()
        {
            InitializeComponent();
        }

        //custom constructor
        public frmLobby(string nm1, string nm2, bool b)
        {
            InitializeComponent();
            sName1 = nm1;
            sName2 = nm2;
            txbxPlayer1.Text = nm1;
            txbxPlayer2.Text = nm2;
            lblP1Wins.Text = Convert.ToString(iWins1);
            lblP2Wins.Text = Convert.ToString(iWins2);
            bot = b;
        }

        //This method creates a new game form and updates the win value.
        private void btnCreateGame_Click(object sender, EventArgs e)
        {
            frmGame game;
            InputBox goalInput = new InputBox("Enter Goal for Game","Game goal:");
            if (goalInput.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    game = new frmGame(sName1, sName2, Convert.ToInt32(goalInput.sFieldValue), bot);
                    game.ShowDialog();
                    if (game.iWinner == 1)
                    {
                        iWins1++;
                        lblP1Wins.Text = Convert.ToString(iWins1);
                    }
                    else if (game.iWinner == 2)
                    {
                        iWins2++;
                        lblP2Wins.Text = Convert.ToString(iWins2);
                    }
                }
                catch (FormatException)
                {
                    MessageBox.Show("Incorrect goal value", "Game Cancelled");
                    return;
                }
            }
        }

        //This method exits the lobby
        private void btnExitLobby_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to leave?", "Exiting Lobby", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }

}
