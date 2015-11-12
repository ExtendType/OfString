using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ExtendType.OfString.Parsing
{
	public static class Extensions
	{
		public static string ToAlphabetic(this string instance, char[] include = null, char[] exclude = null)
		{
			if (instance == null) return instance;
			StringBuilder result = new StringBuilder();
			foreach (char c in instance) if (Char.IsLetter(c) || (include != null && include.Contains(c)) || (exclude != null && !exclude.Contains(c))) result.Append(c);
			return result.ToString();
		}
		public static string ToNumeric(this string instance, char[] include = null, char[] exclude = null)
		{
			if (instance == null) return instance;
			StringBuilder result = new StringBuilder();
			foreach (char c in instance) if (Char.IsNumber(c) || (include != null && include.Contains(c)) || (exclude != null && !exclude.Contains(c))) result.Append(c);
			return result.ToString();
		}

		public static string ToAlphaNumeric(this string instance, char[] include = null, char[] exclude = null)
		{
			if (instance == null) return instance;
			StringBuilder result = new StringBuilder();
			foreach (char c in instance) if (Char.IsLetter(c) || Char.IsNumber(c) || (include != null && include.Contains(c)) || (exclude != null && !exclude.Contains(c))) result.Append(c);
			return result.ToString();

		}

	}
}
