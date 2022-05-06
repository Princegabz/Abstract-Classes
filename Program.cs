using AbstractClasses1;
using System;

namespace Abstract_Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductValues p = new ProductValues("Bread", 12, 8, "1022");
            //p.ProductName = "Bread";
            //p.ProductPrice = 12;
            //p.ProductQty = 5;
            Console.WriteLine(p.toString());



            ProductCompanys Com = new ProductCompanys("Bread", 12, 8, "1022", "57257257257");
            //p.ProductPrice = 12;
            //p.ProductQty = 5;
            Console.WriteLine(Com.toString());
        }
    }
}