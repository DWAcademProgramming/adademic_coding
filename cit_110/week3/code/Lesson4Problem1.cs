using System;

namespace purchaseProgram
{
    class purchaseProgram
    {
        static void Main(string[] args)
        {
            /*
                Create variables that store a 
                Customer's Name
                Description of the item they seek to buy
                The quantity of the items
                The price of the items

                The program outputs the above as concatinated 
            */
            Console.WriteLine("May I have your name?");
            string name = Console.ReadLine();
            Console.WriteLine("What are you looking for?");
            string item = Console.ReadLine();
            Console.WriteLine("How many do you wish to purchase?");
            double quantity = double.Parse(Console.ReadLine());
            Console.WriteLine("What's a fair price?");
            double price = double.Parse(Console.ReadLine());
            double total = quantity * price;
            Console.WriteLine($"{name} has ordered {quantity} of {item} and it will cost ${total}");
        }
    }
}
