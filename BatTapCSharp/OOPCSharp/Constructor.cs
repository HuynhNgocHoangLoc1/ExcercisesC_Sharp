using System;

namespace BatTapCSharp.OOPCSharp
{
    public class Constructor
    {
        class Car
        {
            public string color;
            public int year;
            public string car;
            
            public Car(string modleColor, int modelYear, string modelCar)
            {
                color = modleColor;
                year = modelYear;
                car = modelCar;
            }
        }
    
            public static void ClassMembersMain()
            {
                Car myObj = new Car("Blu",1986,"Audi");
              Console.WriteLine("The car is manufactured: "+myObj.year + " ,The car is: "+myObj.car+" ,The car color is: "+myObj.year);

            } 
        
    }
}