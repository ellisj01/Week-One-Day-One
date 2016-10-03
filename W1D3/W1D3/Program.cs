using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W1D3
{
    class Program
    {
        static void Main(string[] args)
        {
            bool keepLooping = true;
            while (keepLooping)
            {  Console.WriteLine("Im looping");
                Console.WriteLine("Do you want to keep looping? (y/n)");
                string answer = Console.Readline();
            if (answer.Substring(0, 1).ToLower() == "n")
                keepLooping = false;
                    }            
    }

            { }

            
        }
    }
}
