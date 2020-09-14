using System;

namespace PercentageCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Good Morning!");
            int Maximum;
            int UserScore;
            double Result;
            Console.WriteLine("What Is The Maximum Score?");
            Maximum = Int32.Parse(Console.ReadLine());
            Console.WriteLine("What Is Your Score?");
            UserScore = Int32.Parse(Console.ReadLine());
            Result = (UserScore * 100) / Maximum;
            Console.WriteLine($"You Scored {Result}%.");
            if (Result >= 90)
            {
                Console.WriteLine("Congratulations, You Got 5");
            }
            else if (Result >= 80)
            {
                Console.WriteLine("You Got 4, Not Bad.");
            }
            else if (Result >= 61)
            {
                Console.WriteLine("You Got 3, Eh Whatever.");


            }
            else
                Console.WriteLine("You Got 2, oof Too Bad.");
        }   

    }
}
