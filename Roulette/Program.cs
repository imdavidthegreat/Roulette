 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roulette
{
    class Program
    {
        static int GetNum()
        {
            int value;
            string userinput = Console.ReadLine();
            if (userinput == "00")
            {
                value = 37;
            }
            else
            {
                value = System.Int32.Parse(userinput);
            }
            Console.WriteLine(value);
            return value;
        }

        static int[] MakeNumberBet()
        {
            int selection;
            int[] numBet = new int[1];
            int[] allnumbers = new int[38]{ 0,1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,20,21,22,23,24,25,26,27,28,29,30,31,32,33,34,35,36,37};
            Console.WriteLine("What number would you like to bet on? (enter and number from 0-36 or 00)");
            selection = GetNum();
            for (int i = 0; i < allnumbers.Length; i++)
            {
                if( selection == allnumbers[i])
                {
                    numBet[0] = allnumbers[i];
                    break;
                }
            }

            return numBet;
        }

        static int[] MakeEvenOddBet()
        {
            int[] evenNums = new int[18]{2,4,6,8,10,12,14,16,18,20,22,24,26,28,30,32,34,36};
            int[] oddNums = new int[18]{1,3,5,7,9,11,13,15,17,19,21,23,25,27,29,31,33,35};
            int selection;
            Console.WriteLine("Would you like to bet for Even or Odd?\n1. Even\n2. Odd");
            selection = GetNum();

            switch(selection)
            {
                case 1:
                    return evenNums;
                default:
                    return oddNums;
                
            }
        }
        static int[] MakeRedBlackBet()
        {
            int[] redNums = new int[18]{1,3,5,7,9,12,14,16,18,19,21,23,25,27,30,32,34,36};
            int[] blackNums = new int[18]{2,4,6,8,10,11,13,15,17,20,22,24,26,28,29,31,33,35};
            int selection;
            Console.WriteLine("Would you like to bet for Red or Black?\n1. Red\n2. Black");
            selection = GetNum();

            switch(selection)
            {
                case 1:
                    return redNums;
                default:
                    return blackNums;
                
            }

        }

        static int[] MakeLowHighBet()
        {
            int[] lowNums = new int[18]{1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18};
            int[] highNums = new int[18]{19,20,21,22,23,24,25,26,27,28,29,30,31,32,33,34,35,36};
            int selection;
            Console.WriteLine("Would you like to bet for Low or High?\n1. Low\n2. High");
            selection = GetNum();

            switch(selection)
            {
                case 1:
                    return lowNums;
                default:
                    return highNums;
                
            }

        }

        static int[] MakeDozensBet()
        {
            int[] lowNums = new int[12]{1,2,3,4,5,6,7,8,9,10,11,12};
            int[] midNums = new int[12]{13,14,15,16,17,18,19,20,21,22,23,24};
            int[] highNums = new int[12]{25,26,27,28,29,30,31,32,33,34,35,36};
            int selection;
            Console.WriteLine("Would you like to bet for Low, Mid, or High?\n1. Low\n2. Mid\n3. High");
            selection = GetNum();

            switch(selection)
            {
                case 1:
                    return lowNums;
                case 2:
                    return midNums;
                default:
                    return highNums;
                
            }

        }

        static int[] MakeColumnsBet()
        {
            int[] firstColumnNums = new int[12] { 1, 4, 7, 10, 13, 16, 19, 22, 25, 28, 31, 34 };
            int[] secondColumnNums = new int[12] { 2, 5, 8, 11, 14, 17, 20, 23, 26, 29, 32, 35};
            int[] thirdColumnNums = new int[12] { 3, 6, 9, 12, 15, 18, 21, 24, 27, 30, 33, 36};
            int selection;
            Console.WriteLine("Would you like to bet for First, Second, or Third?\n1. First\n2. Second\n3. Third");
            selection = GetNum();

            switch (selection)
            {
                case 1:
                    return firstColumnNums;
                case 2:
                    return secondColumnNums;
                default:
                    return thirdColumnNums;

            }

        }

        static int[] MakeStreetsBet()
        {
            int[] firstStreetNums = new int[3] { 1,2,3 };
            int[] secondStreetNums = new int[3] { 4,5,6 };
            int[] thirdStreetNums = new int[3] { 7,8,9 };
            int[] fourthStreetNums = new int[3] { 10,11,12 };
            int[] fifthStreetNums = new int[3] { 13,14,15 };
            int[] sixthStreetNums = new int[3] { 16,17,18 };
            int[] seventhStreetNums = new int[3] { 19,20,21 };
            int[] eighthStreetNums = new int[3] { 22,23,24 };
            int[] ninethStreetNums = new int[3] { 25,26,27 };
            int[] tenthStreetNums = new int[3] { 28,29,30 };
            int[] eleventhStreetNums = new int[3] { 31,32,33 };
            int[] twelvethStreetNums = new int[3] { 34,35,36 };
            int selection;
            Console.WriteLine("Select an option based on the number that the Street you want to bet on starts with.\n1. 1\n2. 4\n3. 7" +
                "\n4. 10\n5. 13\n6. 16\n7. 19\n8. 22\n9. 25\n10. 28\n11. 31\n12. 34");
            selection = GetNum();

            switch (selection)
            {
                case 1:
                    return firstStreetNums;
                case 2:
                    return secondStreetNums;
                case 3:
                    return secondStreetNums;
                case 4:
                    return secondStreetNums;
                case 5:
                    return secondStreetNums;
                case 6:
                    return secondStreetNums;
                case 7:
                    return secondStreetNums;
                case 8:
                    return secondStreetNums;
                case 9:
                    return secondStreetNums;
                case 10:
                    return secondStreetNums;
                case 11:
                    return secondStreetNums;
                default:
                    return twelvethStreetNums;

            }

        }

        static int[] Make6NumbersBet()
        {
            int[] oneandtwoStreetNums = new int[6] { 1, 2, 3, 4, 5, 6 };
            int[] threeandfourStreetNums = new int[6] { 7, 8, 9, 10, 11, 12 };
            int[] fiveandsixStreetNums = new int[6] { 13, 14, 15, 16, 17, 18 };
            int[] sevenandeightStreetNums = new int[6] { 19, 20, 21, 22, 23, 24 };
            int[] nineandtenStreetNums = new int[6] { 25, 26, 27, 28, 29, 30 };
            int[] elevenandtwelveStreetNums = new int[6] { 31, 32, 33, 34, 35, 36 };
            
            int selection;
            Console.WriteLine("Select an option based on the number that the pair of Streets you want to bet on starts with.\n1. 1\n2. 7" +
                "\n3. 13\n4. 19\n5. 25\n6. 31");
            selection = GetNum();

            switch (selection)
            {
                case 1:
                    return oneandtwoStreetNums;
                case 2:
                    return threeandfourStreetNums;
                case 3:
                    return fiveandsixStreetNums;
                case 4:
                    return sevenandeightStreetNums;
                case 5:
                    return nineandtenStreetNums;
                default:
                    return elevenandtwelveStreetNums;
                

            }

        }

        static int[] MakeCornersBet()
        {
            int[] oneCornertNums = new int[4] { 1, 2, 4, 5 };
            int[] twoCornertNums = new int[4] { 2, 3, 5, 6 };
            int[] fourCornertNums = new int[4] { 4, 5, 7, 8 };
            int[] fiveCornertNums = new int[4] { 5, 6, 8, 9 };
            int[] sevenCornertNums = new int[4] { 7, 8, 10, 11 };
            int[] eightCornertNums = new int[4] { 8, 9, 11, 12 };
            int[] tenCornertNums = new int[4] { 10, 11, 13, 14 };
            int[] elevenCornertNums = new int[4] { 11, 12, 14, 15 };
            int[] thirteenCornertNums = new int[4] { 13, 14, 16, 17 };
            int[] fourteenCornertNums = new int[4] { 14, 15, 17, 18 };
            int[] sixteenCornertNums = new int[4] { 16, 17, 19, 20 };
            int[] seventeenCornertNums = new int[4] { 17, 18, 20, 21 };
            int[] nineteenCornertNums = new int[4] { 19, 20, 22, 23 };
            int[] twentyCornertNums = new int[4] { 20, 21, 23, 24 };
            int[] twentytwoCornertNums = new int[4] { 22, 23, 25, 26 };
            int[] twentythreeCornertNums = new int[4] { 23, 24, 26, 27 };
            int[] twentyfiveCornertNums = new int[4] { 25, 26, 28, 29 };
            int[] twentysixCornertNums = new int[4] { 26, 27, 29, 30 };
            int[] twentyeightCornertNums = new int[4] { 28, 29, 31, 32 };
            int[] twentynineCornertNums = new int[4] { 29, 30, 32, 33 };
            int[] thirtyoneCornertNums = new int[4] { 31, 32, 34, 35 };
            int[] thirtytwoCornertNums = new int[4] { 32, 33, 35, 36 };
            
            int selection;
            Console.WriteLine("What is the bottom-left number of your corner (ex. 1 is the bottom left for the 1,2,4,5 corner).");
            selection = GetNum();

            switch (selection)
            {
                case 1:
                    return oneCornertNums;
                case 2:
                    return twoCornertNums;
                case 4:
                    return fourCornertNums;
                case 5:
                    return fiveCornertNums;
                case 7:
                    return sevenCornertNums;
                case 8:
                    return eightCornertNums;
                case 10:
                    return tenCornertNums;
                case 11:
                    return elevenCornertNums;
                case 13:
                    return thirteenCornertNums;
                case 14:
                    return fourteenCornertNums;
                case 16:
                    return sixteenCornertNums;
                case 17:
                    return seventeenCornertNums;
                case 19:
                    return nineteenCornertNums;
                case 20:
                    return twentyCornertNums;
                case 22:
                    return twentytwoCornertNums;
                case 23:
                    return twentythreeCornertNums;
                case 25:
                    return twentyfiveCornertNums;
                case 26:
                    return twentysixCornertNums;
                case 28:
                    return twentyeightCornertNums;
                case 29:
                    return twentynineCornertNums;
                case 31:
                    return thirtyoneCornertNums;
                default:
                    return thirtytwoCornertNums;

            }

        }

        static void Menu()
        {
            int betnumber = 0;
            int selection;
            int[][] bets = new int[10][];
            string[] betNames = new string[10];

            Console.WriteLine("\n\tWelcome to Roulette!\n" +
                "You will enter 10 bets. Follow the prompts to enter your bet choices. Only enter the number choice of your selection." +
                "\nPress enter to continue...");
            Console.ReadKey();
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"\nNumber of bets made: {betnumber}");
                Console.WriteLine("Please select a bet:" +
                    "\n1.  Number\t - choose a specific number" +
                    "\n2.  Even/Odd\t - choose between even numbers or odd numbers" +
                    "\n3.  Red/Black\t - choose between red numbers or black numbers" +
                    "\n4.  Low/High\t - choose between low numbers(1-18) or high numbers(19-36)" +
                    "\n5.  Dozens\t - choose between (1-12), (13-24), or (25-36)" +
                    "\n6.  Columns\t - choose between the first, second, or third columns" +
                    "\n7.  Street\t - choose a row of numbers" +
                    "\n8.  6 Numbers\t - choose a set of 2 rows" +
                    "\n9.  Split\t - choose a set of 2 numbers" +
                    "\n10. Corner\t - choose a set of 4 numbers");

                selection = GetNum();

                switch (selection)
                {
                    case 1:
                        bets[i] = MakeNumberBet();
                        betNames[i] = "Number Bet";
                        betnumber++;
                        break;
                    case 2:
                        bets[i] = MakeEvenOddBet();
                        betNames[i] = "Even/Odd Bet";
                        betnumber++;
                        break;
                    case 3:
                        bets[i] = MakeRedBlackBet();
                        betNames[i] = "Red/Black Bet";
                        betnumber++;
                        break;
                    case 4:
                        bets[i] = MakeLowHighBet();
                        betNames[i] = "High/Low Bet";
                        betnumber++;
                        break;
                    case 5:
                        bets[i] = MakeDozensBet();
                        betNames[i] = "Dozens Bet";
                        betnumber++;
                        break;
                    case 6:
                        bets[i] = MakeColumnsBet();
                        betNames[i] = "Columns Bet";
                        betnumber++;
                        break;
                    case 7:
                        bets[i] = MakeStreetsBet();
                        betNames[i] = "Streets Bet";
                        betnumber++;
                        break;
                    case 8:
                        bets[i] = Make6NumbersBet();
                        betNames[i] = "6 Numbers Bet";
                        betnumber++;
                        break;
                    case 9:
                        bets[i] = MakeCornersBet();
                        betNames[i] = "Corners Bet";
                        betnumber++;
                        break;
                    case 10:
                        bets[i] = MakeColumnsBet();
                        betNames[i] = "Columns Bet";
                        betnumber++;
                        break;
                    default:
                        break;
                }
                
            }
            
            
        }

        static void Main(string[] args)
        {
            Menu();
        }
    }
}
