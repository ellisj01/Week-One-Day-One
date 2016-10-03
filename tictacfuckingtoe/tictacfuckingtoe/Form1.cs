using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tictacfuckingtoe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (click1 == 0)
            {
                if (turn % 2 != 0)
                {
                    button1.Text = "X";
                }
                else
                {
                    button1.Text = "O";
                }
                turn++;
                click1++;
            }
            else
            {
                button1.Text = button1.Text;
            }
            display();
            checkit();

            //button2


            if (click2 == 0)
            {
                if (turn % 2 != 0)
                {
                    button2.Text = "X";
                }
                else
                {
                    button2.Text = "O";
                }
                turn++;
                click2++;
            }
            else
            {
                button2.Text = button2.Text;
            }
            display();
            checkit();

            //button3

            if (click3 == 0)
            {
                if (turn % 2 != 0)
                {
                    button3.Text = "X";
                }
                else
                {
                    button3.Text = "O";
                }
                turn++;
                click3++;
            }
            else
            {
                button3.Text = button3.Text;
            }
            display();
            checkit();

            //button4

            if (click4 == 0)
            {
                if (turn % 2 != 0)
                {
                    button4.Text = "X";
                }
                else
                {
                    button4.Text = "O";
                }
                turn++;
                click4++;
            }
            else
            {
                button4.Text = button4.Text;
            }
            display();
            checkit();

            //button5

            if (click5 == 0)
            {
                if (turn % 2 != 0)
                {
                    button5.Text = "X";
                }
                else
                {
                    button5.Text = "O";
                }
                turn++;
                click5++;
            }
            else
            {
                button5.Text = button5.Text;
            }
            display();
            checkit();

            //button6

            if (click6 == 0)
            {
                if (turn % 2 != 0)
                {
                    button6.Text = "X";
                }
                else
                {
                    button6.Text = "O";
                }
                turn++;
                click6++;
            }
            else
            {
                button6.Text = button6.Text;
            }
            display();
            checkit();

            //button7

            if (click7 == 0)
            {
                if (turn % 2 != 0)
                {
                    button7.Text = "X";
                }
                else
                {
                    button7.Text = "O";
                }
                turn++;
                click7++;
            }
            else
            {
                button7.Text = button7.Text;
            }
            display();
            checkit();

            //button8

            if (click8 == 0)
            {
                if (turn % 2 != 0)
                {
                    button8.Text = "X";
                }
                else
                {
                    button8.Text = "O";
                }
                turn++;
                click8++;
            }
            else
            {
                button8.Text = button8.Text;
            }
            display();
            checkit();

            //button9

            if (click9 == 0)
            {
                if (turn % 2 != 0)
                {
                    button9.Text = "X";
                }
                else
                {
                    button9.Text = "O";
                }
                turn++;
                click9++;
            }
            else
            {
                button9.Text = button9.Text;
            }
            display();
            checkit();
        }

        //display

        public void display()
        {
            if (turn % 2 != 0)
            {
                displayturn.Text = "Player 1";
            }
            else
            {
                displayturn.Text = "Player 2";
            }
        }

        //checkit

        public void checkit()
        {
            if (button1.Text != "" && button2.Text != "" && button3.Text != "")
            {
                if (button1.Text == button2.Text && button1.Text == button3.Text)
                {
                    button1.BackColor = Color.Green;
                    button1.ForeColor = Color.White;
                    button2.BackColor = Color.Green;
                    button2.ForeColor = Color.White;
                    button3.BackColor = Color.Green;
                    button3.ForeColor = Color.White;
                    if (button1.Text == "X")
                    {
                        MessageBox.Show("Player 1 Wins!");
                        player1++;
                        player1score.Text = player1.ToString();
                    }
                    else
                    {
                        MessageBox.Show("Player 2 Wins!");
                        player2++;
                        player2score.Text = player2.ToString();
                    }
                    cleargame();
                }

            }
        }
    }
}
