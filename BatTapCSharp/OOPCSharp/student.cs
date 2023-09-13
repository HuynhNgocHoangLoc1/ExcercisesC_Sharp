using System;
using System.CodeDom;
using Newtonsoft.Json;

namespace BatTapCSharp.OOPCSharp
{
    public class student
    {
        class Student
        { 
            private string name;
            private string email;
            private int age;
            private int clas;

        public Student(string name, string email, int age, int clas)
        {
            this.name = name;
            this.email = email;
            this.age = age;
            this.clas = clas;
        }

        public void SetAge(int newAge)
        {
            if (newAge < 0)
            {
                Console.WriteLine("Tuoi ko hop le");
            }
            else
            {
                age = newAge;
            }
        }

        public int GetAge()
        {
            return this.age;
        }


        public void SetName(string newName)
        {
            if (newName.Length > 0 && newName.Length <= 20)
            {
                this.name = newName;
            }
            else
            {
                Console.WriteLine("Ten khong hop le");
            }
        }

        public string GetName()
        {
            return this.name;
        }

        
        public void SetClass(int newClass)
        {
            if (newClass > 0 && newClass <= 100)
            {
                this.clas= newClass;
            }
            else
            {
                Console.WriteLine("Class ko hop le");
            }
        }

        public int GetClass()
        {
            return this.clas;
        }
    }
        
        public static void studentMain()
        {
            Student ten = new Student("Huynh Ngoc Hoang Loc", "Loc@xmail.com", 55, 1001);
            ten.SetAge(21);
            Console.WriteLine(ten.GetAge());
            
            ten.SetName("Hoang Loc");
            Console.WriteLine(ten.GetName());
                
            ten.SetClass(99);
            Console.WriteLine(ten.GetClass());
        }
    }
}