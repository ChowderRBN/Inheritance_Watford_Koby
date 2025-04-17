using System; // Using system for basic console functionality

namespace Inheritance_Watford_Koby // Must match the namespace of other classes
{
    class FPS : Game1 // Inherits from Game1 (base class)
    {
        public FPS(string esrbParam, string titleParam) : base(esrbParam, titleParam) // Calls base constructor
        {
            // No extra logic needed here — the base class already assigns values
        }

        public override string Describe() // Required override of the abstract method
        {
            return $"{Title} is a FPS game rated {Esrb}!"; // Returns a string that describes the game
        }
    }
}
