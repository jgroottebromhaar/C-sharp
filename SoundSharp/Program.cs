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
                    Console.WriteLine("Correct password");
                    Console.WriteLine("Welkom bij SoundSharp " + name);
                    showMenu();
                    break;
                } else if (tries == 2)
                {
                    Console.WriteLine("Wrong password poging 2 van 3");
                } else if (tries == 3)
                {
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
        }
    }
}