using System;
using System.Collections.Generic;
using System.Text;

namespace Roulette
{
    class Menu
    {
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
        public int OptionHighOrLow()
        {
            int selection;
            Console.Clear();
            Console.WriteLine($"1. For low bet: 1 - 18 including 0\n" +
                $"or\n" +
                $"2. For high bet: 19 - 36 including 00\n");
            selection = Convert.ToInt32(Console.ReadLine());
            return selection;
        }
        public int OptionDozens()
        {
            int selection;
            Console.Clear();
            Console.WriteLine($"1. For first dozen: 1 - 12\n" +
                $"2. For second dozen: 13 - 24\n" +
                $"3. For third dozen: 25 - 36");
            selection = Convert.ToInt32(Console.ReadLine());
            return selection;
        }
        public int[] OptionColumns()
        {
            int selection;
            int[] first = { 1, 4, 7, 10, 13, 16, 19, 22, 25, 28, 31, 34 };
            int[] second = { 2, 5, 8, 11, 14, 17, 20, 23, 26, 29, 32, 35 };
            int[] third = { 3, 6, 9, 12, 15, 18, 21, 24, 27, 30, 33, 36 };
            Console.Clear();
            Console.WriteLine($"1. Column 1\n" +
                $"2. Column 2\n" +
                $"3. Column 3\n");
            selection = Convert.ToInt32(Console.ReadLine());
            if (selection == 1)
                return first;
            else if (selection == 2)
                return second;
            else
                return third;
        }
        public int[] OptionStreet()
        {
            int selection;
            int[] s1 = { 1, 2, 3 };
            int[] s2 = { 4, 5, 6 };
            int[] s3 = { 7, 8, 9 };
            int[] s4 = { 10, 11, 12 };
            int[] s5 = { 13, 14, 15 };
            int[] s6 = { 16, 17, 18 };
            int[] s7 = { 19, 20, 21 };
            int[] s8 = { 22, 23, 24 };
            int[] s9 = { 25, 26, 27 };
            int[] s10 = { 28, 29, 30 };
            int[] s11 = { 31, 32, 33 };
            int[] s12 = { 34, 35, 36 };
            Console.Clear();
            Console.WriteLine($"Choose the street to bet on:\n" +
                $"1. 1, 2, 3\n" +
                $"2. 4, 5, 6\n" +
                $"3. 7, 8, 9\n" +
                $"4. 10, 11, 12\n" +
                $"5. 13, 14, 15\n" +
                $"6. 16, 17, 18\n" +
                $"7. 19, 20, 21\n" +
                $"8. 22, 23, 24\n" +
                $"9. 25, 26, 27\n" +
                $"10. 28, 29, 30\n" +
                $"11. 31, 32, 33\n" +
                $"12. 34, 35, 36\n");
            selection = Convert.ToInt32(Console.ReadLine());
            switch (selection)
            {
                case 1:
                    return s1;
                case 2:
                    return s2;
                case 3:
                    return s3;
                case 4:
                    return s4;
                case 5:
                    return s5;
                case 6:
                    return s6;
                case 7:
                    return s7;
                case 8:
                    return s8;
                case 9:
                    return s9;
                case 10:
                    return s10;
                case 11:
                    return s11;
                case 12:
                    return s12;
                default:
                    return null;
            }
        }
        public int[] OptionDoubleStreet()
        {
            int selection;
            int[] s1 = { 1, 2, 3, 4, 5, 6 };
            int[] s2 = { 4, 5, 6, 7, 8, 9 };
            int[] s3 = { 7, 8, 9, 10, 11, 12 };
            int[] s4 = { 10, 11, 12, 13, 14, 15 };
            int[] s5 = { 13, 14, 15, 16, 17, 18 };
            int[] s6 = { 16, 17, 18, 19, 20, 21 };
            int[] s7 = { 19, 20, 21, 22, 23, 24 };
            int[] s8 = { 22, 23, 24, 25, 26, 27 };
            int[] s9 = { 25, 26, 27, 28, 29, 30 };
            int[] s10 = { 28, 29, 30, 31, 32, 33 };
            int[] s11 = { 31, 32, 33, 34, 35, 36 };
            Console.Clear();
            Console.WriteLine($"Choose the double-street to bet on:\n" +
                $"1. 1, 2, 3, 4, 5, 6\n" +
                $"2. 4, 5, 6, 7, 8, 9\n" +
                $"3. 7, 8, 9, 10, 11, 12\n" +
                $"4. 10, 11, 12, 13, 14, 15\n" +
                $"5. 13, 14, 15, 16, 17, 18\n" +
                $"6. 16, 17, 18, 19, 20, 21\n" +
                $"7. 19, 20, 21, 22, 23, 24\n" +
                $"8. 22, 23, 24, 25, 26, 27\n" +
                $"9. 25, 26, 27, 28, 29, 30\n" +
                $"10. 28, 29, 30, 31, 32, 33\n" +
                $"11. 31, 32, 33, 34, 35, 36\n");
            selection = Convert.ToInt32(Console.ReadLine());
            switch (selection)
            {
                case 1:
                    return s1;
                case 2:
                    return s2;
                case 3:
                    return s3;
                case 4:
                    return s4;
                case 5:
                    return s5;
                case 6:
                    return s6;
                case 7:
                    return s7;
                case 8:
                    return s8;
                case 9:
                    return s9;
                case 10:
                    return s10;
                case 11:
                    return s11;
                default:
                    return null;
            }
        }
        public void OptionSplit()
        {

        }
        public void OptionCorner()
        {

        }
    }
}
