using System;

namespace BatTapCSharp
{
    public class Bai8
    {
        //Cho tam giác ABC nhập lần lượt 3 cạnh của tam giác rồi in ra màn hình tam giác đó là tam giác gì (cân, đều ,thường)

        public static void Bai8Main()
        {
           
            Console.WriteLine("Nhap a: ");
            int a = int.Parse(Console.ReadLine()); //AB= a, AC= b, BC=c.
                                                
            Console.WriteLine("Nhap b: ");
            int b = int.Parse(Console.ReadLine());
         
            Console.WriteLine("Nhap c: ");
            int c = int.Parse(Console.ReadLine());

            int tong = b + c;
            
            int hieu = Math.Abs(b-c);
            if (tong>a && hieu<a)
            {
                if (a == b && b == c)
                {
                 Console.WriteLine($"Tam giac deu");   
                }
                else if(a == b && b != c)
                {
                    Console.WriteLine("Tam giac can tai A:");//AB= a, AC= b, BC=c.
                }   
                else if(a == c && b != c)
                {
                    Console.WriteLine("Tam giac can tai B:"); 
                }   else if(c == b && b != a)
                {
                    Console.WriteLine("Tam giac can tai C:");
                }
                else
                {
                    Console.WriteLine("Tam giac thuong");
                }
            }
            else
            {
                Console.WriteLine("Ko phai la Tam giac");
            }
        }
    }
}