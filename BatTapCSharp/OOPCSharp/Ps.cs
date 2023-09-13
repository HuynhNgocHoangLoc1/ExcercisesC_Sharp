using System;

namespace BatTapCSharp.OOPCSharp
{
    public class Ps
    {
        private string id, name;

        public Ps()
        {
        }

        public Ps(string id, string name)
        {
            this.id = id;
            this.name = name;
        }

        public void SetId(string newId)
        {
            this.id = newId;
        }

        public string GetId()
        {
            return this.id;
        }

        public void SetName(string newName)
        {
            name = newName;
        }

        public string GetName()
        {
            return name;
        }

        public void Display()
        {
            Console.WriteLine(id + " " + name +" ");
        }

        public void Nhap()
        {
            Console.WriteLine("Enter id: ");
            Console.ReadLine();
            Console.WriteLine("Enter Name: ");
            
        }
        public static void PsMain()
        {
            
        }
    }
}