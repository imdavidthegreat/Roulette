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
            int value = System.Int32.Parse(Console.ReadLine());

            return value;
        }

        static int[] MakeNumberBet()
        {
            Console.WriteLine();
        }

        static void Menu()
        {
            int betnumber = 0;
            int selection;
            int[][] bets = new int[10][];

            Console.WriteLine("\n\tWelcome to Roulette!\n" +
                "You will enter 10 bets. Follow the prompts to enter your bet choices. Only enter the number choice of your selection." +
                "\nPress enter to continue...");
            Console.ReadKey();
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"Number of bets made: {betnumber}");
                Console.WriteLine("Please select a bet:" +
                    "\n1.  Number\t - choose a specific number" +
                    "\n2.  Even/Odd\t - choose between even numbers or odd numbers" +
                    "\n3.  Red/Black\t - choose between red numbers or black numbers" +
                    "\n4.  Low/High\t - choose between low numbers(1-18) or high numbers(19-36)" +
                    "\n5.  Dozens\t - choose between (1-12), (13-24), or (25-36)" +
                    "\n6.  Columns\t - choose between the first, second, or third columns of numbers" +
                    "\n7.  Street\t - choose a row of numbers" +
                    "\n8.  6 Numbers\t - choose a set of 2 rows" +
                    "\n9.  Split\t - choose a set of 2 numbers" +
                    "\n10. Corner\t - choose a set of 4 numbers");

                selection = GetNum();

                switch (selection)
                {
                    case 1:
                        bets[i] = MakeNumberBet();
                        betnumber++;
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
