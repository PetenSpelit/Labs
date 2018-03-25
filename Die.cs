using System;
using System.Collections.Generic;

namespace Labs
{
	public class Die
	{
		private int result;
		private Random rng;
		private int facets; //How many facets does the die have?
		private List<int> numbers;
		private bool full;

		public Die (int dieFacets) // Needs the number of facets the die has. What kind of die do you want to use?
		{
			this.result = 0;
			this.rng = new Random(); 
			this.facets = dieFacets; // how many facets does the die have?
			this.numbers = new List<int>();
			this.full = false;
		}

		public bool All()
		{
			return full;
		}

		public int Roll()
		{
			result = rng.Next (1, facets+1);
			//if (result == facets+1) {
				//result = 0;
			//}
			if (!numbers.Contains (result)) {
				numbers.Add (result);
			}
			if (numbers.Count == 6) {
				full = true;
			}
			return result;
		}
	}
}

