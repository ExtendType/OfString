using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtendType.OfString.Trimming
{
	public static class Extensions
	{
		/// <summary>
		/// Trim the end of the string using the provided suffix string
		/// </summary>
		/// <param name="instance">Any string</param>
		/// <param name="suffix">Any string of characters</param>
		/// <returns>The trimmed string</returns>
		public static string TrimEnd(this string instance, string suffix)
		{
			if (!String.IsNullOrWhiteSpace(instance) && !String.IsNullOrWhiteSpace(suffix) && instance.EndsWith(suffix))
			{
				if (instance.Length == suffix.Length) instance = String.Empty;
				else instance = instance.Substring(0, instance.Length - suffix.Length);
			}
			return instance;
		}

		/// <summary>
		/// Trim the start of the string using the provided suffix string
		/// </summary>
		/// <param name="instance">Any string</param>
		/// <param name="suffix">Any string of characters</param>
		/// <returns>The trimmed string</returns>
		public static string TrimStart(this string instance, string prefix)
		{
			if (!String.IsNullOrWhiteSpace(instance) && !String.IsNullOrWhiteSpace(prefix) && instance.StartsWith(prefix))
			{
				if (instance.Length == prefix.Length) instance = String.Empty;
				else instance = instance.Substring(prefix.Length, instance.Length - prefix.Length);
			}
			return instance;
		}

		/// <summary>
		/// Constrain the string to the length provided 
		/// </summary>
		/// <param name="instance">Any string</param>
		/// <param name="length">A positive integer indicating maximum length of string</param>
		/// <returns>The string constrained to the length provided</returns>
		public static string Constrain(this string instance, int length)
		{
			Contract.Requires<ArgumentOutOfRangeException>(length >= 0);
			if (!String.IsNullOrEmpty(instance) && instance.Length > length) instance = instance.Substring(0, length);
			return instance;
		}
	}
}
