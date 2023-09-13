using System;
using System.Runtime.ConstrainedExecution;

namespace BatTapCSharp
{
    public class bai14
    {
        // (Method) (string) Nhập một chuỗi ký tự ròi thực hiện các phương thức sau:
        //  Tách chuỗi thành từng ký tự riêng lẻ(ex: hello -> h e l l o)
       // Đảo ngược chuỗi ký tự đã tách ở câu trên
      //  Đếm số từ của chuỗi
      //     Đếm các số, cái chữ và các chữ cái đặc biệt trong chuỗi(!@#$%^&*)
      // //  Đếm các nguyên âm, phụ âm trong chuỗi
      //      Đếm ký tự xuất hiện nhiều nhất trong chuỗi

        static string chuoi;

        public static void bai14Main()
        {
            Console.Write("Nhap chuoi ky tu: ");
            chuoi = Console.ReadLine();
            Console.WriteLine("Chuoi vua nhap: " + chuoi);
            //kituriengle();
            //daoNguocChuoiKiTu();
            //soKiTu();
            //demSoChuKiTuDacBiet();
            //nguyenAm_phuAm();
            kyTuXuatHienNhieuNhat();
            
        }

       static void kituriengle()
        {
            Console.Write("Chuoi sau khi tach: ");
            /*int i = 0;
            while (i < chuoi.Length)
            {
                Console.Write(chuoi[i]+" ");
                i++;
            }
            Console.WriteLine();*/
            for (int i = 0 ; i<chuoi.Length; i++)
            {
                Console.Write(chuoi[i]+ " ");
            }
        }

       static void daoNguocChuoiKiTu()
       {
            Console.Write("Chuoi sau khi dao nguoc: ");
            for (int i =chuoi.Length -1 ; i >=0; i--)
            {
                Console.Write(chuoi[i]);
            }
       }

       static void soKiTu()
       {
           int bienDem = 1;
           int l = 0;
           while (l<=chuoi.Length-1)
           {
               if (chuoi[l] == ' ' || chuoi[l] == '\n' || chuoi[l] == '\t')
               {
                   bienDem++;
               }

               l++;
           }
           Console.Write("\nSo tu cua chuoi la: {0}", bienDem);

       }

       static void demSoChuKiTuDacBiet()
       {
          int l = chuoi.Length;
           int i, chu_cai, chu_so, ky_tu_dac_biet;
              chu_cai = chu_so = ky_tu_dac_biet = i = 0;
           // Dung While
                  /*while (i < l)
                 {
                     if ((chuoi[i] >= 'a' && chuoi[i] <= 'z') || (chuoi[i] >= 'A' && chuoi[i] <= 'Z'))
                     {
                         chu_cai++;
                     }
                     else if (chuoi[i] >= '0' && chuoi[i] <= '9')
                     {
                         chu_so++;
                     }
                     else
                     {
                         ky_tu_dac_biet++;
                     }
      
                     i++;
                 }
      
                 Console.Write("So chu cai trong chuoi la: {0}\n", chu_cai);
                 Console.Write("So chu so trong chuoi la: {0}\n", chu_so);
                 Console.Write("So ky tu dac biet trong chuoi la: {0}\n\n", ky_tu_dac_biet);*/
//use for
                  for ( i = 0; i<=chuoi.Length;i++)
                  {
                      if ((chuoi[i] >= 'a' && chuoi[i] <= 'z') || (chuoi[i] >= 'A' && chuoi[i] <= 'Z'))
                      {
                          chu_cai++;
                      }
                      else if (chuoi[i] >= '0' && chuoi[i] <= '9')
                      {
                          chu_so++;
                      }
                      else
                      {
                          ky_tu_dac_biet++;
                      }
                  }
                  Console.Write("So chu cai trong chuoi la: {0}\n", chu_cai);
                  Console.Write("So chu so trong chuoi la: {0}\n", chu_so);
                  Console.Write("So ky tu dac biet trong chuoi la: {0}\n\n", ky_tu_dac_biet);
       }

       static void nguyenAm_phuAm()
       {
           int nguyenAm, phuAm;
           nguyenAm = phuAm = 0;
           for (int i = 0; i < chuoi.Length; i++)
           {
               if (chuoi[i] >= 'u' ||  chuoi[i] <= 'e' ||  chuoi[i] <= 'o'||  chuoi[i] <= 'a'||  chuoi[i] <= 'i')
               {
                   nguyenAm++;
               }
               else
               {
                   phuAm++;
               }
           }
           Console.Write("nguyen am trong chuoi la: {0}\n", nguyenAm);
           Console.Write("phu am trong chuoi la: {0}\n", phuAm);

       }

       static void kyTuXuatHienNhieuNhat()
       {
           int a = 0;
           int max = 0;
           for (int i = 0; i < chuoi.Length - 1; i++)
           {
               int index = 0;
               for (int j = i + 1; j < chuoi.Length; j++)
               {
                   if(chuoi[i]==chuoi[j])
                   index++;
               }

               if (index > max)
               {
                   max = index + 1;
                   a = i;
               }
           }
           Console.WriteLine($"Ky tu {chuoi[a]} xuat hien {max} lan");
       }
    }
    }