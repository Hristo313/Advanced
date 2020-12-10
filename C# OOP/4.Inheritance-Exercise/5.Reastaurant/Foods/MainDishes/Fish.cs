﻿using System;
using System.Collections.Generic;
using System.Text;

namespace _5.Reastaurant.Foods.MainDishes
{
	public class Fish : MainDish
	{
		private const double GRAMS = 22;

		public Fish(string name, decimal price)
			: base(name, price, GRAMS)
		{
		}
	}
}
