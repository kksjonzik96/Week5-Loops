using System;

namespace DiceGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            for (int i = 0; i < 3; i++)
            {
                //arvuti
                int cpuRandom = rnd.Next(1, 7);
                //kasutaja vise 
                int userRandom = rnd.Next(1, 7);

                int cpuScore = 0;
                int userScore = 0;
                Console.WriteLine($"Arvuti viskas {cpuRandom}. Kasutaja viskas {userRandom}");
            
                if (cpuRandom < userRandom)
                {
                    Console.WriteLine("Kasutaja on mangu voitnud!");
                    userScore = userScore + 1;
                }
                else if(cpuRandom > userRandom)
                {
                    Console.WriteLine("Arvuti on mängu võitnud");
                    cpuRandom = cpuRandom + 1;
                }
                else
                {
                    Console.WriteLine("Viik!");
                }
            }

        }
    }
}
