using System; // Gives access to built-in C# functionality like Console

namespace Inheritance_Watford_Koby // Declares a namespace to organize code
{
    abstract class Game1 // Abstract base class. Cannot be instantiated directly.
    {
        public string Esrb { get; set; } // Property for ESRB rating (E, T, M, etc.)
        public string Title { get; set; } // Property for the game's title

        public Game1(string esrbParam, string titleParam) // Constructor with two parameters
        {
            Esrb = esrbParam; // Assign ESRB value to property
            Title = titleParam; // Assign title value to property
        }

        public void PlayGame1() // A regular method to simulate starting the game
        {
            Console.WriteLine($"{Title} is Starting!"); // Prints "[Title] is Starting!" to console
        }

        public abstract string Describe(); // Abstract method that must be implemented in subclasses
    }
}
