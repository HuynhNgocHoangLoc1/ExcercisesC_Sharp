using System;

namespace BatTapCSharp.ForWhileDoWhile
{
    public class Bai9
    {
        public static void Bai9Main()
        {
            //Nhập vào hai số a,b rồi in ra màn hình những số nguyên tố nằm trong khoảng đó.

            Console.WriteLine("Start: ");
            int number1 = int.Parse(Console.ReadLine());
            Console.WriteLine("End: ");
            int number2 = int.Parse(Console.ReadLine());

       

            /*for (int i = 2; i >= number1 && i <= number2; i++)
            {
                
            }*/
            for (int i = number1; i < number2; i++)
            {
                int index = 0;

                for (int j = 1; j<=i; j++)
                {
                    if (i % j ==0)
                    {
                        index++;
                    }
                }

                if (index == 2)
                {
                    Console.Write(i+" ");
                }
                
            }
        }
    }
}