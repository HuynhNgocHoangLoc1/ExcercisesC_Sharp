using System;

namespace BatTapCSharp.OOPCSharp
{
    public class keThua
    {
        class Vehicle
        {
            public void start()
            {
                Console.WriteLine("Khoi dong xe");
            }

            public void stop()
            {
                Console.WriteLine("Dung xe lai");
            }
        }


        class Car : Vehicle
        {
            public void Accelerate()
            {
                Console.WriteLine("Tang toc xe");
            }

            public void Brake()
            {
                Console.WriteLine("Phanh xe");
            }
        }
        public static void keThuaMain()
        {
            Car use = new Car();
            use.start();
            use.Accelerate();
            use.Brake();
            use.stop();
        }
    }
}