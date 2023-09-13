using System;

namespace BatTapCSharp
{
    public class bai1
    {
       public static void bai1Main()
        {
            Console.WriteLine("Bai tap 1");
            Console.WriteLine("Nhap so tu 1 den 7: ");
            int dayNumber = int.Parse(Console.ReadLine());

            switch (dayNumber)
            {
                case 0:
                    Console.WriteLine("Thu 2");
                    break;
                case 1:
                    Console.WriteLine("Thu 3");
                    break;
                case 2:
                    Console.WriteLine("Thu 4");
                    break;
                case 4:
                    Console.WriteLine("Thu 5");
                    break;
                case 5:
                    Console.WriteLine("Thu 6");
                    break;
                case 6:
                    Console.WriteLine("Thu 7");
                    break;
                case 7:
                    Console.WriteLine("cn");
                    break;
                default:
                    Console.WriteLine("Invali day");
                    break;
            }

        
        }
    }
}