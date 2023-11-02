using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


//This manages the game form
//By Ahmed Abdelsalam. Last Edited: 31/5/2020.
namespace AhmedAbdelsalamAssgt
{
    public partial class frmGame : Form
    {
        Random rand = new Random();
        int iScore1, iScore2, iGoal, iTurn;
        public int iWinner { get; set; }
        string sName1, sName2;
        int[] dice = new int[7];
        bool[] selectedDice = new bool[7];
        bool isBotGame, isInitialized, botTurn;
        Color currentColor;
        Graphics[] gra = new Graphics[7];         //dice select highlight graphics
        Graphics gN1, gN2;              //turn name highlight graphics

        //default constructor
        public frmGame()
        {
            InitializeComponent();
        }


        //custom constructor
        public frmGame(string nm1, string nm2, int goal, bool bot)
        {
            InitializeComponent();
            sName1 = nm1;
            sName2 = nm2;
            iGoal = goal;
            txbxName1.Text = sName1;
            txbxName2.Text = sName2;
            gra[1] = pcbxDice1.CreateGraphics();
            gra[2] = pcbxDice2.CreateGraphics();
            gra[3] = pcbxDice3.CreateGraphics();
            gra[4] = pcbxDice4.CreateGraphics();
            gra[5] = pcbxDice5.CreateGraphics();
            gra[6] = pcbxDice6.CreateGraphics();
            gN1 = pcbxName1.CreateGraphics();
            gN2 = pcbxName2.CreateGraphics();
            btnEndTurn.Enabled = false;
            txbxHint.Text = ("Initialize the game to start.");
            isBotGame = bot;

        }

        //select/deselect dice 1
        private void pcbxDice1_Click(object sender, EventArgs e)
        {
            if (botTurn)
                return;
            SelectDice(1);
        }
        //select/deselect dice 2
        private void pcbxDice2_Click(object sender, EventArgs e)
        {
            if (botTurn)
                return;
            SelectDice(2);
        }
        //select/deselect dice 3
        private void pcbxDice3_Click(object sender, EventArgs e)
        {
            if (botTurn)
                return;
            SelectDice(3);
        }
        //select/deselect dice 4
        private void pcbxDice4_Click(object sender, EventArgs e)
        {
            if (botTurn)
                return;
            SelectDice(4);
        }
        //select/deselect dice 5
        private void pcbxDice5_Click(object sender, EventArgs e)
        {
            if (botTurn)
                return;
            SelectDice(5);
        }
        //select/deselect dice 6
        private void pcbxDice6_Click(object sender, EventArgs e)
        {
            if (botTurn)
                return;
            SelectDice(6);
        }

        //This helper method alters selected dice boolean and highlights dice accordingly.
        private void SelectDice(int i)
        {
            selectedDice[i] = !selectedDice[i];
            if (selectedDice[i])
            {
                gra[i].DrawRectangle(new Pen(currentColor, 2), 1, 1, 98, 98);
            }
            else
            {
                gra[i].DrawRectangle(new Pen(Color.White, 2), 1, 1, 98, 98);
            }
        }

        //calls RollDice() method
        private void btnRoll_Click(object sender, EventArgs e)
        {
            RollDice();
        }

        /**
        This method initializes game if it has not been initialized.
        This method controls flow of the game and applies game rules.
        This method tracks the values of rolled selected dice. 
        **/
        private void RollDice()
        {
            if (!isInitialized)
            {
                btnRoll.Text = "Roll Selected Dice";
                for (int i = 1; i < dice.Length; i++)
                {
                    UpdateDice(i, rand.Next(1, 7));
                }
                iTurn = rand.Next(1,3);
                UpdateScoreBar();
                NextTurn();
            }
            else
            {
                btnRoll.Enabled = false;
                btnCloseGame.Enabled = false; //disabled for miniscule duration remove distracting highlighted exited button issue
                txbxHint.Text = "Press End Turn to finish turn";
                int sum = 0;
                int numOfDiceRolled = 0;
                int[] diceNumTimes = new int[7];
                bool[] selected;
                selected = (bool[])selectedDice.Clone();
                for (int i = 1; i < selected.Length; i++)
                {
                    if (selected[i])
                    {
                        int randomRoll = rand.Next(1, 7);
                        UpdateDice(i, randomRoll);
                        diceNumTimes[randomRoll] += 1;
                        sum += randomRoll;
                        numOfDiceRolled++;
                    }
                }
                string str = "";
                if (numOfDiceRolled > 0)
                {
                    str = "Player " + iTurn + " has rolled " + numOfDiceRolled + " dice and ";
                }
                else
                {
                    rtxbxMsg.AppendText("\nPlayer " + iTurn + " did not role any dice.");
                }
                for (int i = 1; i < diceNumTimes.Length; i++)
                {
                    if (i == 1 && diceNumTimes[1] == 1)
                    {
                        rtxbxMsg.AppendText("\n" + str + "scored nothing.");
                        break;
                    }
                    else if (i == 1 && diceNumTimes[1] == 2)
                    {
                        rtxbxMsg.AppendText("\n" + str + "got snake eyes, back to zero.");
                        SetScore(0);
                        break;
                    }
                    else if (i == 1 && diceNumTimes[1] == 3)
                    {
                        rtxbxMsg.AppendText("\n" + str + "got a dead drop.");
                        if (iTurn == 1)
                            MakeWinner(2);
                        else
                            MakeWinner(1);
                        break;
                    }
                    else if (i == 1 && diceNumTimes[1] == 4)
                    {
                        rtxbxMsg.AppendText("\n" + str + "got a boojum.");
                        MakeWinner(iTurn);
                        break;
                    }
                    else if (diceNumTimes[i] == 3 && diceNumTimes[1] == 0)
                    {
                        rtxbxMsg.AppendText("\n" + str + "got a snaffle, double the points to " + sum * 2 + "!");
                        AddScore(sum * 2);
                        break;
                    }
                    else if (i == 6)
                    {
                        if (numOfDiceRolled > 0)
                            rtxbxMsg.AppendText("\n" + str + "safely secured " + sum + " points.");
                        AddScore(sum);
                        break;
                    }
                }
                if (iWinner == 0 && !botTurn)
                {
                    btnEndTurn.Enabled = true;
                }
                btnCloseGame.Enabled = true;
            }
        }

        //This method updates the value and face graphics of dice 
        private void UpdateDice(int num, int value)
        {
            gra[num].Clear(Color.White);
            if (selectedDice[num])
            {
                gra[num].DrawRectangle(new Pen(currentColor, 2), 1, 1, 98, 98);
            }
            dice[num] = value;
            switch (value)
            {
                case 1:
                    gra[num].FillEllipse(Brushes.Black, 40, 40, 20, 20);
                    break;
                case 2:
                    gra[num].FillEllipse(Brushes.Black, 65, 15, 20, 20);
                    gra[num].FillEllipse(Brushes.Black, 15, 65, 20, 20);
                    break;
                case 3:

                    gra[num].FillEllipse(Brushes.Black, 65, 15, 20, 20);
                    gra[num].FillEllipse(Brushes.Black, 15, 65, 20, 20);
                    gra[num].FillEllipse(Brushes.Black, 40, 40, 20, 20);
                    break;
                case 4:
                    gra[num].FillEllipse(Brushes.Black, 65, 15, 20, 20);
                    gra[num].FillEllipse(Brushes.Black, 15, 65, 20, 20);
                    gra[num].FillEllipse(Brushes.Black, 65, 65, 20, 20);
                    gra[num].FillEllipse(Brushes.Black, 15, 15, 20, 20);
                    break;
                case 5:
                    gra[num].FillEllipse(Brushes.Black, 65, 15, 20, 20);
                    gra[num].FillEllipse(Brushes.Black, 15, 65, 20, 20);
                    gra[num].FillEllipse(Brushes.Black, 65, 65, 20, 20);
                    gra[num].FillEllipse(Brushes.Black, 15, 15, 20, 20);
                    gra[num].FillEllipse(Brushes.Black, 40, 40, 20, 20);
                    break;
                case 6:
                    gra[num].FillEllipse(Brushes.Black, 65, 15, 20, 20);
                    gra[num].FillEllipse(Brushes.Black, 15, 65, 20, 20);
                    gra[num].FillEllipse(Brushes.Black, 65, 65, 20, 20);
                    gra[num].FillEllipse(Brushes.Black, 15, 15, 20, 20);
                    gra[num].FillEllipse(Brushes.Black, 65, 40, 20, 20);
                    gra[num].FillEllipse(Brushes.Black, 15, 40, 20, 20);
                    break;
            }
        }

        //This method sets the score value and calls UpdateScoreBar()
        private void SetScore(int score)
        {
            if (iTurn == 1)
            {
                iScore1 = score;
            }
            else
            {
                iScore2 = score;
            }
            UpdateScoreBar();
        }

        //This methods adds a value to the current player score and calls UpdateScoreBar()
        private void AddScore(int score)
        {
            if (iTurn == 1)
            {
                iScore1 += score;
            }
            else
            {
                iScore2 += score;
            }
            UpdateScoreBar();
        }

        //This method updates score bar and checks if goal has been reached
        private void UpdateScoreBar()
        {
            txbxScore1.Text = Convert.ToString(iScore1);
            txbxScore2.Text = Convert.ToString(iScore2);
            if (iScore1 >= iGoal || iScore2 >= iGoal)
            {
                MakeWinner(iTurn);
            }
        }

        //This method ends turn
        private void btnEndTurn_Click(object sender, EventArgs e)
        {
            NextTurn();
        }

        //This method is controls bot actions and includes human-like delays
        private void BotDoStuff()
        {
            System.Threading.Thread.Sleep(1000);
            List<int> availableDice = new List<int>();
            int numOfSelections = rand.Next(1, 7);
            for (int i = 1; i < 7; i++)
            {
                availableDice.Add(i);
            }
            while (numOfSelections > 0)
            {
                int randomD = rand.Next(0, availableDice.Count());
                SelectDice(availableDice[randomD]);
                availableDice.RemoveAt(randomD);
                numOfSelections--;
                System.Threading.Thread.Sleep(300);
            }
            RollDice();
            System.Threading.Thread.Sleep(2000);
            if (iWinner == 0)
            {
                NextTurn();
            }
        }

/**     Attempt to make a bot strategy based on the mean dice amount needed to win and the difference between both players   
 *      private int BotStrategy()
        {
            int amount;
            int diceToWin1 = Convert.ToInt32(Math.Round((iGoal - iScore1) / 3.5));
            int diceToWin2 = Convert.ToInt32(Math.Round((iGoal - iScore2) / 3.5));
            int dif = diceToWin2 - diceToWin1;
            amount = (diceToWin1 + dif) > 6 ? 6 : (diceToWin1 + dif);
            if (diceToWin1 <= 2)
            {
                return amount;
            }
            else if (diceToWin1 <= 4)
            {
                if (dif < 3)
                {
                    return Convert.ToInt32(amount / 2.0);
                }
            }
            else
            {
                if (dif <)
            }
        }
**/

        //This methods manages player turn variable and aspects on start of next turn
        //This method checks if its bot turn and triggers DoBotStuff() method
        private void NextTurn()
        {
            if (iTurn == 1)
            {
                iTurn = 2;
                gN1.DrawRectangle(new Pen(this.BackColor, 2), 1, 1, 117, 37);
                gN2.DrawRectangle(new Pen(Color.Blue, 2), 1, 1, 117, 37);
                currentColor = Color.Blue;
            }
            else
            {
                iTurn = 1;
                gN2.DrawRectangle(new Pen(this.BackColor, 2), 1, 1, 117, 37);
                gN1.DrawRectangle(new Pen(Color.Red, 2), 1, 1, 117, 37);
                currentColor = Color.Red;
            }
            if (isBotGame && iTurn == 2)
            {
                botTurn = true;
                btnRoll.Enabled = false;
                btnEndTurn.Enabled = false;
            }
            else
            {
                botTurn = false;
                btnRoll.Enabled = true;
                btnEndTurn.Enabled = false;
            }
            ResetSelection();
            txbxHint.Text = ("Player " + iTurn + " selects dice");
            if (isInitialized)
            {
                rtxbxMsg.AppendText("\nPlayer " + iTurn + "'s turn, pass the device.");
            }
            else
            {
                rtxbxMsg.AppendText("Player " + iTurn + " starts, pass the device.");
                isInitialized = true;
            }
            if (botTurn)
            {
                BotDoStuff();
            }
        }

        //This method resets the selection of dice to none
        private void ResetSelection()
        {
            for (int i = 1; i < selectedDice.Length; i++)
            {
                if (selectedDice[i])
                {
                    SelectDice(i);
                }
            }
        }

        //This method anoints a winner
        private void MakeWinner(int iPlayer)
        {
            iWinner = iPlayer;
            btnEndTurn.Enabled = false;
            rtxbxMsg.AppendText("\nCongratulations, player " + iPlayer + " has won the game!");
            txbxHint.Text = "Game Over.";
        }

        //This method moves scrollbar to bottom when more text is added to textbox
        //reference: https://stackoverflow.com/questions/9416608/rich-text-box-scroll-to-the-bottom-when-new-data-is-written-to-it
        private void rtxbxMsg_TextChanged(object sender, EventArgs e)
        {
            rtxbxMsg.SelectionStart = rtxbxMsg.Text.Length;
            rtxbxMsg.ScrollToCaret();
        }

        //this method closes the game if winner is chosen, otherwise warns then closes if user chooses OK
        private void btnCloseGame_Click(object sender, EventArgs e)
        {
            if (iWinner == 0)
            {
                DialogResult result = MessageBox.Show("Are you sure you want to leave?", "Game Not Over", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    this.Close();
                }
            }
            else
            {
                this.Close();
            }
        }
    }

}
