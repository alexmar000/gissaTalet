using System;

namespace random
{
    class Program
    {
        static void Main(string[] args)
        {
            Random randomer = new Random();
            int slumpTal = randomer.Next(1, 101);
            string welcome = "Gissa ett tal mellan 1 och 100!";
            string below = "Högre! Försök igen.";
            string above = "Lägre! Försök igen.";
            string right = "Rätt! Talet var ";
            string rightTwo = ". Bra jobbat!";
            string userGuess;
            int intGuess;

            Console.WriteLine(welcome);

            do
            {
                userGuess = Console.ReadLine();
                intGuess = Convert.ToInt32(userGuess);

                if (intGuess == slumpTal)
                {
                    Console.WriteLine(right + slumpTal + rightTwo);
                }
                else if (intGuess > slumpTal)
                {
                    Console.WriteLine(above);
                }
                else
                {
                    Console.WriteLine(below);

                }
            }
            while (intGuess != slumpTal);

            Console.ReadKey();


        }
    }
}
