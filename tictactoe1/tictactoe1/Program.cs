using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tictactoe1
{
    class Program
    {
        //making array and   

        //by default 0-9 where no use of zero ?--clarify with ronda

        static char[] arr = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };

        static int player = 1; //By default player 1 is set  

        static int choice; //holds choice of which cell player wants to choose?-needhelp



            //flag checks for winner(-1=draw, 1=winner,0=in progress)

        static int flag = 0;

        static void Main(string[] args)
        {
            do

            {

                Console.Clear();//lost--needs clarification
                

                Console.WriteLine("\n");

                if (player % 2 == 0)//validtating input/ player 2 

                {

                    Console.WriteLine("Player 2 Chance");

                }

                else

                {

                    Console.WriteLine("Player 1 Chance");

                }

                Console.WriteLine("\n");

                Board();     //calling the board function 

                choice = int.Parse(Console.ReadLine());         //Taking user's input 



                // checking that cell is vacant 

                if (arr[choice] != 'X' && arr[choice] != 'O') 

                {

                    if (player % 2 == 0) //mark as "O" if player 2

                    {

                        arr[choice] = 'O';

                        player++;

                    }

                    else

                    {

                        arr[choice] = 'X';

                        player++;

                    }

                }
           

                else //If same cell is chosen twice, reload; try again

                {


                    Console.WriteLine("\n");
                    

                   

                }

                flag = CheckWin();// checking for winner  

            } while (flag != 1 && flag != -1);//loop runs as long as game is still in progress



            Console.Clear();// console clear

            Board();  // fill grid(board) again



            if (flag == 1)     // flag value=1--there is a winner  

            {

                Console.WriteLine("Player {0} has won", (player % 2) + 1);

            }

            else// if flag value is (-1)--Draw  

            {

                Console.WriteLine("Draw");

            }

            Console.ReadLine();

        }

        //grid layout  

        private static void Board()

        {           //conjoining 2 steps into 1 with grid and subsets

            Console.WriteLine("     |     |      ");

            Console.WriteLine("  {0}  |  {1}  |  {2}", arr[1], arr[2], arr[3]);

            Console.WriteLine("_____|_____|_____ ");

            Console.WriteLine("     |     |      ");

            Console.WriteLine("  {0}  |  {1}  |  {2}", arr[4], arr[5], arr[6]);

            Console.WriteLine("_____|_____|_____ ");

            Console.WriteLine("     |     |      ");

            Console.WriteLine("  {0}  |  {1}  |  {2}", arr[7], arr[8], arr[9]);

            Console.WriteLine("     |     |      ");

        }


        //conditions for winning game

        private static int CheckWin()

        {
            //note: region is used to define a collapsible region--convenience
            #region Horzontal Winning Condtion

            if (arr[1] == arr[2] && arr[2] == arr[3])

            {

                return 1;

            }

            else if (arr[4] == arr[5] && arr[5] == arr[6])

            {

                return 1;

            }

            else if (arr[6] == arr[7] && arr[7] == arr[8])

            {

                return 1;

            }

            #endregion



            #region vertical Winning Condtion     

            else if (arr[1] == arr[4] && arr[4] == arr[7])

            {

                return 1;

            } 

            else if (arr[2] == arr[5] && arr[5] == arr[8])

            {

                return 1;

            } 

            else if (arr[3] == arr[6] && arr[6] == arr[9])

            {

                return 1;

            }

            #endregion



            #region Diagonal Winning Condition

            else if (arr[1] == arr[5] && arr[5] == arr[9])

            {

                return 1;

            }

            else if (arr[3] == arr[5] && arr[5] == arr[7])

            {

                return 1;

            }

            #endregion



            #region Checking For Draw

                // If all the cells are filled and no winner is defined, draw 

            else if (arr[1] != '1' && arr[2] != '2' && arr[3] != '3' && arr[4] != '4' && arr[5] != '5' && arr[6] != '6' && arr[7] != '7' && arr[8] != '8' && arr[9] != '9')

            {

                return -1;

            }

            #endregion



            else

            {

                return 0;

            }

        }

    }
}
    

