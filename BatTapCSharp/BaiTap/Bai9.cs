using System;

namespace BatTapCSharp
{
    public class Bai9
    {
        public static void Bai9Main()
        {
            Console.Write("Nhap so nguyen a: ");
            int a = int.Parse(Console.ReadLine());
        
            Console.Write("Nhap so nguyen b: ");
            int b = int.Parse(Console.ReadLine());
        
            Console.Write("Nhap so nguyen c: ");
            int c = int.Parse(Console.ReadLine());
        
            int delta = b * b - 4 * a * c;
        
            if (delta < 0)
            {
                Console.WriteLine("Phuong trinh vo nghiem");
            }
            else if (delta == 0)
            {
                double x = -b / (2.0 * a);
                Console.WriteLine("Phuong trinh co nghiem kep: x = {0}", x);
            }
            else
            {
                double x1 = (-b + Math.Sqrt(delta)) / (2.0 * a);
                double x2 = (-b - Math.Sqrt(delta)) / (2.0 * a);
                Console.WriteLine("Phuong trinh co 2 nghiem phan biet: x1 = {0}, x2 = {1}", x1, x2);
            }
        }
        }
    }
