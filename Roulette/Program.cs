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
        //

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
