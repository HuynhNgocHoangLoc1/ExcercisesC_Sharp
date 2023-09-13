using System;

namespace BatTapCSharp.ForWhileDoWhile
{
    public class Bai7
    {
        public static void Bai7Main()
        {
            int number;
            Console.Write("Input number: ");
            number = Int32.Parse(Console.ReadLine());
            int index = number;
            
            for (int i = 1; i <= number; i++)
            {
                for (int j = index; j>=2 ; j--)
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

            for (int i = number-1; i >= 1; i--)
            {
                for (int j = i;  j<= number-1; j++)
                {
                    Console.Write(" ");
                }
                
                for (int j = 2*i-1 ; j >=1 ;j--)
                {
                    Console.Write("*");
                }
                
                Console.WriteLine();
            }
        }
    }
}