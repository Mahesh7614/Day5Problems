using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5Problems
{
    public class LeapYear
    {
        // Declaration of Field
        public int year;

        public LeapYear (int YEAR)
        {
            this.year = YEAR;
        }
        public static LeapYear YearInput()
        {
            Console.WriteLine("Enter the Year to Check Whether Leap Year or Not : ");
            int yeartoread = Convert.ToInt32(Console.ReadLine());

            return new LeapYear(yeartoread)
            {
                year = yeartoread
            };
        }
        // Method - to check whether year is leap or not.  
        public void toCheckLeapYear()
        {
            
            if (this.year % 4 == 0)
            {
                if (this.year % 100 == 0)
                {
                    if (this.year % 400 == 0)
                    {
                        Console.WriteLine("Its a Leap Year");
                    }
                    else
                    {
                        Console.WriteLine("Its not a Leap Year");

                    }
                }
                else
                {
                    Console.WriteLine("Its a Leap Year");
                }
            }
            else
            {
                Console.WriteLine("Its not a Leap Year");
            }  
        }
    }
}
// Leap Year
