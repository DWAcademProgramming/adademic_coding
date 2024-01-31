using System;

namespace firstLessonsSummary
{
    class firstClass
    {
        static void Main(string[] args)
        {
            int luckyNumber = 12; 
            int rndNumber = 5;
            string luck = "12 is my lucky number";
            if(luckyNumber = rndNumber)
            {
                Console.WriteLine($"{luckyNumber} is my family's lucky number");
            }
            else
            {
                Console.WriteLine($"{rndNumber} is not my family's lucky number"); 
            }
        }
    }
}