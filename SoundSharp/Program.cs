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
                switch (password == pass)
                {
                    case true:
                        Console.WriteLine("Correct password");
                        Console.WriteLine("Welkom bij SoundSharp " + name);
                        break;
                    case false:
                        if (tries == 2)
                        {
                            Console.WriteLine("Wrong password poging 2 van 3");
                        } else if (tries == 3)
                        {
                            Console.WriteLine("Wrong password LET OP: Laatste poging!");
                        }
                        break;
                }
            } while (tries != 4);
        }
    }
}