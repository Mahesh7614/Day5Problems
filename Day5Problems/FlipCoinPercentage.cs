using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5Problems
{
    public class FlipCoinPercentage
    {
        public int Times;

        public FlipCoinPercentage(int times)
        {
            this.Times = times;
        }
        public void getPercentageOfFlipCion()
        {
            float count1 = 0;
            float count2 = 0;
            for (int i = 1; i <= Times; i++)
            {
                Random random = new Random();
                int Flip = random.Next(0, 2);

                if (Flip == 0)
                {
                    Console.WriteLine("HEAD");
                    count1++;
                }
                else if (Flip == 1)
                {
                    Console.WriteLine("TAILS");
                    count2++;
                }

            }
            double Percentage = (count1 / count2) * 100;
           // Console.WriteLine("Percentage of Head vs Tail is : " + Percentage);
            Console.WriteLine("Percentage of Head vs Tail is : " + (Math.Round(Percentage, 2)));
        }
    }
}
// Flip Coin and print percentage of Heads and Tails