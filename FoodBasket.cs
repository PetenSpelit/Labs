using System;

namespace Lab6
{
	public class FoodBasket
	{
		private double price;
		private double increase;
		private double incEuro;

		public FoodBasket ()
		{
			this.price = 100;
			this.increase = 0.015;
			this.incEuro = 0;
		}
		public double PriceNow(int monthnum)
		{
			increase = 0.015 * monthnum;
			incEuro = price * increase;
			price += incEuro;
			return price;
		}
		public void Reset()
		{
			this.price = 100;
			this.increase = 0.015;
			this.incEuro = 0;
		}
	}
}

