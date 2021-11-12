using System;
using System.Collections.Generic;
using System.Text;

namespace Basic_Core_Problems
{
    class LargestInThreeNumber
    {
        public void CheckNumbers()
        {
            Console.Write("Enter the 1st number :");
            int numOne = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the 2nd number :");
            int numTwo = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the 3rd Number :");
            int numThree = Convert.ToInt32(Console.ReadLine());


            if (numOne > numTwo && numOne > numThree)
                Console.WriteLine($"number {numOne} is maximum");
            else if (numTwo > numOne && numTwo > numThree)
                Console.WriteLine($"number {numTwo} is maximum");
            else
                Console.WriteLine($"number  {numThree} is maximum");
        }
    }
}
