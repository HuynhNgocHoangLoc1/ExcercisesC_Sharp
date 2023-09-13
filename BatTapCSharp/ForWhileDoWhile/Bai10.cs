using System;

namespace BatTapCSharp.ForWhileDoWhile
{
    public class Bai10
    {
        public static void Bai10Main()
        {
            //(FindPerfectNumber)Nhập vào hai số a ,b  rồi tìm và in ra màn hình các số hoàn hảo trong khoảng đó.
            //Số hoàn hảo là số có tổng các ước số của nó bằng chính nó (6 :1 2 3    1+2+3=6 => 6 là số hoàn hảo)
            int a, b;
            Console.Write("Input a: ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Input b: ");
            b = int.Parse(Console.ReadLine());
            for (int i = a; i <= b; i++)
            {
                int sum = 0;

                for (int j = 1; j < i; j++)
                {
                    if (i % j == 0 )
                    {
                        sum = sum + j;
                    }
                }

                if (i == sum && sum !=0 )
                {
                    Console.Write(i+ " ");
                }
               
            }

        }
    }
}