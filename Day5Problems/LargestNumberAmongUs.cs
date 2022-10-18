using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5Problems
{
    public class LargestNumberAmongUs
    {
        public int Num1, Num2, Num3;

        public LargestNumberAmongUs(int num1, int num2, int num3)
        {
            Num1 = num1;
            Num2 = num2;
            Num3 = num3;
        }
        public void CalculateLargestNumber()
        {
            if (Num1 > Num2 && Num1 > Num3)
            {
                Console.WriteLine(Num1 + " is Largest Amoung All");
            }
            else if (Num2 > Num1 && Num2 > Num3)
            {
                Console.WriteLine(Num2 + " is Largest Amoung All");
            }
            else
            {
                Console.WriteLine(Num3 + " is Largest Amoung All");
            }
        }
    }
}
// Program to Find the Largest Among Three Numbers