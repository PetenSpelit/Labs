using System;

namespace VIIDES
{
	public class Months
	{
		private int monthnum;
		private String january;
		private String february;
		private String march;
		private String april;
		private String may;
		private String june;
		private String july;
		private String august;
		private String september;
		private String october;
		private String november;
		private String december;
		private String month;

		public Months ()
		{
			this.monthnum = 1;
			this.january = "January";
			this.february = "February";
			this.march = "March";
			this.april = "April";
			this.may = "May";
			this.june = "June";
			this.july = "July";
			this.august = "August";
			this.september = "September";
			this.october = "October";
			this.november = "November";
			this.december = "December";
			this.month = "";
		}
		public String Month()
		{
				switch (monthnum) 
				{
				case 1:
					month = january;
					monthnum++;
					break;
				case 2:
					month = february;
					monthnum++;
					break;
				case 3:
					month = march;
					monthnum++;
					break;
				case 4:
					month = april;
					monthnum++;
					break;
				case 5:
					month = may;
					monthnum++;
					break;
				case 6:
					month = june;
					monthnum++;
					break;
				case 7:
					month = july;
					monthnum++;
					break;
				case 8:
					month = august;
					monthnum++;
					break;
				case 9:
					month = september;
					monthnum++;
					break;
				case 10:
					month = october;
					monthnum++;
					break;
				case 11:
					month = november;
					monthnum++;
					break;
				case 12:
					month = december;
					break;
				}
			return month;
		}
	}
}

