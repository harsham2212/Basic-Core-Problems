using System;
using System.Collections.Generic;
using System.Text;

namespace Basic_Core_Problems
{
    class LeapYear
    {
        public void Check()
        {
            Console.WriteLine("Enter the Year want to check and Year should be in four digit");
            int year = Convert.ToInt32(Console.ReadLine());
            if (year % 4 == 0 && year % 100 != 0 || year % 400 == 0)
            {
                Console.WriteLine("The Year is a Leap Year: " + year);
            }
            else
            {
                Console.WriteLine("The Year is not a Leap Year: " + year);
            }
        }
    }
}

