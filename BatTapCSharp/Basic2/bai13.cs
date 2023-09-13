using System;
using System.Linq;
using System.Net.Sockets;
using System.Reflection;

namespace BatTapCSharp
{
    public class bai13
    {
        // * (Array) Cho một mảng string bất kỳ cho trước:
        //   In ra màn hình mảng đó
        //   Cho một mảng số tự nhiên bất kì rồi in ra độ dài của mảng, in ra số lớn nhất, nhỏ nhất, và tổng giá trị của mảng
        
        

        public static void bai13Main()
        {
            string[] ten = new string[4] {"Loc","Huy","Hoang","Phuoc"};
          
            for (int i = 0; i<4; i++)
            {
                Console.WriteLine(ten[i]);
            }

            
            int[] numbers = new int[5] { 1, 2, 3, 4, 5 };
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(numbers[i]);
            }
            Console.WriteLine($"Max: {numbers.Max()}");
            Console.WriteLine($"Min: {numbers.Min()}");
            Console.WriteLine($"Sum: {numbers.Sum()}");
        }
    }
}