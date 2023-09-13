using System;

namespace BatTapCSharp
{
    public class bai2
    {
        public static void bai2Main()
        {
            //*Nhập một số bất kỳ rồi in ra tổng giá trị các chữ số của số đó(1234->1+2+3+4=10)
            Console.WriteLine("Nhap so: ");
            int numbers = int.Parse(Console.ReadLine());
            int index = 0;
            int sum = 0;
            while (numbers > 0) // Sử dụng vòng lặp while để chia các số thành từng số một
            {
                index = numbers % 10; //gán giá trị của số hàng đơn vị cho chỉ mục
                sum += index;
                numbers = numbers / 10;//Chia cho 10 bớt 1 hàng đơn vị
            }
            Console.WriteLine($"Tong cac chu so: " + sum);        }
    }
}