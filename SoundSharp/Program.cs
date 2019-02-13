using System;

namespace SoundSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            string nameString;
            string pass;
            Console.WriteLine("Username");
            nameString = Console.ReadLine();
            Console.WriteLine("Password");
            pass = Console.ReadLine();
            Login(pass, nameString);
        }

        static void Login(string password, string username)
        {
            // Password checker
            string pass = "SHARPSOUND";
            string name = username;
            int tries = 1;

            while (tries < 3) {
                switch (password == pass)
                {
                    case true:
                        Console.WriteLine("Correct password");
                        Console.WriteLine("Welkom bij SoundSharp " + name);
                        Console.ReadLine();
                        break;
                    case false:
                        Console.WriteLine("Wrong password");
                        password = Console.ReadLine();
                        break;
                    default:
                        Console.WriteLine("Piss off mate!");
                        break;
                }
                tries++;
            }
        }
    }
}