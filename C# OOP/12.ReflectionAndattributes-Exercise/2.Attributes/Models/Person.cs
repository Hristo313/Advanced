﻿using _2.Attributes.Attributes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace _2.Attributes.Models
{
	public class Person
	{
		private const int MIN_AGE = 12;
		private const int MAX_AGE = 90;

		public Person(string fullName, int age)
		{
			this.FullName = fullName;
			this.Age = age;
		}

		[MyRequired]
		public string FullName { get; set; }

		[MyRange(MIN_AGE, MAX_AGE)]
		public int Age { get; set; }
	}
}
