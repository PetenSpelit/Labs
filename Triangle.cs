using System;

namespace Lab10
{
	public class Triangle
	{
		private int baseSize;

		public Triangle (int size)
		{
			this.baseSize = size;
		}

		public void TriangleDraw ()
		{
			for (int i = 0; i < baseSize; i++) {
				DrawStar (i);
				Console.WriteLine ("");
			}
		}

		public void ChristmasTree ()
		{
			int spaces = baseSize;
			for (int j = 0; j < baseSize; j++) {
				for (int i = 0; i < spaces; i++) {
					Console.Write (" ");
				}
				DrawStar (j);
				DrawStar (j-1);
				Console.WriteLine ("");
				spaces--;
			}
			for (int i = 0; i < 3; i++) {
				for (int j = 0; j < baseSize - 1; j++) {
					Console.Write (" ");
				}
				DrawStar (2);
				Console.WriteLine ("");
			}
		}

		private void DrawStar (int count)
		{
			for (int i = 0; i <= count; i++) {
				Console.Write ("*");
			}
		}
	}
}

