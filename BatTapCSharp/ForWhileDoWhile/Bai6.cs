using System;

namespace BatTapCSharp.ForWhileDoWhile
{
    public class Bai6
    {
        public static void Bai6Main()
        {
            int number;
            Console.Write("Input number: ");
            number = Int32.Parse(Console.ReadLine());
            int index = number;
                
            for (int i = 1; i <= number; i++)
            {
                for (int j = index; j>=1 ; j--)
                {
                    Console.Write(" ");
                    
                }

                index--;
                for (int j = 1; j <= 2 * i - 1; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            
            
        }
    }
}