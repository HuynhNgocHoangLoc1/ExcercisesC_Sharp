using System;

namespace BatTapCSharp.ForWhileDoWhile
{
    public class bai5
    {
        public static void bai5Main()
        {
            int number;
            Console.Write("Input number: ");
            number = Int32.Parse(Console.ReadLine());
            int index = 1;
            int k = number;
            for (int i = 1; i <= number; i++)
            {
                for (int j = k; j>=1 ; j--)
                {
                    Console.Write(" ");
                }

                k--;
                
                
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(index+" ");  
                    index++;
                }
                Console.WriteLine();
            }
        }
    }
}