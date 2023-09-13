using System;

namespace BatTapCSharp.ForWhileDoWhile
{
    public class bai3
    {
        public static void bai3Main()
        {
            int number;
            Console.Write("Input number: ");
            number = Int32.Parse(Console.ReadLine());
            int index = 1;

            for (int i = 1; i <= number; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(index);
                    index++;
                }
                Console.WriteLine();
            }
        }
    }
}