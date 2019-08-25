using System;

namespace Roulette
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int i = 0; i <= 15; i++)
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
}
