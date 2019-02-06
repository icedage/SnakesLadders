using SnakesLadders.Enumerations;
using System;
using System.Collections.Generic;
using System.Text;

namespace SnakesLadders
{
    abstract class State
    {
        protected Game game;

        public Game Game
        {
            get { return game; }
            set { game = value; }
        }

        public bool[] Board { get; set; }

        public int Position { get; set; }

        public GameState GameState { get; set; }

        public abstract void MoveToken(int index);
        public abstract void RollDice();
        public abstract void GameOver();
    }
}