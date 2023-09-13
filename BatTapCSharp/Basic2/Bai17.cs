using System;

namespace BatTapCSharp
{
    public class Bai17
    {
        //(Datetime) Nhập vào ngày,tháng,năm rồi in ra màn hình  format {dddd}:
            //  In ra màn hình ngày thứ  1000 ngày  sau ngày đã nhập
           // In ra màn hình ngày thứ 100 năm sau ngày nhập
          // In ra màn hình “Khó quá”

        public static void Bai17Main()
        {
            Console.Write("Enter day: ");
            int day = int.Parse(Console.ReadLine());
            Console.Write("Enter month: ");
            int month = int.Parse(Console.ReadLine());
            Console.Write("Enter Year: ");
            int year = int.Parse(Console.ReadLine());

            DateTime date = new DateTime(year, month,day);

            DateTime after1000Day = date.AddDays(1000);
            string day1000 = after1000Day.ToString("dddd");
            Console.WriteLine("After 1000 days: "+ day1000+ "(" + after1000Day.ToString("yyyy MMMM dd")+ ")");
            
            DateTime after100Year = date.AddYears(100);
            string year100 = after100Year.ToString("dddd");
            Console.WriteLine("After 100 year: "+ year100+ "(" + after100Year.ToString("yyyy MMMM dd")+ ")");
            
            /*
            Console.WriteLine("{0:dddd}", newday);
        */
        }
    }
}