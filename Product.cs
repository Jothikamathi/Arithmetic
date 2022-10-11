using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arithmetic
{
    public class Product
    {
        //properties

        int ProductID;
        string ProductName;
        int Mrp_Price;
        float Gst=13.2f;
        float Discount;
        float AfterDiscount;
        int Count;
        int Total;
        float FinalTotal;


        //methods

        public void AddProducts()
        {
            Console.WriteLine("Enter ProductID : ");
            ProductID = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter ProductName");
            ProductName = Console.ReadLine();
            Console.WriteLine("Enter Mrp_Price : ");
            Mrp_Price = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Discount:");
            Discount = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("How many products do you want to Buy: ");
            Count = Convert.ToInt32(Console.ReadLine());
            Total = Mrp_Price * Count;
            AfterDiscount = Total - (Total * Discount / 100);
            FinalTotal = (AfterDiscount * Gst) / 100;
            Console.WriteLine($"You have to pay amount is: {FinalTotal} ");
            Console.WriteLine("------------------");
            Console.WriteLine("Thank You For Shopping with US!");
         } 
        public void DisplayProductDetails()
        {
            Console.WriteLine($" {Total} {AfterDiscount} {FinalTotal} ");
        }
    }

}
