using System;
using System.Collections.Generic;
using System.Text;

namespace Basic_Core_Problems
{
    class EvenOdd
    {
        public void Checkevenodd()
        {
            Console.WriteLine("Enter the number");
            int num = Convert.ToInt32(Console.ReadLine());
            if (num == 0)
            {
                Console.WriteLine("Number should be greater tha Zero");
            }
            if (num % 2 == 0)
            {
                Console.WriteLine("Number is Even");
            }
            else
                Console.WriteLine("Number is Odd");
        }
    }
}
