using System;

namespace BatTapCSharp
{
    public class bai4
    {
        //* Nhập một số nguyên và in ra màn hình số đó là số chẵn hay lẻ.
        // "=" gan; "==" so sanh 2 gtri; "===" so sanh tat ca kieu du lieu cua gia tri
        public static void bai4Main()
        {
            Console.WriteLine("Input number: ");
            int number = int.Parse(Console.ReadLine());
            if (number % 2 == 0)
            {
                Console.WriteLine("So chan:{0}", number);
            }
            else
            {
                Console.WriteLine($"So le: {number}");
            }
        }
    }
}