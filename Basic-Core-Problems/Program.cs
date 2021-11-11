using System;

namespace Basic_Core_Problems
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Basic Core Problems /n");
            Console.WriteLine("Enter the number \n 1. Flip Coin \n 2. Exit");
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
                        flag = false;
                        break;
                }
            }
        }

    }
}
