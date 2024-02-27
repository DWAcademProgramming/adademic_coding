using System;
public class Program
{
    public static void Main()
    {
        Random rnd = new Random();
        int first, second;
        for (int counter = 0; counter < 10; counter++)
        {
            first = rnd.Next(1, 100);
            second = rnd.Next(1, 100);
            findMax(first, second);
        }
    }
    static void findMax(int n1, int n2)
    {
        if (n1 > n2)
            Console.WriteLine(n1 + " is larger than " + n2);
        else if (n2 > n1)
            Console.WriteLine(n2 + " is larger than " + n1);
        else
            Console.WriteLine(n1 + " is equal to " + n2);
        return;
    }
}
