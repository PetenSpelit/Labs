using System;

namespace Lab6
{
	public class Month
	{
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

		public Month ()
		{
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
		public String WhatMonth(int monthnum)
		{
			switch(monthnum)
			{
			case 1:
				month = january;
				return month;
			case 2:
				month = february;
				return month;
			case 3:
				month = march;
				return month;
			case 4:
				month = april;
				return month;
			case 5:
				month = may;
				return month;
			case 6:
				month = june;
				return month;
			case 7:
				month = july;
				return month;
			case 8:
				month = august;
				return month;
			case 9:
				month = september;
				return month;
			case 10:
				month = october;
				return month;
			case 11:
				month = november;
				return month;
			case 12:
				month = december;
				return month;
			}
			return month;
		}
	}
}