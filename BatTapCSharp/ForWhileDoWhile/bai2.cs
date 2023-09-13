using System;

namespace BatTapCSharp.ForWhileDoWhile
{
    public class bai2
    {
        public static void bai2Main()
        {
            int number;
            Console.Write("Input number: ");
            number = Int32.Parse(Console.ReadLine());

            for (int i = 1; i <= number; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(i);
                }
                Console.WriteLine();
            }
            
        }
    }
}