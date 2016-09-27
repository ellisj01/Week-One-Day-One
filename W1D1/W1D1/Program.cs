using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W1D1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World");
            int myInteger = 1492;
            bool learningBools = true;
            DateTime myString2 = Convert.ToDateTime("9/26/2016");
            double myDouble = 5.45;
            string myString1 = "X";
            string myString = "Hello, World";

            Console.WriteLine("Columbus sailed the world in " + myInteger);

            Console.WriteLine("It is " + learningBools + " that I have a dog at home");

            Console.WriteLine("Today is " + myString2);

            Console.WriteLine("I spent $" + myDouble + " on a cheesburger");

            //adventurer mode

            string[] = new string[4] { "1984", "Wealth of Nations", "The Art of War", "C: A Programming Language" };

            var person = new { firstname = "Justin", lastname = "Ellis", age = "23", nationality = "USA" };


                

            Console.WriteLine(myString1 + " marks the spot.");
            Console.ReadLine();
        }
    }
}
