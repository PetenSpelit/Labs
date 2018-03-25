using System;

namespace Lab6
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			FoodBasket basket = new FoodBasket ();
			Month mon = new Month ();
			double over = 0;
			double price = 0;
			for (int i = 1; i <= 12; i++) {
				price = basket.PriceNow (i);
				Console.WriteLine ("The price of a foodbasket in " + mon.WhatMonth(i) + " is " + price);
				if (price > 105) {
					over = price - 105;
					Console.WriteLine ("The price of the foodbasket is over 105 euros by " + over + "\n");
				}
			}
		}
	}
}
