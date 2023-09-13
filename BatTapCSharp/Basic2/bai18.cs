using System;

namespace BatTapCSharp
{
    public class bai18
    {
        //(CountCharacter)Nhập chuỗi  ký tự và chuỗi ký tự cần đếm và in ra màn hình số lần xuất hiện của chuỗi cần đếm
         static string chuoi;
        public static void bai18Main()
        {
           lanXuatHienCuaChuoiCanDem();
        }

        static void lanXuatHienCuaChuoiCanDem()
        {
              
            Console.Write("Nhap chuoi: ");
            string chuoi = Console.ReadLine();
            
            int viTri = 0,lan = -1,bien = -1;
            Console.Write("Nhap chuoi con: ");
            string chuoiCon = Console.ReadLine();
            while (viTri != -1)
            {
                viTri = chuoi.IndexOf(chuoiCon, bien + 1);
                lan += 1;
                bien = viTri;
            }
            Console.Write($"{chuoiCon} da xuat hien:" + lan + " lan.");
            Console.ReadLine();
        }
        }

    }
