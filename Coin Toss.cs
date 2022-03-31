using System;

namespace CSharp_Shell
{
    class CoinToss
    {
        static void Main()
        {
            /* Сторона монеты */
            byte sideOfCoin;
            
            /* Случайная сторона монеты */
            Random randomSideOfCoin = new Random();
            
            Console.Write("Введите что угодно чтобы бросить монету: ");
            Convert.ToString(Console.ReadLine());
            
            sideOfCoin = Convert.ToByte(randomSideOfCoin.Next(1, 2 + 1));
            
            if (sideOfCoin == 1)
            {
                Console.WriteLine("Орëл");
            }
            else if (sideOfCoin == 2)
            {
                Console.WriteLine("Решка");
            }
        }
    }
}