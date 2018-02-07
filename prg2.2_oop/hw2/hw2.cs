using System;
using System.Collections.Generic;

namespace prg2._2_oop
{
    public class hw2
    {
        public static void LeapYears()
        {
            Console.Write("Please enter a year to start from: ");
            int year = Convert.ToInt32(Console.ReadLine());
            List<int> leapYears = new List<int>();
            int[] leapYearsArray;

            while(leapYears.Count < 20)
            {
                if((year % 400 == 0) || (year % 4 == 0 && year % 100 != 0))
                {
                    leapYears.Add(year);
                }

                year++;
            }

            leapYearsArray = leapYears.ToArray();

            foreach(int k in leapYearsArray)
            {
                Console.WriteLine(k);
            }
        }
    }
}