using System;

namespace BatTapCSharp.ForWhileDoWhile
{
    public class bai1
    {
        public static void bai11Main()
        {
            int number;
            Console.Write("Input number: ");
            number = int.Parse(Console.ReadLine());

            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <=i; j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
        }
    }
}