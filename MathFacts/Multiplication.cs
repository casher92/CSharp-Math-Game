using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathFacts
{
    class Multiplication
    {
        public void MultiplyTable()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            string appTitle = @" ,__ __           _              _                                   
/|  |  |         | | o          | | o                o               
 |  |  |         | |   _|_   _  | |     __   __, _|_     __   _  _   
 |  |  |  |   |  |/  |  |  |/ \_|/  |  /    /  |  |  |  /  \_/ |/ |  
 |  |  |_/ \_/|_/|__/|_/|_/|__/ |__/|_/\___/\_/|_/|_/|_/\__/   |  |_/
                          /|                                         
\|                                         
 ______    _    _      
(_) |     | |  | |     
    | __, | |  | |  _  
  _ |/  | |/ \_|/  |/  
 (_/ \_/|_/\_/ |__/|__/";

            Console.WriteLine(appTitle);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("You will be able to select a starting number and an ending number between 1 - 10");
            Console.WriteLine("Next you will see the numbers between these selections multiplied");
            Console.WriteLine("to numbers 1 - 10");
            Console.WriteLine("");
            Console.WriteLine("Select a starting number between 1 and 10");
        }

        public void MultiplyChart(int startNum, int endNum)
        {
            for (int i = startNum - 1; i <= endNum; i++)
            {
                if (i == startNum - 1)
                {
                    Console.Write(String.Format("{0, 6}", "n"));
                }
                else
                {
                    Console.Write(String.Format("{0, 6}", i));
                }


            }
            Console.WriteLine("\n");

            for (int i = 1; i <= 10; i++)
            {
                Console.Write(String.Format("{0, 6}", i));
                for (int b = startNum; b <= endNum; b++)
                {
                    string output = String.Format("{0, 6}", i * b);
                    Console.Write(output);
                }
                Console.WriteLine("");

            }
        }
    }
}
