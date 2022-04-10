using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Literal_Console_Games_Collection
{
    class Program
    {
        static void Intro()
        {
            #region Frame 1
            for (int i = 0; i < 2; i++)
                Console.WriteLine();

            Console.Write("               "); // 15 characters
            Console.Write("|");
            Console.Write("               "); // 15 characters
            Thread.Sleep(83);
            #endregion
        }
        static void Main(string[] args)
        {
            Intro();

            char confirm = 'Y';
            do
            {
                #region Main Menu
                Console.Clear();
                Console.WriteLine("Welcome to the Literal Console Games Collection!");
                Console.WriteLine();
                Console.WriteLine("0) Exit");
                Console.WriteLine("1) Config");
                Console.WriteLine("2) Russian Roulette");
                Console.WriteLine("3) Hangman");
                Console.WriteLine("4) Snake");
                Console.WriteLine("5) Pong");
                Console.WriteLine();
                Console.Write("Pick a game by writing its number: ");
                int select = int.Parse(Console.ReadLine());
                Console.SetCursorPosition(0, Console.CursorTop - 1);
                Console.WriteLine("                                    "); // 36 characters
                #endregion

                #region Selection Confirmation
                do
                {
                    Console.SetCursorPosition(0, Console.CursorTop - 1);
                    Console.WriteLine($"Confirm option {select}? [Y/N]");
                    Console.WriteLine();
                    confirm = Char.ToUpper(char.Parse(Console.ReadLine()));

                    if ((confirm != 'Y') && (confirm != 'N'))
                    {
                        Console.SetCursorPosition(0, Console.CursorTop - 3);
                        Console.WriteLine("Invalid answer.");
                    }

                } while ((confirm != 'Y') && (confirm != 'N'));
                #endregion

                Console.Clear();

                #region After Confirmation
                switch (select)
                {
                    case 0:
                        Outro();
                        return;
                    case 1:
                        Test.Config();
                        break;
                    case 2:
                        Games.RussianRoulette();
                        break;
                    default:
                        Console.WriteLine("Invalid number.");
                        break;
                }
                Console.ReadKey();
                #endregion

                #region Repeat
                do
                {
                    Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop);
                    Console.WriteLine("Would you like to return to the main menu? [Y/N]");
                    confirm = Char.ToUpper(char.Parse(Console.ReadLine()));

                    if ((confirm != 'Y') && (confirm != 'N'))
                    {
                        Console.WriteLine("Invalid answer.");
                    }

                } while ((confirm != 'Y') && (confirm != 'N'));
                #endregion

            } while ((confirm == 'Y'));

            Outro();
            return;
        }

        static void Outro()
        {
            Console.Clear();

            #region Frame 1
            for (int i = 0; i < 2; i++)
                Console.WriteLine();

            Console.Write("               ");
            Console.Write("|");
            Console.Write("               ");
            Thread.Sleep(83);
            #endregion
        }
    }

    public class Games
    {
        public static void RussianRoulette()
        {
            Console.WriteLine("Welcome to Russian Roulette!");
            Console.WriteLine();
            Console.WriteLine("   ______.");
            Console.WriteLine(" ~(_]----'");
            Console.WriteLine(" /_(");
            Console.WriteLine();
            Console.WriteLine("This is a revolver. The kind isn't specified, but we do know this one has specifically 6 bullets.");
            Console.WriteLine("Your goal is to guess in which chamber the bullet ISN'T in.");
            Random chamber = new Random();
            int random = chamber.Next(1,7);
            Console.WriteLine();
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine();
            if (random == a)
            {
                Console.WriteLine("You lost. Press any key to continue.");
            }
            else
            {
                Console.WriteLine("You win! Press any key to continue.");
            }
            Console.WriteLine();
        }
    }

    public class Test
    {
        public static void Config()
        {
            Console.WriteLine("There is nothing here. Press any key to continue.");
        }
    }
}
