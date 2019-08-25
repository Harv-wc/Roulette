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
            int highLow = -1;
            int dozens = -1;
            int[] column = new int[12];
            int[] street = new int[3];
            int[] doubleStreet = new int[6];


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
                        highLow = placeBets.OptionHighOrLow(); // 1 is low    2 is high
                        Console.Clear();
                        break;
                    case 5:
                        dozens = placeBets.OptionDozens(); // 1 = first, 2 = second, 3 = third  of dozen group
                        Console.Clear();
                        break;
                    case 6:
                        column = placeBets.OptionColumns();
                        Console.Clear();
                        break;
                    case 7:
                        street = placeBets.OptionStreet();
                        Console.Clear();
                        break;
                    case 8:
                        doubleStreet = placeBets.OptionDoubleStreet();
                        Console.Clear();
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
            foreach (int num in exactBets)
            {
                if (ball.Number == num)
                {
                    Console.WriteLine($"{num} is a winning bet!");
                }
                if (ball.Number == 37 && num == 00)
                    Console.WriteLine($"{num} is a winning bet!");
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
            
            //bet from option 4: high or low numbers
            if (highLow == 1 && ball.Number >= 0 && ball.Number <= 18)
            {
                Console.WriteLine($"Your low bet wins!");
            }
            if (highLow == 2 && ball.Number >= 19 && ball.Number <= 37)
            {
                Console.WriteLine($"Your high bet wins!");
            }
            //

            //bet from option 5: groups of dozens
            if (dozens == 1 && ball.Number >= 1 && ball.Number <= 12)
            {
                Console.WriteLine($"Your first dozen bet (1-12) wins!");
            }
            if (dozens == 2 && ball.Number >= 13 && ball.Number <= 24)
            {
                Console.WriteLine($"Your second dozen bet (13-24) wins!");
            }
            if (dozens == 3 && ball.Number >= 25 && ball.Number <= 36)
            {
                Console.WriteLine($"Your third dozen bet (25-36) wins!");
            }
            //

            //bet from option 6: column bet
            foreach (int num in column)
            {
                if (ball.Number == num)
                {
                    Console.WriteLine("Your column bet wins!");
                }
            }
            //

            //bet from option 7: street bet
            foreach (int num in street)
            {
                if (ball.Number == num)
                    Console.WriteLine($"Your street bet wins!");
            }
            //

            //bet from option 8: double-street bet
            foreach (int num in doubleStreet)
            {
                if (ball.Number == num)
                    Console.WriteLine($"Your double-street bet wins!");
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
