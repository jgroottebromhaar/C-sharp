using System;

namespace SoundSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Login();
        }

        static void Login()
        {
            string nameString;
            string password;
            Console.WriteLine("Username");
            nameString = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Password");
            

            // Password checker
            string pass = "SHARPSOUND";
            string name = nameString;
            int tries = 1;

            do
            {
                password = Console.ReadLine();
                tries++;
                if (password == pass)
                {
                    Console.Clear();
                    Console.WriteLine("Correct password");
                    Console.WriteLine("Welkom bij SoundSharp " + name);
                    Console.Clear();
                    showMenu();
                    break;
                } else if (tries == 2)
                {
                    Console.Clear();
                    Console.WriteLine("Wrong password poging 2 van 3");
                } else if (tries == 3)
                {
                    Console.Clear();
                    Console.WriteLine("Wrong password LET OP: Laatste poging!");
                }
            } while (tries != 4);
        }

        private static void showMenu()

        {
            string[] lines = {
                "1. Overzicht MP3 spelers",
                "2. -",
                "3. -",
                "4. -",
                "5. -",
                "6. -",
                "7. -",
                "8. -",
                "9. Exit" };
            Console.WriteLine();
            foreach (string line in lines)
                Console.WriteLine(line);

            ConsoleKey key;
                        
            do
            {
            
            key = Console.ReadKey().Key;

            switch (key)
            {
            case ConsoleKey.D1:
                Console.Clear();
                Console.WriteLine("1 WAS PRESSED");
                break;
            case ConsoleKey.D2:
                Console.Clear();
                Console.WriteLine();
                Console.WriteLine("2 WAS PRESSED");
                break;
            case ConsoleKey.D3:
                Console.Clear();
                Console.WriteLine();
                Console.WriteLine("3 WAS PRESSED");
                break;
            case ConsoleKey.D4:
                Console.Clear();
                Console.WriteLine();
                Console.WriteLine("4 WAS PRESSED");
                break;
            case ConsoleKey.D5:
                Console.Clear();
                Console.WriteLine();
                Console.WriteLine("5 WAS PRESSED");
                break;
            case ConsoleKey.D6:
                Console.Clear();
                Console.WriteLine();
                Console.WriteLine("6 WAS PRESSED");
                break;
            case ConsoleKey.D7:
                Console.Clear();
                Console.WriteLine();
                Console.WriteLine("7 WAS PRESSED");
                break;
            case ConsoleKey.D8:
                Console.Clear();
                showMenu();
                break;
            }
            } while (key != ConsoleKey.D9);
        }
    }
}