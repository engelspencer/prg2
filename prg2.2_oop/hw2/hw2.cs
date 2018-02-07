using System;

namespace prg2._2_oop
{
    public class hw2
    {
        public static void LeapYear()
        {
            Console.Write("Please enter a year: ");
            int year = Convert.ToInt32(Console.ReadLine());
            bool isLeapYear;

            if((year % 400 == 0) || (year % 4 == 0 && year % 100 != 0))
            {
                isLeapYear = true;
            }
            else
            {
                isLeapYear = false;
            }

            Console.WriteLine(isLeapYear);
        }

        public void run()
        {
            LeapYear();
        }
    }
}