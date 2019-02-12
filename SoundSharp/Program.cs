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
            Console.WriteLine("Welkom bij SoundSharp " + nameString);
            Console.WriteLine("Password");
            pass = Console.ReadLine();
            Login(pass, nameString);
        }

        static void Login(string password, string username)
        {
            string pass = "SHARPSOUND";

            switch (password == pass)
            {
                case true:
                    Console.WriteLine("Correct password");
                    break;
                case false:
                    Console.WriteLine("Wrong password dickhead");
                    break;
                default:
                    Console.WriteLine("Piss off mate!");
                    break;
            }
            Console.ReadLine();
        }
    }
}