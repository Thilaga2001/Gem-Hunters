using System;
namespace GemHunters
{


    public class Player
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Gem Hunters game setup complete.");
            Board board = new Board();
            board.Display();

            Game game = new Game();
            game.Start();
        }
    }
} 
