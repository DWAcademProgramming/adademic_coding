using System;
using System.Collections;

namespace companyEmployees
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string semester = "Spring ";
            const string year = " 2024";
            int menu;
            ArrayList newTodo = new ArrayList() { };
            ArrayList todoList = new ArrayList() { "CIT110 Homework", 4.0, "Cook", 1.0, "Exercise", 2.0 };

            printCompanyHeading(semester, year);
            Console.WriteLine("Please make a selection from the menu");
            Console.WriteLine("1. Print All by index\n2. Add \n3. Delete \n4. Delete All\n5. Quit");
            menu = int.Parse(Console.ReadLine());

            while (menu != 5)
            {
                if (menu == 1)
                {
                    printCompanyHeading(semester, year);
                }
                else if (menu == 2)
                {
                    printCompanyHeading(semester, year);
                    newTodo = addEmp();
                    todoList.AddRange(newTodo);
                }
                else if (menu == 3)
                {
                    printCompanyHeading(semester, year);
                    Console.Write("Enter the index# of the person you want removed\n(the name, title and hours will be erased): ");
                    int indexNumber = int.Parse(Console.ReadLine());
                    for (int count = 0; count < 2; count++)
                    {
                        todoList.RemoveAt(indexNumber);
                    }
                    Console.WriteLine("The values have been deleted");

                }
                else if (menu == 4)
                {
                    printCompanyHeading(semester, year);
                    todoList.Clear();
                    Console.WriteLine("It is all gone!");
                }
                else
                    Console.WriteLine("You made an invalid selection, please try again!");

                printCompanyHeading(semester, year);
                Console.WriteLine("1. Print by index\n2. Add \n3. Delete \n4. Delete All\n5. Quit");
                menu = int.Parse(Console.ReadLine());
            }
        }
        static void printCompanyHeading(string comp, string yr)
        {
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine($"  {comp}        {yr}");
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            return;
        }
        static void printEmp(ArrayList emp)
        {
            int index = 0;
            Console.WriteLine("Values by Index#");
            Console.WriteLine("==============================");
            foreach (var e in emp)
            {
                Console.WriteLine(index + ". " + e.ToString());
                index++;
            }
            Console.WriteLine("==============================");
            Console.WriteLine();

            return;
        }
        static ArrayList addEmp()
        {
            Console.Write("What courses would you like to add? ");
            int number = int.Parse(Console.ReadLine());
            ArrayList newCourses = new ArrayList { };
            for (int i = 0; i < number; i++)
            {
                Console.Write("Course subject? ");
                newCourses.Add(Console.ReadLine());
                Console.Write("Course number? ");
                newCourses.Add(Console.ReadLine());
            }
            return newCourses;
        }

    }
}
