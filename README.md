# SnakesLadders

A console app for snakes and ladders - feature 1.
http://agilekatas.co.uk/katas/SnakesAndLadders-Kata

The Program.cs calls the RollDice function, which is driven by clicking Enter.
The Board is intialised with 10 squares, instead of 100 to make demos easier.

You can see the flow of the game for success and failure scenarios by using the integration tests.
Play_Game__With_GameWon_Flow() test presents a flow for success and Play_Game__With_GameLost_Flow() for failure.
They are calling directily the MoveToken function, where we pass the number of spaces. 
The MoveToken function is also called by RollDice with a random number (range from 1 to 6). this is called by Program.cs.
The idea is to write an integration test, where we can repeatedly call MoveToken with a number of our choice (instead of a random one), until we fail or win the game. RollDice internally calls MoveToken

The solution is using State pattern, in case we want to extend and add more players.
