using System.Runtime.InteropServices;

namespace mini_game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your name: ");

            game g1 = new game("Player 1", "Zombie", 30, 30, 10);

            g1.print();
        }
    }
}