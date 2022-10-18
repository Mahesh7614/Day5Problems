using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5Problems
{
    public class HarmonicNumber
    {
        public double n;
        private double value = 0.0;

        public HarmonicNumber(double N)
        {
            this.n = N;
        }

        public void harmonicSeries()
        {
            for (int i = 1; i <= n; i++)
            {
                value += 1 / (float)i;
            }
            Console.WriteLine(value);
            Console.WriteLine("Sum of n Numbher of Hrmonic series is " + value);
        }
    }
}
// Harmonic Number
