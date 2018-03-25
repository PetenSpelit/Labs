using System;

namespace Lab5
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			FoodBasket basket = new FoodBasket ();
			Month mon = new Month ();

			for (int i = 1; i < 12; i++) {
				Console.WriteLine ("The price of a FoodBasket in " + mon.WhatMonth(i) + " is " + basket.PriceNow (i));
			}
		}
	}
}
