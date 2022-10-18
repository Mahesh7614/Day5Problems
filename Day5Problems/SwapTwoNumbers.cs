using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5Problems
{
    public class SwapTwoNumbers
    {
        public int Number1;
        public int Number2;

        public SwapTwoNumbers(int number1, int number2)
        {
            Number1 = number1;
            Number2 = number2;
        }
        public void SwappingOfTwoNumbers()
        {
            int Number3 = Number1;
            Number1 = Number2;
            Number2 = Number3;
            
            Console.WriteLine("Number 1 is : " + Number1);
            Console.WriteLine("Number 2 is : " + Number2);
        }
    }
}
// Program to Swap Two Numbers