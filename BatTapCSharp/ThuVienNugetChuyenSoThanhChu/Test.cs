﻿using System;
using Newtonsoft.Json;

namespace BatTapCSharp.ThuVienNugetChuyenSoThanhChu
{
    public class Test
    {

        class Product
        {
            public string Name { get; set; }
            public DateTime Expiry { get; set; }
            public string[] Sizes { get; set; }
            
            
        }
        public static void TestMain()
        {
            
            
            
            
            
            
            
            
            
            /*Product product = new Product();
            product.Name = "Apple";
            product.Expiry = new DateTime(2008, 12, 28);
            product.Sizes = new string[] { "Small" };

            string json = JsonConvert.SerializeObject(product);
            Console.WriteLine(json);*/
// {
//   "Name": "Apple",
//   "Expiry": "2008-12-28T00:00:00",
//   "Sizes": [
//     "Small"
//   ]
// }
        }
    }
}