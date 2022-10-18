using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5Problems
{
    public class QuotientNdRemainder
    {
        public int dividend;
        public int divisor;

        public QuotientNdRemainder(int dividend, int divisor)
        {
            this.dividend = dividend;
            this.divisor = divisor;
        }
        public void Calculation()
        {
            int quotient = dividend / divisor;
            int remainder = dividend % divisor;

            Console.WriteLine("Quotient is : " + quotient);
            Console.WriteLine("Remainder is : " + remainder);
        }
    }
}
// Program to Compute Quotient and Remainder