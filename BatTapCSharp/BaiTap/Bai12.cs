using System;

namespace BatTapCSharp
{
    public class Bai12
    {
        public static void Bai12Main()
        {
            //Nhập một số nguyên rồi in ra màn hình số đó có phải là số nguyên tố hay không
            Console.WriteLine("Nhap 1 so nguyen: ");
            int number = int.Parse(Console.ReadLine());


            int index = 0; // index "Bien dem cac so chia"
            
            for (int i = 1; i <= number; i++)
            {
                if (number % i == 0 )
                {
                    //index = index + 1;
                    //index += 1;
                    index ++;
                    
                }
            }
                
            Console.Write(index == 2 ? "La so nguyen to" : "KO phai so Nto'");
            /*
            if (index == 2)
            {
                Console.WriteLine($"So nay la so nguyen to: {number}");
            }
            else
            {
                Console.WriteLine($"ko phai la so nguyen to: {number}");
            }*/
            
        }
    }
}