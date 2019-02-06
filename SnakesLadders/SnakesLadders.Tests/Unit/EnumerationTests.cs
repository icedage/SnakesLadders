using NUnit.Framework;
using SnakesLadders.Enumerations;
using System.Linq;

namespace SnakesLadders.Tests.Unit
{
    [TestFixture]
    public class EnumerationTests
    {
        [Test]
        public void GameState_GameStart_Name_Should_Be_GameStart()
        {
            var gameState = GameState.GameStart;

            Assert.AreEqual(1, gameState.Id);
            Assert.AreEqual("Game Start", gameState.Name);
        }

        [Test]
        public void GameState_GameEnd_Name_Should_Be_GameOver()
        {
            var gameState = GameState.GameOver;

            Assert.AreEqual(2, gameState.Id);
            Assert.AreEqual("Game Over", gameState.Name);
        }

        [Test]
        public void Enumeration_GetAll_Should_Return_All_Types()
        {
            var types = Enumeration.GetAll<GameState>();
            Assert.NotNull(types);
            Assert.That(types.Count() == 4);
        }
    }
}
