using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10CountCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            // declare maxValue variable to hold max value
            int maxValue = 10;

            // use for loop for count
            for(int num = 1; num <= maxValue; num++)
            {
                Console.WriteLine(num);
                Console.ReadLine();
            }
        }
    }
}
