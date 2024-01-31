using System;
namespace PieceRatePay
{
    class Program
    {
        static void Main(string[] args)
        {
            // create an integer variable named rate and set it equal to 50
            int rate = 50;
            // create an integer named pieces and set it equal to 100
            int pieces = 100;
            // create an integer variable named batches and set it equal to 10
            int batches = 10;
            // create an integer variable named pay
            // set pay equal to rate x pieces x batches
            int pay = rate * pieces * batches;
            // create an integer variable named totalPieces
            // set totalPieces to pieces x batches
            int totalPieces = pieces * batches; 
            // using string interpolation, print the following phrase
            // "You completed {totalPieces} pieces at a rate of {rate} and will receive ${pay}"
            Console.WriteLine($"You completed {totalPieces} pieces at a rate of {rate} and will receive");
        }
    }
}