using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;

namespace bucketList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> bucketListLocations = new List<string>
            {
                "London",
                "Amsterdam",
                "The Swiss Alps",
                "Hokkaido"
            };
            string name;
            string[] nameArr;
            int menu;

            Console.WriteLine("Please make a selection from the menu");
            Console.WriteLine("1. Print sorted list\n2. Add to List\n3. Delete List\n4. Quit");
            menu = int.Parse(Console.ReadLine());
            while (menu != 4)
            {
                if (menu == 1)
                {
                    printList(bucketListLocations);
                }
                else if (menu == 2)
                {
                    nameArr = addList();
                    bucketListLocations.AddRange(nameArr);
                }
                else if (menu == 3)
                {
                    Console.Write("Enter the name of the location you want removed from the list: ");
                    name = Console.ReadLine();
                    if (bucketListLocations.Contains(name))
                    {
                        bucketListLocations.Remove(name);
                        Console.WriteLine("The location has been removed from the list");
                    }
                    else
                        Console.WriteLine("Sorry, that name does not exist, please try again");
                }
                Console.WriteLine("1. Print sorted list\n2. Add to List\n3. Delete List\n4. Quit");
                menu = int.Parse(Console.ReadLine());
            }
        }
        static void printList(List<string> mem)
        {
            mem.Sort();
            foreach (string s in mem)
                Console.WriteLine(s);
            return;
        }
        static string[] addList()
        {
            Console.Write("How many locations would you like to add? ");
            int number = int.Parse(Console.ReadLine());
            string[] newLocations = new string[number];
            for (int i = 0; i < number; i++)
            {
                Console.Write("The location's name? ");
                newLocations[i] = Console.ReadLine();

            }
            return newLocations;
        }
    }
}
