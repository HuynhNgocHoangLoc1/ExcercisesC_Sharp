using System;

namespace BatTapCSharp.ThamChieu_Thamtri
{
    public class ThamChieu
    {
        //tham trị là cách thức mặc định, ta đã sử dụng ở phần trên. Có nghĩa là gán tham số bằng một biến, thì giá trị của biến được copy và sử dụng trong phương thức như biến cục bộ, còn bản thân biến bên ngoài không hề ảnh hưởng.
        //tham chiếu thì bản thân biến ở tham số sẽ được hàm sử dụng trực tiếp (tham chiếu) chứ không tạo ra một biến cục bộ trong hàm, nên nó có tác động trực tiếp đến
            //biến này bên ngoài. Để sử dụng được tham chiếu thì khai báo tham số ở phương thức, cũng như khi gọi cần cho thêm từ khóa ref
        public static void ThamChieuMain(ref int x)
        {
            x = x * x;
            Console.WriteLine(x);
        }
    }
}   