
using System;

namespace Favorites
{
    class MyFavorites
    {
        static void Main(string[] args)
        {   
            // The Basics
            Console.WriteLine("What is your favorite number?");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine("What is your favorite food?");
            string food = Console.ReadLine();
            Console.WriteLine("What is your favorite color?");
            string color = Console.ReadLine();

            // The Season Questions
            Console.WriteLine("What's your favorite season?"); 
            Console.WriteLine("Is it Spring? True or False");
            bool spring = bool.Parse(Console.ReadLine());
            Console.WriteLine("Is it Summer? True or False");
            bool summer = bool.Parse(Console.ReadLine());
            Console.WriteLine("Is it Autumn? True or False");
            bool autumn = bool.Parse(Console.ReadLine());
            Console.WriteLine("Is it Winter? True or False");
            bool winter = bool.Parse(Console.ReadLine());
            
            // This would be an amazing case for a Switch
            // And if I knew how to do it in C#, would be my choice
            Console.WriteLine("Based on your input, we can say the following about you"); 
            Console.WriteLine($"Your favoite number is {number}");
            Console.WriteLine($"Your favorite food is {food}"); 
            Console.WriteLine($"Your favorite color is {color}"); 

            string favoiteSeason ="You're fond of";
            if(spring == true )
            {
                favoiteSeason = favoiteSeason + "Spring"; 
            }
            if(summer == true)
            {
                favoiteSeason = favoiteSeason + "Summer"; 
            }
            if(autumn == true)
            {
                favoiteSeason = favoiteSeason + "Autumn";
            }
            if(winter == true)
            {
                favoiteSeason = favoiteSeason + "Winter"; 
            }
            else
            {
                Console.WriteLine("No favorite season? What a shame.")
            }
        }
    }
}