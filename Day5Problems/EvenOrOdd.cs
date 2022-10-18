using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5Problems
{
    public  class EvenOrOdd
    {
        public int Number;

        public EvenOrOdd(int number)
        {
            Number = number;
        }
        public void checkEvenOdd()
        {
            if (Number % 2 == 0)
            {
                Console.WriteLine(Number + " is an Even Number ");
            }
            else
            {
                Console.WriteLine(Number + " is an odd Number ");
            }
        }
    }
}
// Program to Check Whether a Number is Even or Odd
