using System;

namespace Lab10
{
	class MainClass
	{
		public static void Main (String[] args)
		{
			int userInput;
			Console.WriteLine ("Give height");
			Int32.TryParse (Console.ReadLine (), out userInput);
			Triangle tri = new Triangle (userInput);
			tri.ChristmasTree ();
		}
	}
}
