    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tictactoe
{
    class Program
    {
        static void Main(string[] args)
        {
            //Welcome message
            Console.WriteLine("Welcome. Let's play Tic Tac Toe");

            bool gameOver = false;

            //Grid
            string[] grid = new string[] { "0", "1", "2", "3", "4", "5", "6", "7", "8" };

            /*Console.WriteLine("-------------");
              Console.WriteLine("|[0]|[1]|[2]|");
              Console.WriteLine("-------------");
              Console.WriteLine("|{3}|{4}|{5}|");
              Console.WriteLine("-------------");
              Console.WriteLine("|{6}|{7}|{8}|");
              Console.WriteLine("-------------");*/

            Console.WriteLine(string.Format("{0} {1} {2}", grid[0], grid[1], grid[2]));
            Console.WriteLine(string.Format("{0} {1} {2}", grid[3], grid[4], grid[5]));
            Console.WriteLine(string.Format("{0} {1} {2}", grid[6], grid[7], grid[8]));

            int inputNumber = 0;

            while(!gameOver)
            {
               // int input = GetUserInput();
            }
            if (grid[0] == grid[1] && grid[1] == grid[2])
            {
                Console.WriteLine("We have a winner!");

            }
            else if (grid[3] == grid[4] && grid[4] == grid[5])
            {
                Console.WriteLine("We have a winner!");
            }
            else if (grid[6] == grid[7] && grid[7] == grid[8])
            {
                Console.WriteLine("We have a winner!");
            }
            else if (grid[0] == grid[3] && grid[3] == grid[6])
            {
                Console.WriteLine("We have a winner!");
            }
            else if (grid[1] == grid[4] && grid[4] == grid[7])
            {
                Console.WriteLine("We have a winner!");
            }
            else if (grid[2] == grid[5] && grid[5] == grid[8])
            {
                Console.WriteLine("We have a winner!");
            }
            else if (grid[0] == grid[4] && grid[4] == grid[8])
            {
                Console.WriteLine("We have a winner!");
            }
            else if (grid[2] == grid[4] && grid[4] == grid[6])
            {
                Console.WriteLine("We have a winner!");
            }

            method(grid);









            //endgame
            Console.WriteLine("Thanks for playing!");






            Console.ReadLine();

        }
        static void method(string[] grid)
        {
            string playerinput= Console.ReadLine();
        }

        static void playerinput(string[] grid)
        {

        }
    }
}
