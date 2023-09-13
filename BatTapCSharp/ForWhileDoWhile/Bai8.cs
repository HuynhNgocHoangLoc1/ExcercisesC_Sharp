using System;
using System.Runtime.Serialization.Formatters;
using System.Security;

namespace BatTapCSharp.ForWhileDoWhile
{
    public class Bai8
    {
        //(PerfectNumberCheck)Nhập vào 1 số rồi in ra màn hình số đó có phải là số hoàn hảo hay không.
        //Số hoàn hảo là số có tổng các ước số của nó bằng chính nó (6 :1 2 3    1+2+3=6 => 6 là số hoàn hảo)
        public static void Bai8Main()
        {
            int number;
            Console.Write("Input number: ");
            number = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = 1; i < number; i++)
            {
               
                if (number % i ==0)
                {
                    Console.Write(i);
                    sum = sum+i;
                }
            }
            Console.Write($"Tong = {sum}");
            if (number==sum)
            {
                Console.Write($"So hoan hao la {number}");
            }
            else
            {
                Console.Write($"ko phai la so hoan hao");
            }
        }
    }
}