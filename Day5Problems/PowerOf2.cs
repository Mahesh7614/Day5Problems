﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5Problems
{
    public class PowerOf2
    {
        public int N;
        private int num;
        public PowerOf2(int n)
        {
            this.N = n;
        }
        public void getPowerOf2()
        {
            int a = 1;
            int b = 0;
            for (int i = 0; i < N; i++)
            {
                if (N >= 313)
                {
                    Console.WriteLine("Value is ouf of Int Limit");
                    break;
                }
                num = (2 * a);
                a = num;
                b++;
                Console.WriteLine("2 to the Power of " + b + " is : " + num);
            }
        }
    }
}
// Power of 2