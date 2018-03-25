using System;

namespace Labs
{
	public class Player
	{
		private bool hasDie; // Does the player have the die?
		private int result; // What did the player throw?
		private String name; //Name of the player

		public Player (String playerName) // Creates players
		{
			this.hasDie = false; //Does the player have the die?
			this.result = 0; // what did the player throw?
			this.name = playerName; // Name of the Player.
		}
		public void Throw(Die die) // Die object has to be passed to this object in order to call Roll() class
		{
			if (hasDie) { // 
				result = die.Roll ();
				Console.WriteLine(name + " has thrown: " + result);
			} else {
				Console.WriteLine ("This player does not have a die to throw.");
			}
		}
		public bool DiePosession
		{
			get { return hasDie; } //Returns a boolean. If true, player has the die. If false, they do not.
			set{ hasDie = true; } // Gives and takes away the die.
		}
	}
}

