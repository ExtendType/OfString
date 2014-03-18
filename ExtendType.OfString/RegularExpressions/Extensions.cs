using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ExtendType.OfString.RegularExpressions
{
	public static class Extensions
	{
		/// <summary>
		/// To regular expression pattern
		/// </summary>
		public static Regex ToRegex(this string instance, RegexOptions options)
		{
			Regex result = null;
			if (instance != null)
			{
				result = new Regex(instance, options);
			}
			return result;
		}

		/// <summary>
		/// Converts string to regular expression
		/// </summary>
		public static Regex ToRegex(this string instance)
		{
			return ToRegex(instance, RegexOptions.None);
		}

		/// <summary>
		/// Converts a file system wild card pattern to a regular expression
		/// </summary>
		public static Regex ToWildcard(this string wildcard)
		{
			return String.Concat('^', Regex.Escape(wildcard).Replace("\\?", ".").Replace("\\*", ".*"), '$').ToRegex();
		}

		/// <summary>
		/// Match the string to a regular expression pattern
		/// </summary>
		public static bool IsMatch(this string instance, string pattern, RegexOptions options)
		{
			return instance != null && Regex.IsMatch(instance, pattern, options);
		}

		/// <summary>
		/// Match the string to a regular expression pattern
		/// </summary>
		public static bool IsMatch(this string instance, string pattern)
		{
			return IsMatch(instance, pattern, RegexOptions.None);
		}
	}
}
