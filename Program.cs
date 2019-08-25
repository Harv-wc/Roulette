using System;
using System.Collections.Generic;

namespace Roulette
{
    class Program
    {
        
        public static int UserInput { get; set; }
        static void Main(string[] args)
        {
            Menu placeBets = new Menu { };
            bool keepBetting = true;
            //betting option results
            List<int> exactBets = new List<int>();
            int evenOddBet = 0;
            int[] colorBet = new int[18];


            do
            {

                placeBets.DisplayOptions();
                UserInput = Convert.ToInt16(Console.ReadLine());

                switch (UserInput)
                {
                    case 0: // stop betting
                        Console.Clear();
                        keepBetting = false;
                        break;
                    case 1:
                        exactBets.Add(placeBets.OptionExactNumber());
                        Console.Clear();
                        break;
                    case 2:
                        evenOddBet = placeBets.OptionEvenOrOdd(); // 1 = even  |  2 = odd
                        Console.Clear();
                        break;
                    case 3:
                        colorBet = placeBets.OptionBlackOrRed();
                        Console.Clear();
                        break;
                    case 4:
                        break;
                    case 5:
                        break;
                    case 6:
                        break;
                    case 7:
                        break;
                    case 8:
                        break;
                    case 9:
                        break;
                    case 10:
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Wrong selection. Lets try that again...");
                        Console.ReadLine();
                        break;
                }
            } while (keepBetting);

            RouletteBall ball = new RouletteBall { };
            Console.WriteLine($"Roulette ball number: {ball.Number}\n");
            // bets from option 1: exact numbers
            Console.Write($"Your exact bets: \n");
            foreach (int num in exactBets)
            {
                if (ball.Number == num)
                {
                    Console.WriteLine($"{num} is a winning bet!");
                }
            }
            //

            //bet from option 2: even or odd
            if (evenOddBet == 1 && ball.Number%2 == 0)
            {
                Console.WriteLine($"Your Even bet wins!");
            }
            else if (evenOddBet == 2 && ball.Number%2 != 0)
            {
                Console.WriteLine($"Your Odd bet wins!");
            }
            //

            //bet from option 3: color black or red
            foreach (int num in colorBet)
            {
                if (ball.Number == num)
                {
                    Console.WriteLine("Your color bet wins!");
                }
            }
            //

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
