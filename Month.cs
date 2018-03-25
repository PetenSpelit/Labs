using System;
using System.Collections.Generic;

namespace Lab6
{
	public class Month
	{
		private List<String> months;
		private String monthReturn;

		public Month ()
		{
			this.months = new List<String>()
			{
				"January",
				"February",
				"March",
				"April",
				"May",
				"June",
				"July",
				"August",
				"September",
				"October",
				"November",
				"December"
			};
			this.monthReturn = "";
		}
		public String WhatMonth(int monthnum)
		{
			monthReturn = months [monthnum];
			return monthReturn;
		}
	}
}