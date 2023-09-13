using System;

namespace BatTapCSharp.OOPCSharp
{
    public class daHinh
    {
        class Animal
        {
            public void MakeSound()
            {
                Console.WriteLine("Tieng Keu cua dong vat");
            }
        }

        class Cat : Animal
        {
            public void MakeSound()
            {
                Console.WriteLine("Meow Meow!");
            }
        }

        class Dog : Animal
        {
            public void MakeSound()
            {
                Console.WriteLine("Gau Gau!");
            }
        }
        
        

        public static void daHinhMain()
        {
            Animal animal = new Animal();
            Dog cho = new Dog();
            Cat meo = new Cat();
            
            animal.MakeSound();
            cho.MakeSound();
            meo.MakeSound();
        }
    }
}