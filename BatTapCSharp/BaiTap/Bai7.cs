using System;
using System.Diagnostics.SymbolStore;

namespace BatTapCSharp
{
    public class Bai7
    {
        // (switch)Nhập số a  rồi in ra màn hình từng trường hợp cộng, trừ,nhân,chia, chia có dư  (ex: 1:/,2:*,3:+,4:-,..) cho  phép tính rồi nhập số b và in ra màn hình phép tính đó.

        /*
        int a;
        (1:/,2:*,0:/)*/

        public static void Bai7Main()
        {
            int a, b, chon;
            Console.Write("nhap a: ");
            a = int.Parse(Console.ReadLine());
            Console.Write("nhap phep tinh(1:/,2:*,3:+,4:-,5:%): ");
            chon =int.Parse( Console.ReadLine());

            switch (chon)
            {
                case 1:
                    Console.WriteLine("Nhap b: ");
                    b = int.Parse(Console.ReadLine());
                    double thuong = (double)a / b;
                    thuong = Math.Round(thuong, 2); // "Round" Lam` tron .
                    Console.WriteLine($"phep chia cua {a} va {b} la {thuong}");
                    break;
                case 2:
                    Console.Write("Nhap b: ");
                    b = int.Parse(Console.ReadLine());
                    Console.Write($"phep nhan cua {a} va {b} la {a*b}");
                    break;
                case 3:
                    Console.Write("Nhap b: ");
                    b = int.Parse(Console.ReadLine());
                    Console.Write($"phep cong cua {a} va {b} la {a+b}");
                    break;
                case 4:
                    Console.Write("Nhap b: ");
                    b = int.Parse(Console.ReadLine());
                    Console.Write($"phep tru cua {a} va {b} la {a-b}");
                    break;
                case 5:
                    Console.Write("Nhap b: ");
                    b = int.Parse(Console.ReadLine());
                    Console.Write($"phep chia lay du cua {a} va {b} la {a%b}");
                    break;

                
            }
        }
    }
}