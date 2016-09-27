using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W1D2
{
    class Program
    {
        static void Main(string[] args)
        {
            int temp = new int();
            temp = 5;
            double[] myArray = new double[9] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            for (int i = 0; i < myArray.Length; i++)        
                
            {
                Console.WriteLine(myArray[i]);
            }
            Console.ReadLine();
        }
    }
}
