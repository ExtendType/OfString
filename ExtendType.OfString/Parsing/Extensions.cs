using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtendType.OfString.Parsing
{
	public static class Extensions
	{
		public static string ToAlphanumeric(this string instance, params char[] include)
		{
			if (instance == null) return instance;
			StringBuilder result = new StringBuilder();
			foreach (char c in instance) if (Char.IsLetter(c) || Char.IsNumber(c) || include.Any(p => p == c)) result.Append(c);
			return result.ToString();
		}
	}
}
