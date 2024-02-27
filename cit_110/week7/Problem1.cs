using System;
public class Program
{
    public static void Main()
    {
        Random rnd = new Random();
        int number, counter = 0;
        while(counter < 5)
        {
            number = rnd.Next(1, 100);
            //returns numbers between 1 and 100
            Console.WriteLine("The number retrieved is: " + number);
            Console.WriteLine("The number squared is: " + (number * number));
            Console.WriteLine("The number cubed is: " + (number * number * number));
            counter++; 
            if(number % 2 == 0)
            {
                Console.WriteLine("The number is even");
            }
            else
            {
                Console.WriteLine("The number is odd");
            }
        }
        //for (int counter = 0; counter < 5; counter++)
        //{
        //number = rnd.Next(1, 100);// returns numbers between 1 and 100

        //if (number % 2 == 0)
        //Console.WriteLine("The number is even");
        //   else
        //Console.WriteLine("The number is odd");
        //}
    }
}
