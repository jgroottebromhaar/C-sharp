using System;

namespace SoundSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            string nameString;
            Console.WriteLine("Username");
            nameString = Console.ReadLine();
            Console.WriteLine("Welkom bij SoundSharp " + nameString);
            Console.ReadLine();
        }
    }
}
