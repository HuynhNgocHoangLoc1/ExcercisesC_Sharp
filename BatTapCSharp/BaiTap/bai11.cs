using System;

namespace BatTapCSharp
{
    public class bai11
    {
        public static void bai11Main()
        {
            //Nhập 1 số nguyên rồi in ra màn hình các số nguyên tố nhỏ hơn nó.
            Console.WriteLine("Nhap so: ");
            int number = int.Parse(Console.ReadLine());
            int index = 2;
            while ( index < number)
            {  
             
                bool nguyenTo = true;

                if(number < 2 )
                {
                    nguyenTo = false;
                }
                else
                {
                    int i = 2;
                    while (i <= Math.Sqrt(index))
                    {
                        if (index % i == 0)
                        {
                            nguyenTo = false;
                            break;
                        }

                        i++;
                        /*i += 1; 
                        i = i +1;*/
                        
                    }    
                }

                if (nguyenTo)
                {
                    Console.Write(index + " ");
                }

                index++;
            }
            
            
        }
    }
}