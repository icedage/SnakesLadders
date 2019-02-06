using NUnit.Framework;
using SnakesLadders.Enumerations;
using System;
using System.Collections.Generic;
using System.Text;

namespace SnakesLadders.Tests.Integration
{
    [TestFixture]
    public class GameTests
    {
        [Test]
        public void Token_Should_Be_On_Square_1_When_Game_Starts()
        {
            var game = new Game();
            var tokenPosition = game.GetTokenPosition();
            Assert.AreEqual(1, 1);
        }

        [Test]
        public void Token_Should_Be_On_Right_Square_When_Moved()
        {
            //First move
            var game = new Game();
            int index = 3;
            int squareNumber = 4;
            game.Play(index);
            var tokenPosition = game.GetTokenPosition();
            Assert.AreEqual(tokenPosition, squareNumber);

            //second Move
            index = 4;
            squareNumber = 8;
            game.Play(index);
            tokenPosition = game.GetTokenPosition();
            Assert.AreEqual(tokenPosition, squareNumber);
        }

        [TestCase]
        public void Play_Game__With_GameLost_Flow()
        {
            var game = new Game();
            int index = 5;
            game.Play(index);

            var gameState = game.AreWeStillPlaying();
            Assert.IsTrue(gameState);

            index = 6;
            game.Play(index);
            gameState = game.AreWeStillPlaying();
            var result = game.GetResult();
            Assert.IsFalse(gameState);
            Assert.AreEqual(GameState.GameLost, result.Result);
            Assert.That(result.Index > 10);
         }

        [TestCase]
        public void Play_Game__With_GameWon_Flow()
        {
            var game = new Game();
            int index = 5;
            game.Play(index);

            var gameState = game.AreWeStillPlaying();
            Assert.IsTrue(gameState);

            index = 4;
            game.Play(index);
            gameState = game.AreWeStillPlaying();
            var result = game.GetResult();
            Assert.IsFalse(gameState);
            Assert.AreEqual(GameState.GameWon, result.Result);
            Assert.That(result.Index == 10);
        }
    }
}
