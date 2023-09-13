using System;

namespace BatTapCSharp
{
    public class bai3
    {
        //* Nhập vào  tên, tuổi ,email,cân nặng, chiều cao, rồi in ra màn hình  những thông tin đó,
        //và bao gồm  cả chỉ số  bmi=(cân nặng (kg)/(chiều cao(cm))^2)*10000, và đang trong mối quan hệ hay không (true/false)
        public static void bai3Main()
        {
            string name, email;
            
            int age, weight, height;
            bool relationship;
            float bmi;


            Console.WriteLine("Input name: ");
           name = Console.ReadLine();
            
            Console.WriteLine("Input Age: ");
             age = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Input email: ");
            email = Console.ReadLine();
            
            Console.WriteLine("Input Weight: (kg)");
            weight = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Input Height: (cm)");
            height = int.Parse(Console.ReadLine());

            
            Console.WriteLine("Input relationship: (true/false)");
            relationship = bool.Parse(Console.ReadLine());

            bmi = (float)weight / (height * height) * 10000;
           
            Console.WriteLine(" ");

            Console.WriteLine("Name: " + name);
            Console.WriteLine("Email: " + email);
            Console.WriteLine("Age : " + age);
            Console.WriteLine("Weight (kg): " + weight );
            Console.WriteLine("height (cm) : " + height );
            Console.WriteLine("bmi : " + bmi );
            Console.WriteLine("In a Relationship "+ relationship);

        }
    }
}