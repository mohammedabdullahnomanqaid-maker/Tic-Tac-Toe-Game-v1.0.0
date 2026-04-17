using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_tic_tac_toe
{
    public partial class Form1 : Form
    {
        char Player = 'x';
        stGameStatus GameStatus;
        enPlayer PlayerTurn = enPlayer.Player1;
 
        Image GetPicture()
        {
            if (Player == 'x')
            {
                lbTurn.Text = "1";
                Player = 'o';
                return Properties.Resources.X;
            }

            lbTurn.Text = "2";
            Player = 'x';
            return Properties.Resources.O;

        }

        public Form1()
        {
            InitializeComponent();
        }

       
        enum enPlayer
        {
            Player1,
            Player2
        }
        enum enWinner
        {
            Player1,
            Player2,
            Draw,
            GameInProgress
        }

        struct stGameStatus
        {
            public enWinner Winner;
            public bool GameOver;
            public short PlayCount;
        }

        void ResetBtn(Button btn)
        {
            btn.Image = Properties.Resources.question_mark_96;
            btn.Tag= "?";
            btn.BackColor = Color.Transparent;
        }

        void EndGame()
        {
            switch(GameStatus.Winner)
            {
                case enWinner.Player1:
                    lbWhoIsWinner.Text = "Player 1";
                    break;

                case enWinner.Player2:
                    lbWhoIsWinner.Text = "Player 2";
                    break;

                default:
                    lbWhoIsWinner.Text = "Draw";
                    break;
            }
            MessageBox.Show("GameOver", "GameOver", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        bool CheckValue(Button btn1,Button btn2,Button btn3)
        {
            if( btn1.Tag.ToString()!="?"&&
                btn1.Tag.ToString()==btn2.Tag.ToString() &&
                btn1.Tag.ToString() == btn3.Tag.ToString() 
                
                )
            {
                btn1.BackColor = Color.Green;
                btn2.BackColor = Color.Green;
                btn3.BackColor = Color.Green;
                
                if(btn1.Tag=="x")
                {
                    GameStatus.Winner=enWinner.Player1;
                    GameStatus.GameOver = true;
                    EndGame();
                    return true;
                }
                else
                {
                    GameStatus.Winner = enWinner.Player2;
                    GameStatus.GameOver = true;
                    EndGame();
                    return true;
                }
            }
            GameStatus.GameOver = false;
            return false;
     
        }
        void CheckWinner()
        {
            if (CheckValue(button1, button2, button3))
                return;

            if (CheckValue(button4, button5, button6))
                return;

            if (CheckValue(button7, button8, button9))
                return;

            if (CheckValue(button2, button5, button8))
                return;

            if (CheckValue(button1, button4, button7))
                return;

            if (CheckValue(button3, button6, button9))
                return;

            if (CheckValue(button1, button5, button9))
                return;

            if (CheckValue(button3, button5, button7))
                return;
        }

        void CheckWinner(Button btn)
        {
            if (btn.Tag == "?")
            {
                switch (PlayerTurn)
                {
                    case enPlayer.Player1:
                        btn.Image = Properties.Resources.X;
                        PlayerTurn = enPlayer.Player2;
                        lbTurn.Text = "Player 2";
                        btn.Tag = "x";
                        GameStatus.PlayCount++;
                        CheckWinner();
                        break;

                    case enPlayer.Player2:
                        btn.Image = Properties.Resources.O;
                        PlayerTurn = enPlayer.Player1;
                        lbTurn.Text = "Player 1";
                        btn.Tag = "o";
                        GameStatus.PlayCount++;
                        CheckWinner();
                        break;
                }
            }
            else
            {
                MessageBox.Show("Wrong Choice", "Wrong", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if(GameStatus.PlayCount==9)
            {
                GameStatus.GameOver = true;
                GameStatus.Winner = enWinner.Draw;
                EndGame();
            }
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Color black = Color.White;
            Pen pen = new Pen(black);

            pen.Width = 10;

            pen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
            pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;
            e.Graphics.DrawLine(pen, 450, 400, 450, 80);
            e.Graphics.DrawLine(pen, 600, 400, 600, 80);
            e.Graphics.DrawLine(pen, 750, 185, 300, 185);
            e.Graphics.DrawLine(pen, 750, 300, 300, 300);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            picProgrammingP.Image = Properties.Resources.ProgrammingP;
            picProgrammingAdvice.Image = Properties.Resources.ProgrammingAdvice;
        }

        private void button_Click(object sender, EventArgs e)
        {
            CheckWinner((Button)sender);
        }

        private void btnRestartGame_Click(object sender, EventArgs e)
        {
            ResetBtn(button1);
            ResetBtn(button2);
            ResetBtn(button3);
            ResetBtn(button4);
            ResetBtn(button5);
            ResetBtn(button6);
            ResetBtn(button7);
            ResetBtn(button8);
            ResetBtn(button9);

            PlayerTurn=enPlayer.Player1;
            GameStatus.Winner = enWinner.GameInProgress;
            GameStatus.PlayCount = 0;
            lbWhoIsWinner.Text = "In Progress";
            GameStatus.GameOver = false;
            lbTurn.Text = "Player 1";
        }
    }
}
