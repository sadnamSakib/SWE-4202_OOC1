using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
   


        private void topLeftButton_Click(object sender, EventArgs e)
        {
            if (GAMECONTROL.player == 0 && topLeftButton.Text!="O")
            {
                topLeftButton.Text = "X";
                GAMECONTROL.arr[0, 0] = GAMECONTROL.player+1;
                GAMECONTROL.switchPlayer();
            }
            else if(GAMECONTROL.player == 1 && topLeftButton.Text != "X")
            {
                topLeftButton.Text = "O";
                 GAMECONTROL.arr[0, 0] = GAMECONTROL.player + 1;
                GAMECONTROL.switchPlayer();
            }
            
            string firstRow = topLeftButton.Text + TopButton.Text + topRightButton.Text;
            string secondRow = leftButton.Text + middleButton.Text + rightButton.Text;
            string thirdRow = bottomLeftButton.Text + bottomButton.Text + bottomRightButton.Text;
            int result=GAMECONTROL.checkWinState();
            
            if (result == 1)
            {
                if (GAMECONTROL.player == 1)
                {
                    resultLabel.Text = "Player 1 Wins.";
                    GAMECONTROL.player1wincount++;
                    player1Label.Text = Convert.ToString(GAMECONTROL.player1wincount);
                }
                else
                {
                    resultLabel.Text = "Player 2 Wins.";
                    GAMECONTROL.player2wincount++;
                    player2Label.Text = Convert.ToString(GAMECONTROL.player2wincount);
                }

                
            }
            else if (result == 2)
            {
                resultLabel.Text = "Draw";
            }
            if(result==1 || result == 2)
            {
                topLeftButton.Text = "";
                topRightButton.Text = "";
                TopButton.Text = "";
                leftButton.Text = "";
                rightButton.Text = "";
                middleButton.Text = "";
                bottomButton.Text = "";
                bottomLeftButton.Text = "";
                bottomRightButton.Text = "";
                GAMECONTROL.clearBoard();
            }

            
            
        }

        private void TopButton_Click(object sender, EventArgs e)
        {
            if (GAMECONTROL.player == 0 && TopButton.Text != "O")
            {
                TopButton.Text = "X";
            GAMECONTROL.arr[0, 1] = GAMECONTROL.player + 1;
                GAMECONTROL.switchPlayer();
            }
            else if(GAMECONTROL.player == 1 && TopButton.Text != "X")
            {
                TopButton.Text = "O";
            GAMECONTROL.arr[0, 1] = GAMECONTROL.player + 1;
                GAMECONTROL.switchPlayer();
            }
            string firstRow = topLeftButton.Text + TopButton.Text + topRightButton.Text;
            string secondRow = leftButton.Text + middleButton.Text + rightButton.Text;
            string thirdRow = bottomLeftButton.Text + bottomButton.Text + bottomRightButton.Text;
            int result = GAMECONTROL.checkWinState();
            if (result == 1)
            {
                if (GAMECONTROL.player == 1)
                {
                    resultLabel.Text = "Player 1 Wins.";
                    GAMECONTROL.player1wincount++;
                    player1Label.Text = Convert.ToString(GAMECONTROL.player1wincount);
                }
                else
                {
                    resultLabel.Text = "Player 2 Wins.";
                    GAMECONTROL.player2wincount++;
                    player2Label.Text = Convert.ToString(GAMECONTROL.player2wincount);
                }
            }
            else if (result == 2)
            {
                resultLabel.Text = "Draw";
            }
            if (result == 1 || result == 2)
            {
                topLeftButton.Text = "";
                topRightButton.Text = "";
                TopButton.Text = "";
                leftButton.Text = "";
                rightButton.Text = "";
                middleButton.Text = "";
                bottomButton.Text = "";
                bottomLeftButton.Text = "";
                bottomRightButton.Text = "";
                GAMECONTROL.clearBoard();
            }
            
        }

        private void topRightButton_Click(object sender, EventArgs e)
        {
            if (GAMECONTROL.player == 0 && topRightButton.Text != "O")
            {
                topRightButton.Text = "X";
            GAMECONTROL.arr[0, 2] = GAMECONTROL.player + 1;
                GAMECONTROL.switchPlayer();
            }
            else if(GAMECONTROL.player == 1 && topRightButton.Text != "X")
            {
                topRightButton.Text = "O";
            GAMECONTROL.arr[0, 2] = GAMECONTROL.player + 1;
                GAMECONTROL.switchPlayer();
            }
            string firstRow = topLeftButton.Text + TopButton.Text + topRightButton.Text;
            string secondRow = leftButton.Text + middleButton.Text + rightButton.Text;
            string thirdRow = bottomLeftButton.Text + bottomButton.Text + bottomRightButton.Text;
            int result = GAMECONTROL.checkWinState();
            if (result == 1)
            {
                if (GAMECONTROL.player == 1)
                {
                    resultLabel.Text = "Player 1 Wins.";
                    GAMECONTROL.player1wincount++;
                    player1Label.Text = Convert.ToString(GAMECONTROL.player1wincount);
                }
                else
                {
                    resultLabel.Text = "Player 2 Wins.";
                    GAMECONTROL.player2wincount++;
                    player2Label.Text = Convert.ToString(GAMECONTROL.player2wincount);
                }
            }
            else if (result == 2)
            {
                resultLabel.Text = "Draw";
            }
            if (result == 1 || result == 2)
            {
                topLeftButton.Text = "";
                topRightButton.Text = "";
                TopButton.Text = "";
                leftButton.Text = "";
                rightButton.Text = "";
                middleButton.Text = "";
                bottomButton.Text = "";
                bottomLeftButton.Text = "";
                bottomRightButton.Text = "";
                GAMECONTROL.clearBoard();
            }
            
        }

        private void leftButton_Click(object sender, EventArgs e)
        {
            if (GAMECONTROL.player == 0 && leftButton.Text != "O")
            {
                leftButton.Text = "X";
            GAMECONTROL.arr[1, 0] = GAMECONTROL.player + 1;
                GAMECONTROL.switchPlayer();
            }
            else if(GAMECONTROL.player == 1 && leftButton.Text != "X")
            {
                leftButton.Text = "O";
                GAMECONTROL.arr[1, 0] = GAMECONTROL.player + 1;
                GAMECONTROL.switchPlayer();
            }
            string firstRow = topLeftButton.Text + TopButton.Text + topRightButton.Text;
            string secondRow = leftButton.Text + middleButton.Text + rightButton.Text;
            string thirdRow = bottomLeftButton.Text + bottomButton.Text + bottomRightButton.Text;
            int result = GAMECONTROL.checkWinState();
            if (result == 1)
            {
                if (GAMECONTROL.player == 1)
                {
                    resultLabel.Text = "Player 1 Wins.";
                    GAMECONTROL.player1wincount++;
                    player1Label.Text = Convert.ToString(GAMECONTROL.player1wincount);
                }
                else
                {
                    resultLabel.Text = "Player 2 Wins.";
                    GAMECONTROL.player2wincount++;
                    player2Label.Text = Convert.ToString(GAMECONTROL.player2wincount);
                }
            }
            else if (result == 2)
            {
                resultLabel.Text = "Draw";
            }
            if (result == 1 || result == 2)
            {
                topLeftButton.Text = "";
                topRightButton.Text = "";
                TopButton.Text = "";
                leftButton.Text = "";
                rightButton.Text = "";
                middleButton.Text = "";
                bottomButton.Text = "";
                bottomLeftButton.Text = "";
                bottomRightButton.Text = "";
                GAMECONTROL.clearBoard();
            }
            
        }

        private void middleButton_Click(object sender, EventArgs e)
        {
            if (GAMECONTROL.player == 0 && middleButton.Text != "O")
            {
                middleButton.Text = "X";
            GAMECONTROL.arr[1, 1] = GAMECONTROL.player + 1;
                GAMECONTROL.switchPlayer();
            }
            else if(GAMECONTROL.player == 1 && middleButton.Text != "X")
            {
                middleButton.Text = "O";
            GAMECONTROL.arr[1, 1] = GAMECONTROL.player + 1;
                GAMECONTROL.switchPlayer();
            }
            string firstRow = topLeftButton.Text + TopButton.Text + topRightButton.Text;
            string secondRow = leftButton.Text + middleButton.Text + rightButton.Text;
            string thirdRow = bottomLeftButton.Text + bottomButton.Text + bottomRightButton.Text;
            int result = GAMECONTROL.checkWinState();
            if (result == 1)
            {
                if (GAMECONTROL.player == 1)
                {
                    resultLabel.Text = "Player 1 Wins.";
                    GAMECONTROL.player1wincount++;
                    player1Label.Text = Convert.ToString(GAMECONTROL.player1wincount);
                }
                else
                {
                    resultLabel.Text = "Player 2 Wins.";
                    GAMECONTROL.player2wincount++;
                    player2Label.Text = Convert.ToString(GAMECONTROL.player2wincount);
                }
            }
            else if (result == 2)
            {
                resultLabel.Text = "Draw";
            }
            if (result == 1 || result == 2)
            {
                topLeftButton.Text = "";
                topRightButton.Text = "";
                TopButton.Text = "";
                leftButton.Text = "";
                rightButton.Text = "";
                middleButton.Text = "";
                bottomButton.Text = "";
                bottomLeftButton.Text = "";
                bottomRightButton.Text = "";
                GAMECONTROL.clearBoard();
            }
           
        }

        private void rightButton_Click(object sender, EventArgs e)
        {
            if (GAMECONTROL.player == 0 && rightButton.Text != "O")
            {
                rightButton.Text = "X";
            GAMECONTROL.arr[1, 2] = GAMECONTROL.player + 1;
                GAMECONTROL.switchPlayer();
            }
            else if(GAMECONTROL.player == 1 && rightButton.Text != "X")
            {
                rightButton.Text = "O";
            GAMECONTROL.arr[1, 2] = GAMECONTROL.player + 1;
                GAMECONTROL.switchPlayer();
            }
            string firstRow = topLeftButton.Text + TopButton.Text + topRightButton.Text;
            string secondRow = leftButton.Text + middleButton.Text + rightButton.Text;
            string thirdRow = bottomLeftButton.Text + bottomButton.Text + bottomRightButton.Text;
            int result = GAMECONTROL.checkWinState();
            if (result == 1)
            {
                if (GAMECONTROL.player == 1)
                {
                    resultLabel.Text = "Player 1 Wins.";
                    GAMECONTROL.player1wincount++;
                    player1Label.Text = Convert.ToString(GAMECONTROL.player1wincount);
                }
                else
                {
                    resultLabel.Text = "Player 2 Wins.";
                    GAMECONTROL.player2wincount++;
                    player2Label.Text = Convert.ToString(GAMECONTROL.player2wincount);
                }
            }
            else if (result == 2)
            {
                resultLabel.Text = "Draw";
            }
            if (result == 1 || result == 2)
            {
                topLeftButton.Text = "";
                topRightButton.Text = "";
                TopButton.Text = "";
                leftButton.Text = "";
                rightButton.Text = "";
                middleButton.Text = "";
                bottomButton.Text = "";
                bottomLeftButton.Text = "";
                bottomRightButton.Text = "";
                GAMECONTROL.clearBoard();
            }
            
        }

        private void bottomLeftButton_Click(object sender, EventArgs e)
        {
            if (GAMECONTROL.player == 0 && bottomLeftButton.Text != "O")
            {
                bottomLeftButton.Text = "X";
            GAMECONTROL.arr[2, 0] = GAMECONTROL.player + 1;
                GAMECONTROL.switchPlayer();
            }
            else if(GAMECONTROL.player == 1 && bottomLeftButton.Text != "X")
            {
                bottomLeftButton.Text = "O";
            GAMECONTROL.arr[2, 0] = GAMECONTROL.player + 1;
                GAMECONTROL.switchPlayer();
            }
            string firstRow = topLeftButton.Text + TopButton.Text + topRightButton.Text;
            string secondRow = leftButton.Text + middleButton.Text + rightButton.Text;
            string thirdRow = bottomLeftButton.Text + bottomButton.Text + bottomRightButton.Text;
            int result = GAMECONTROL.checkWinState();
            if (result == 1)
            {
                if (GAMECONTROL.player == 1)
                {
                    resultLabel.Text = "Player 1 Wins.";
                    GAMECONTROL.player1wincount++;
                    player1Label.Text = Convert.ToString(GAMECONTROL.player1wincount);
                }
                else
                {
                    resultLabel.Text = "Player 2 Wins.";
                    GAMECONTROL.player2wincount++;
                    player2Label.Text = Convert.ToString(GAMECONTROL.player2wincount);
                }
            }
            else if (result == 2)
            {
                resultLabel.Text = "Draw";
            }
            if (result == 1 || result == 2)
            {
                topLeftButton.Text = "";
                topRightButton.Text = "";
                TopButton.Text = "";
                leftButton.Text = "";
                rightButton.Text = "";
                middleButton.Text = "";
                bottomButton.Text = "";
                bottomLeftButton.Text = "";
                bottomRightButton.Text = "";
                GAMECONTROL.clearBoard();
            }
            
        }

        private void bottomButton_Click(object sender, EventArgs e)
        {
            if (GAMECONTROL.player == 0 && bottomButton.Text != "O")
            {
                bottomButton.Text = "X";
            GAMECONTROL.arr[2, 1] = GAMECONTROL.player + 1;
                GAMECONTROL.switchPlayer();
            }
            else if(GAMECONTROL.player == 1 && bottomButton.Text != "X")
            {
                bottomButton.Text = "O";
            GAMECONTROL.arr[2, 1] = GAMECONTROL.player + 1;
                GAMECONTROL.switchPlayer();
            }
            string firstRow = topLeftButton.Text + TopButton.Text + topRightButton.Text;
            string secondRow = leftButton.Text + middleButton.Text + rightButton.Text;
            string thirdRow = bottomLeftButton.Text + bottomButton.Text + bottomRightButton.Text;
            int result = GAMECONTROL.checkWinState();
            if (result == 1)
            {
                if (GAMECONTROL.player == 1)
                {
                    resultLabel.Text = "Player 1 Wins.";
                    GAMECONTROL.player1wincount++;
                    player1Label.Text = Convert.ToString(GAMECONTROL.player1wincount);
                }
                else
                {
                    resultLabel.Text = "Player 2 Wins.";
                    GAMECONTROL.player2wincount++;
                    player2Label.Text = Convert.ToString(GAMECONTROL.player2wincount);
                }
            }
            else if (result == 2)
            {
                resultLabel.Text = "Draw";
            }
            if (result == 1 || result == 2)
            {
                topLeftButton.Text = "";
                topRightButton.Text = "";
                TopButton.Text = "";
                leftButton.Text = "";
                rightButton.Text = "";
                middleButton.Text = "";
                bottomButton.Text = "";
                bottomLeftButton.Text = "";
                bottomRightButton.Text = "";
                GAMECONTROL.clearBoard();
            }
            
        }

        private void bottomRightButton_Click(object sender, EventArgs e)
        {
            if (GAMECONTROL.player == 0 && bottomRightButton.Text != "O")
            {
                bottomRightButton.Text = "X";
            GAMECONTROL.arr[2, 2] = GAMECONTROL.player + 1;
                GAMECONTROL.switchPlayer();
            }
            else if(GAMECONTROL.player == 1 && bottomRightButton.Text != "X")
            {
                bottomRightButton.Text = "O";
            GAMECONTROL.arr[2, 2] = GAMECONTROL.player + 1;
                GAMECONTROL.switchPlayer();
            }
            string firstRow = topLeftButton.Text + TopButton.Text + topRightButton.Text;
            string secondRow = leftButton.Text + middleButton.Text + rightButton.Text;
            string thirdRow = bottomLeftButton.Text + bottomButton.Text + bottomRightButton.Text;
            int result = GAMECONTROL.checkWinState();
            if (result == 1)
            {
                if (GAMECONTROL.player == 1)
                {
                    resultLabel.Text = "Player 1 Wins.";
                    GAMECONTROL.player1wincount++;
                    player1Label.Text = Convert.ToString(GAMECONTROL.player1wincount);
                }
                else
                {
                    GAMECONTROL.player2wincount++;
                    resultLabel.Text = "Player 2 Wins.";
                    player2Label.Text = Convert.ToString(GAMECONTROL.player2wincount);
                }
            }
            else if (result == 2)
            {
                resultLabel.Text = "Draw";
            }
            if (result == 1 || result == 2)
            {
                topLeftButton.Text = "";
                topRightButton.Text = "";
                TopButton.Text = "";
                leftButton.Text = "";
                rightButton.Text = "";
                middleButton.Text = "";
                bottomButton.Text = "";
                bottomLeftButton.Text = "";
                bottomRightButton.Text = "";
                GAMECONTROL.clearBoard();

            }
            
        }
    }
}
