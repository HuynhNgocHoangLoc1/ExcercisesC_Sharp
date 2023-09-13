using System;
using BatTapCSharp.ThamChieu_Thamtri;
using Newtonsoft.Json;
namespace BatTapCSharp
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int a = 5;
            ThamTri.binhphuongMain(a);
            ThamChieu.ThamChieuMain(ref a);
            ThamChieu.ThamChieuMain(ref a);
            ThamChieu.ThamChieuMain(ref a);
            Console.WriteLine(a);
        }
    }
}
