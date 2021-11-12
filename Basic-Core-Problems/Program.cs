using System;

namespace Basic_Core_Problems
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Basic Core Problems /n");
            Console.WriteLine("Enter the number \n 1. Flip Coin \n 2. Leap Year \n 3.Power of Two \n 4.Harmonic Number \n 5.Factors \n 6.Quotient and Remainder \n 7. Swap Number \n 8. Exit");
            int option = Convert.ToInt32(Console.ReadLine());
            bool flag = true;
            while (flag)
            {
                switch (option)
                {
                    case 1:
                        FlipCoin coin = new FlipCoin();
                        coin.Flip();
                        break;
                    case 2:
                        LeapYear leap = new LeapYear();
                        leap.Check();
                        break;
                    case 3:
                        PowerofTwo store = new PowerofTwo();
                        store.Power();
                        break;
                    case 4:
                        HarmonicNum sum = new HarmonicNum();
                        sum.Harmonic();
                        break;
                    case 5:
                        Factors fc = new Factors();
                        fc.Calculate();
                        break;
                    case 6:
                        Remainder val = new Remainder();
                        val.Calculation();
                        break;
                    case 7:
                        Swapping ans = new Swapping();
                        ans.Swap();
                        break;
                    case 8:
                        flag = false;
                        break;
                }
            }
        }

    }
}
