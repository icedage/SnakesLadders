using System;
using System.Collections.Generic;
using System.Text;

namespace SnakesLadders.Enumerations
{
    public class GameState : Enumeration
    {
        public static GameState GameStart = new GameStateStart();
        public static GameState GameOver = new GameStateOver();
        public static GameState GameWon = new GameStateWon();
        public static GameState GameLost = new GameStateLost();

        protected GameState(int id, string name) : base(id, name)
        { }

        private class GameStateStart : GameState
        {
            public GameStateStart() : base(1, "Game Start")
            { }
        }

        private class GameStateOver : GameState
        {
            public GameStateOver() : base(2, "Game Over")
            { }
        }

        private class GameStateWon : GameState
        {
            public GameStateWon() : base(3, "Game Won")
            { }
        }

        private class GameStateLost : GameState
        {
            public GameStateLost() : base(4, "Game Lost")
            { }
        }
    }
}
