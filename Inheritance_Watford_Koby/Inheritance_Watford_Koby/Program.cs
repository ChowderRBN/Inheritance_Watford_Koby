using System; // Needed to use Console methods

namespace Inheritance_Watford_Koby // Match the namespace so all classes are connected
{
    internal class Program // Main program class
    {
        static void Main(string[] args) // Main method — entry point of your program
        {
            FPS myGame = new FPS("M", "Call of Duty"); // Create a new FPS game object with title and ESRB
            Console.WriteLine(myGame.Describe()); // Print the game's description to the console
            myGame.PlayGame1(); // Call method to start the game, prints "[Title] is Starting!"
        }
    }
}
