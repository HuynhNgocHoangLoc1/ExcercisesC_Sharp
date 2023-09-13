using System;

namespace BatTapCSharp
{
    public class bai16
    {
        //(ElectricityBill)Tính bill tiền điện. Nhập vào id ,tên khách hàng, số chữ điện đã dùng rồi in ra màn hình số tiền phải trả.
        //Giá tiền điện theo chữ điện: dưới 199 là 1,2$ ,200-399 là 1,5$ ,400-599 là 1,8$ , trên 600 là 2$ nếu số chữ điện lớn hơn 400 thì sẽ phụ thu 15%
        public static void bai16Main()
        {
            int id, soChuDien;
            string name;
            Console.Write("Enter id: ");
            id = int.Parse(Console.ReadLine());
            Console.Write("Enter name: ");
            name = Console.ReadLine();
            Console.Write("Enter SoChuDien: ");
            soChuDien = int.Parse(Console.ReadLine());

            double giaTienDien;

            if (soChuDien < 199)
            {
                giaTienDien = soChuDien* 1.2;
            }
            else if (soChuDien>200 && soChuDien<399)
            {
                giaTienDien = soChuDien* 1.5;
            }else if (soChuDien>400 && soChuDien<599)
            {
                giaTienDien = soChuDien *1.8;
            }
            else
            {
                giaTienDien = soChuDien*2;
            }

            if (soChuDien > 400)
            {
                giaTienDien =  giaTienDien + (giaTienDien * 0.15); // Phụ thu 15%
            }


            Console.WriteLine("Thong tin");
            Console.WriteLine("ID: " + id);
            Console.WriteLine("Ten: " + name);
            Console.WriteLine("So chu dien da su dung: " + soChuDien);
            Console.WriteLine("So tien phai tra: $" + giaTienDien);
            
            }
    }
}