using System;
using Xunit;
using Lab04_TicTacToe;
using Lab04_TicTacToe.Classes;

namespace Lab04_TicTacToeTests
{
    public class UnitTest1
    {
        [Fact]
        public void WinnerNotExistsForBlankBoard()
        {
            string[,] board = new string[,] { { "1", "2", "3" }, { "4", "5", "6" }, { "7", "8", "9" } };
            Game game = new Game(new Player() { }, new Player() { });
            game.Board.GameBoard = board;
            Assert.False(game.CheckForWinner(game.Board));
        }
        [Fact]
        public void WinnerXForDiagonal()
        {
            string[,] board = new string[,] { { "X", "2", "3" }, { "4", "X", "6" }, { "7", "8", "X" } };
            Game game = new Game(new Player() { }, new Player() { });
            game.Board.GameBoard = board;
            Assert.True(game.CheckForWinner(game.Board));
        }
        [Fact]
        public void WinnerNotExistsForDraw()
        {
            string[,] board = new string[,] { { "X", "O", "X" }, { "O", "X", "O" }, { "O", "X", "O" } };
            Game game = new Game(new Player() { }, new Player() { });
            game.Board.GameBoard = board;
            Assert.False(game.CheckForWinner(game.Board));
        }
        [Fact]
        public void CanSwitchToPlayerTwo()
        {
            Player player1 = new Player() { Name = "One", IsTurn = true };
            Player player2 = new Player() { Name = "Two", IsTurn = false };
            Game game = new Game(player1, player2);
            game.SwitchPlayer();
            Assert.False(player1.IsTurn);
            Assert.True(player2.IsTurn);
        }
        [Fact]
        public void CanReturnCurrentPlayer()
        {
            Player player1 = new Player() { Name = "One", IsTurn = true };
            Player player2 = new Player() { Name = "Two", IsTurn = false };
            Game game = new Game(player1, player2);
            Assert.Equal(player1.Name, game.NextPlayer().Name);
        }
        [Theory]
        [InlineData(1, 0, 0)] 
        [InlineData(5, 1, 1)] 
        [InlineData(9, 2, 2)] 
        [InlineData(2, 0, 1)] 
        public void OnScreenPosEqualsRealBoard(int onscreenValue, int expectedRow, int expectedColumn)
        {
            Assert.Equal(expectedRow, Player.PositionForNumber(onscreenValue).Row);
            Assert.Equal(expectedColumn, Player.PositionForNumber(onscreenValue).Column);
        }

    }
}
