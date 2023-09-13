using System;

namespace BatTapCSharp
{
    public class bai15
    {
        //(Method2)(String)  Nhập một chuỗi ký tự cho sẵn “Greenwich’s Club of Developers” rồi thực hiện những phương thức sau:
       // Đảo ngược chuỗi đã cho
           // In chuỗi đã cho thành in thường và in hoa
          //  Cắt chuỗi và in ra “Club” in chuỗi đã cho
           // Đếm số lần xuất hiện của ‘e’ và in màn hình

        static string chuoi;
        public static void bai15Main()
        {
            chuoi = "Greenwich’s Club of Developers";
            
            //daoNguocChuoi();
           // inThuongVaInHoa();
            // catChuoiVainRaChuoi();
            demSoLanXuatHienCuaKiTuE();
            //string daochuoi = Reserve(chuoi);
            //Console.WriteLine("\nDao nguoc chuoi: " +daochuoi);
        }

        /*static void daoNguocChuoi()
        {
           Console.Write("Chuoi sau khi bi dao nguoc: ");
            (int i = chuoi.Length-1; i >=0  ; i--)
          {
              Console.Write(chuoi[i]);
          }
        }*/
        public static string Reserve(string index)
        {
            char[] arr = index.ToCharArray();
            Array.Reverse(arr);
            return new string(arr);
        }

        static void inThuongVaInHoa()
        {
            /*char ch;
            char[] arr1;
            arr1 = chuoi.ToCharArray(0, chuoi.Length); // chuyen chuoi thanh mang ky tu.  

            Console.Write("\nSau khi chuyen doi, chuoi co dang: ");
            for (int i = 0; i < chuoi.Length; i++)
            {
                ch = arr1[i];
                if (Char.IsLower(ch)) // kiem tra ky tu thuong  
                    Console.Write(Char.ToUpper(ch)); // chuyen doi chu thuong thanh chu hoa.  
                else
                    Console.Write(Char.ToLower(ch)); // chuyen doi chu hoa thanh chu thuong.  
            } */
            //In thường chuỗi
            Console.WriteLine("In thuong: " +chuoi.ToLower());
            //In hoa chuỗi
            Console.WriteLine("In hoa: "+chuoi.ToUpper());
        }
   

        static void catChuoiVainRaChuoi()
        {
            Console.WriteLine("Moi: " + chuoi.Substring(12,4));// Truy xuất một chuỗi con từ trường hợp này.
                                                                            // Chuỗi con bắt đầu tại một vị trí ký tự xác định và có độ dài xác định.
        }

        static void demSoLanXuatHienCuaKiTuE() 
        {
            
            int viTri = 0;
            int lan = -1;
            int idx = -1;
            char solan = 'e';
            
            while (viTri != -1)
            {
                viTri =chuoi.IndexOf(solan, idx + 1);//Sử dụng IndexOf để tìm vị trí cụ thể của e
                lan += 1;
                idx = viTri;
            }
            Console.Write(lan);
        }
        }
    } 
