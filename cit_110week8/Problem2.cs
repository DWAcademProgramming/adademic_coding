using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Security.AccessControl;

namespace myLists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] category = new string[3] { "Breakfast", "Lunch", "Dinner" };
            double[] revenue = new double[3] { 20000.00, 30000.10, 40000.22 };

            List<string> menuList = new List<string>();
            menuList.Add("Desserts");
            menuList.Add("Take Out");

            List<double> revenueList = new List<double>();
            revenueList.Add(13500.03);
            revenueList.Add(60499.99);

            menuList.AddRange(category);
            revenueList.AddRange(revenue);

            menuList.Remove(menuList[4]);
            revenueList.Remove(revenueList[4]);

            Console.WriteLine("Hawkeye Cafe and Bakery Menu and Revenue"); 
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            for(int i = 0; i<menuList.Count(); i++)
            {
                Console.WriteLine("Category: " + menuList[i] + ", Revenue: $" + String.Format("{0:0,000.00}", revenueList[i]));
            }
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine("Hawkeye Cafe and Bakery Menus");
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            revenueList.Clear(); 
            menuList.Sort(); 
            for(int i = 0; i<menuList.Count(); i++)
            {
                Console.WriteLine(menuList[i]); 
            }
        }
    }
}
