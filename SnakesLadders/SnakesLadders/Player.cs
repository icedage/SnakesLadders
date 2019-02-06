using SnakesLadders.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace SnakesLadders
{
    class Player : State
    {
        public Player(Game game)
        {
            this.Game = game;
            Start();
        }

        public override void GameOver()
        {
            this.Position = 0;
        }

        public override void MoveToken(int index)
        {
            if (this.Position + index > 10)
            {
                this.GameState = Enumerations.GameState.GameLost;
                this.Position += index;
            }

            else if (this.Position + index == 10)
            {
                this.GameState = Enumerations.GameState.GameWon;
                this.Board[index] = true;
                this.Position += index;
            }
            else
            {
                this.Board[index] = true;
                this.Position += index;
            }
        }

        public override void RollDice()
        {
            var digitService = new DigitService();
            var number = digitService.GetDigit();
            MoveToken(number);
        }

        private void Start()
        {
            this.Board = new bool[10];
            this.Board[0] = true;
            this.Position = 1;
            this.GameState = Enumerations.GameState.GameStart;
        }
    }
}
