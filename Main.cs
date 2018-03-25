using System;

namespace Labs
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Die die = new Die (6); //Produces the die
			Player player1 = new Player("player1"); //Produces a the first player

			Console.WriteLine ("Welcome to play");

			player1.DiePosession = true; //Passes the die to the first player
			while(!die.All()){
			player1.Throw(die);	//Player 1 throws a die
			}
			Console.WriteLine ("All possible numbers have been thrown.");
			player1.DiePosession = false; // Takes the die away from Player 1

		}
	}
}
