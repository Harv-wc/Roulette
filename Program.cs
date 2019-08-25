using System;

namespace Roulette
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu placeBets = new Menu { };
            placeBets.DisplayOptions();

            for (int i = 0; i < 3; i++)
            {
                RouletteBall ball = new RouletteBall { };
                Console.WriteLine(ball.Number);
            }
        }
    }

    class RouletteBall
    {
        Random rand = new Random();
        public int Number { get; }
        public RouletteBall()
        {
            Number = rand.Next(37);
        }
    }
    class MadeBets
    {
        // stores numbers from bets made to compare against BallNumber
    }

}
