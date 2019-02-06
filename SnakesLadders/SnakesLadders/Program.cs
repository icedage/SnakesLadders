using SnakesLadders.Enumerations;
using System;

namespace SnakesLadders
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***Game Start**");

            var newGame = new Game();
            var result = true;
            var answer = string.Empty;
            do
            {
                Console.WriteLine("Press Enter to roll the dice.");
                answer = Console.ReadKey().ToString();
                newGame.RollDice();

                result = newGame.AreWeStillPlaying();
                Console.WriteLine("\n");
                Console.WriteLine($"Token is in position {newGame.GetTokenPosition()}");

            } while (result);

            var gameResult = newGame.GetResult();
            if (gameResult.Result == GameState.GameWon)
                Console.ForegroundColor = ConsoleColor.Green;
            if (gameResult.Result == GameState.GameLost)
                Console.ForegroundColor = ConsoleColor.Red;

            Console.WriteLine($"Game Status: {gameResult.Result.Name}");
            Console.WriteLine($"Token at position: {gameResult.Index}");

            Console.Read();
        }
    }
}
