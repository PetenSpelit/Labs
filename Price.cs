using System;

namespace VIIDES
{
	public class Price
	{
		private double price;
		private double rate;
		private int monthnum;
		Months months = new Months ();

		public Price ()
		{
			this.price = 100;
			this.rate = 1.015;
			this.monthnum = 1;
		}
		public void MonthlyPrice()
		{
			for (monthnum = 1; monthnum <= 12; monthnum++) 
			{
				Console.WriteLine ("Price in " + months.Month() + " is " + price);
				price = price * rate;
			}

		}
	}
}

