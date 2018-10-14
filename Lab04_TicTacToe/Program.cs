using System;
using Lab04_TicTacToe.Classes;

namespace Lab04_TicTacToe
{
	class Program
	{
		static void Main(string[] args)
		{
            PlayGame();
		}

        /// <summary>
        /// Game logic - the sequence of steps for TicTacToe
        /// </summary>
		static void PlayGame()
		{
            // DONE: Instantiate your players
            Console.WriteLine("Hello! Let's play TicTacToe");
            Console.Write("Player one's name: ");
            Player player1 = new Player()
            {
                Name = Console.ReadLine(),
                Marker = "X",
                IsTurn = true
            };
            Console.Write("Player two's name: ");
            Player player2 = new Player()
            {
                Name = Console.ReadLine(),
                Marker = "X",
                IsTurn = true
            };
			// Create the Game
            Game game = new Game(player1, player2);
			// Play the Game
            Player winner = game.Play();
            // Output the winner
            Console.WriteLine($"{winner.Name} wins!");
		}
	}
}
