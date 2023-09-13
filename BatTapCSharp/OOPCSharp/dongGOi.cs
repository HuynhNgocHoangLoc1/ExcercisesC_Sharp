using System;

namespace BatTapCSharp.OOPCSharp
{
    public class dongGOi
    {
        class Person
        {
            private string name;

            public string Name
            {
                get { return name;}
                set { name = value; }
            }
        }
        public static void voiddongGOIMain()
        {
            Person myObj = new Person();
            myObj.Name = "Loc";
            Console.WriteLine(myObj.Name);
        }
    }
}