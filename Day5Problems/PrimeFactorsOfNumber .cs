using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5Problems
{
    public class PrimeFactorsOfNumber
    {
        private int Factor;
        public int Number;
        public PrimeFactorsOfNumber(int NUMBER)
        {
            this.Number = NUMBER;
        }

        public void PrimeFactors()
        {
            for (Factor = 2; Number > 1; Factor++)
            {
                if (Number % Factor == 0)
                {
                    int Times = 0;
                    while(Number % Factor == 0)
                    {
                        Number = Number / Factor;
                        Times++;
                    }
                    Console.WriteLine(Factor + " is Prime Factor " + Times + " times ");
                }
            }
        }
    }
}
// Factors

