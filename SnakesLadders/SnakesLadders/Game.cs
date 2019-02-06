using SnakesLadders.Enumerations;
using System;
using System.Collections.Generic;
using System.Text;

namespace SnakesLadders
{
   public class GameResult
    {
        public GameState Result { get; set; }

        public int Index { get; set; }
    }

    public class Game
    {
        private State _state;

        public Game()
        {
             _state = new Player(this);
        }
        
        public void Play(int pos)
        {
            _state.MoveToken(pos);
        }

        public void RollDice()
        {
            _state.RollDice();
        }

        public GameResult GetResult()
        {
            var result = new GameResult();
            if (_state.GameState == GameState.GameLost)
            {
                result.Index = _state.Position;
                result.Result = GameState.GameLost;
                EndGame();
            }

            if (_state.GameState == GameState.GameWon)
            {
                result.Index = _state.Position;
                result.Result = GameState.GameWon;
                EndGame();
            }

            return result;
        }

        public bool AreWeStillPlaying()
        {
            return (_state.GameState != GameState.GameLost && _state.GameState!= GameState.GameWon);
        }


        public int GetTokenPosition()
        {
            return _state.Position;
        }

        public void EndGame()
        {
            _state.Board = new bool[100];
            _state.Position = 0;
            _state.GameState = GameState.GameOver;
        }
    }
}
