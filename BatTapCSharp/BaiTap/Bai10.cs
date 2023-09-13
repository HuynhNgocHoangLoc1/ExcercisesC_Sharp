using System;
using System.Globalization;

namespace BatTapCSharp
{
    public class Bai10
    {
        public static void Bai10Main()
        {
            Console.WriteLine("Nhap a: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap b: ");
            int b = int.Parse(Console.ReadLine());

            if (a == b && b == 0)
            {                                                                                                                                                                                                                                            
                Console.WriteLine("Ko co' UCLN va BCNN");
            }
            else if(a==0 || b==0)
            {
                Console.WriteLine("Ko the co BCNN");
                if (a == 0)
                {
                    // a= 0 & b= 12 ==) UClN = 12;
                    // 12 = 1,2,3,4,6,12.
                    
                    Console.WriteLine($"UCLN la {b}");
                }
                else
                {
                    Console.WriteLine($"UCLN la {a}");
                }
            }
            else
            {
                int uocChung = 1;
                // 4 = 1,2,4
                // 6 = 1,2,3,6 
                
                for ( int i =1; i <= a && i<= b ;i++)
                {
                    
                    if (a % i == 0 && b % i ==0)
                    {
                        uocChung = i;
                    }

                }
                Console.WriteLine($"UCLN la: {uocChung}");
                Console.WriteLine($"BCNN la: {a * b / uocChung}");
            }
        }
    }
}