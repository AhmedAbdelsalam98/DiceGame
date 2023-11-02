using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AhmedAbdelsalamAssgt
{
    //This form presents the option to play with friend or bot
    //By Ahmed Abdelsalam. Last Edited: 31/5/2020.
    public partial class frmGameMenu : Form
    {
        //default constructor
        public frmGameMenu()
        {
            InitializeComponent();
        }

        //This method issues inputboxes for acquiring player names and creates a multi-player lobby form.
        private void btnPlayMulti_Click(object sender, EventArgs e)
        {
            string sName1, sName2;
            InputBox pName1 = new InputBox("Enter player 1 name", "Name:");
            if (pName1.ShowDialog() == DialogResult.OK)
            {
                sName1 = pName1.sFieldValue;
            }
            else
            {
                MessageBox.Show("Player 1 name not entered", "Game Cancelled");
                return;
            }
            InputBox pName2 = new InputBox("Enter player 2 name", "Name:");
            if (pName2.ShowDialog() == DialogResult.OK)
            {
                sName2 = pName2.sFieldValue;
            }
            else
            {
                MessageBox.Show("Player 2 name not entered", "Game Cancelled");
                return;
            }
            frmLobby lobby = new frmLobby(sName1, sName2, false);
            this.Visible = false;
            lobby.ShowDialog();
            this.Visible = true;
        }

        //this method acquires player name and creates a bot game lobby form.
        private void btnPlayBot_Click(object sender, EventArgs e)
        {
            string sName1;
            InputBox pName1 = new InputBox("Enter player name", "Name:");
            if (pName1.ShowDialog() == DialogResult.OK)
            {
                sName1 = pName1.sFieldValue;
            }
            else
            {
                MessageBox.Show("Player name not entered", "Game Cancelled");
                return;
            }
            frmLobby lobby = new frmLobby(sName1, "Karen (bot)", true);
            this.Visible = false;
            lobby.ShowDialog();
            this.Visible = true;
        }
    }
}
