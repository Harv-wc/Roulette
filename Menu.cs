using System;
using System.Collections.Generic;
using System.Text;

namespace Roulette
{
    class Menu
    {
        
        public ConsoleKeyInfo UserInput2 { get; set; }
        public void DisplayOptions()
        {
            Console.WriteLine($"Select a bet to make:\n\n" +
                $"1. Exact Number...\n" +
                $"2. Even or Odd...\n" +
                $"3. Black or Red...\n" +
                $"4. High or Low...\n" +
                $"5. Dozens...\n" +
                $"6. Columns...\n" +
                $"7. Street...\n" +
                $"8. Double Street...\n" +
                $"9. Split...\n" +
                $"10. Corner...\n" +
                $"0. To Stop All Bets!\n" +
                $"####################");
        }

        public int OptionExactNumber()
        {
            int bet;
            Console.Clear();
            Console.Write($"Enter the number you want to place your bet on: ");
            bet = Convert.ToInt32(Console.ReadLine());
            return bet;
            
        }
        public int OptionEvenOrOdd()
        {
            int evenOrOdd;
            Console.Clear();
            Console.WriteLine($"1. Even\n" +
                $"or\n" +
                $"2. Odd");
            evenOrOdd = Convert.ToInt32(Console.ReadLine());
            return evenOrOdd;
        }
        public int[] OptionBlackOrRed()
        {
            int selection;
            int[] black = { 2, 4, 6, 8, 10, 11, 13, 15, 17, 20, 22, 24, 26, 28, 29, 31, 33, 35 };
            int[] red = { 1, 3, 5, 7, 9, 12, 14, 16, 18, 19, 21, 23, 25, 27, 30, 32, 34, 36 };
            Console.Clear();
            Console.WriteLine($"1. Black\n" +
                $"or\n" +
                $"2. Red\n");
            selection = Convert.ToInt32(Console.ReadLine());
            if (selection == 1)
            {
                return black;
            }
            else
                return red;

        }
        public void OptionHighOrLow()
        {

        }
        public void OptionDozens()
        {

        }
        public void OptionColumns()
        {

        }
        public void OptionStreet()
        {

        }
        public void OptionDoubleStreet()
        {

        }
        public void OptionSplit()
        {

        }
        public void OptionCorner()
        {

        }
    }
}
