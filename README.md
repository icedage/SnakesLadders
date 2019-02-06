# SnakesLadders

A console app for snakes and ladders - feature 1.
http://agilekatas.co.uk/katas/SnakesAndLadders-Kata

The Program.cs calls the RoleDice function, which is driven by clicking Enter
The Board ues 10 squares instead of 100 to make the success/fail demos easier.

The integration tests present Success (Play_Game__With_GameWon_Flow()) and Failure(Play_Game__With_GameLost_Flow()) 
flows by using directily MoveToken function, where we pass the number of spaces. 
This function is also called my RoleDice with a random number (range from 1 to 6).
The idea is to write an integration test, where we can repeatedly control the flow by calling MoveToken, until we we fail or win the game.

The solution is using State pattern, in case we want to extend and add more players.
