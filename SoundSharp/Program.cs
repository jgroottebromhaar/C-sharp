using System;

namespace SoundSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Login();
            Console.ReadLine();
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
            int tries = 2;

            do
            {
                password = Console.ReadLine();
                switch (password == pass)
                {
                    case true:
                        Console.WriteLine("Correct password");
                        Console.WriteLine("Welkom bij SoundSharp " + name);
                        Console.ReadLine();
                        break;
                    case false:
                        Console.WriteLine("Wrong password");
                        //schaap
                        break;
                    default:
                        Console.WriteLine("Piss off mate!");
                        break;
                }
                tries++;
            } while (tries < 4);
            Console.ReadLine();
        }
    }
}