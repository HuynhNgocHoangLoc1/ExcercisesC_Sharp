using System;

namespace BatTapCSharp.ForWhileDoWhile
{
    public class bai4
    {
        public static void bai4Main()
        {
            int number;
            Console.Write("Input number: ");
            number = Int32.Parse(Console.ReadLine());
            int index = number;

            for (int i = 0; i <= number; i++)
            {
                for (int j = index; j>=1 ; j--)
                {
                    Console.Write(" ");
                    
                }

                index--;
                for (int j = 0; j <= i; j++)
                {
                    Console.Write("* ");
                }
                
                Console.WriteLine();
            }
        }
    }
}