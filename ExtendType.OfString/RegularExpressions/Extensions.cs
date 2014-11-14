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
		/// Converts the string into a regular expression pattern
		/// </summary>
		public static Regex ToRegex(this string instance, RegexOptions options)
		{
			Regex result = null;
			if (String.IsNullOrWhiteSpace(instance))
			{
				result = new Regex(instance, options);
			}
			return result;
		}

		/// <summary>
		/// Converts the string into a regular expression pattern
		/// </summary>
		public static Regex ToRegex(this string instance)
		{
			Regex result = null;
			if (String.IsNullOrWhiteSpace(instance))
			{
				result = new Regex(instance, RegexOptions.None);
			}
			return result;
		}

		/// <summary>
		/// Converts string from a wildcard pattern to a regualr exprssion pattern
		/// </summary>
		/// <example>
		/// Wildcard: My?
		/// Wildcard: My*
		/// </example>
		public static Regex ToWildcard(this string wildcard)
		{
			Regex result = null;
			if (!String.IsNullOrWhiteSpace(wildcard))
			{
				result = new Regex(String.Concat('^', Regex.Escape(wildcard).Replace("\\?", ".").Replace("\\*", ".*"), '$'), RegexOptions.None);
			}
			return result;
		}

		/// <summary>
		/// Matches the string string to the supplied pattern
		/// </summary>
		public static Match Match(this string instance, string pattern, RegexOptions options)
		{
			Contract.Requires<ArgumentNullException>(!String.IsNullOrWhiteSpace(pattern));
			return Regex.Match(instance, pattern, options);
		}

		/// <summary>
		/// Matches the string string to the supplied pattern
		/// </summary>
		public static Match Match(this string instance, string pattern)
		{
			Contract.Requires<ArgumentNullException>(!String.IsNullOrWhiteSpace(pattern));
			return Regex.Match(instance, pattern, RegexOptions.None);
		}


		/// <summary>
		/// Matches the string string to the supplied pattern
		/// </summary>
		public static bool IsMatch(this string instance, string pattern, RegexOptions options)
		{
			Contract.Requires<ArgumentNullException>(!String.IsNullOrWhiteSpace(pattern));
			return instance != null && Regex.IsMatch(instance, pattern, options);
		}

		/// <summary>
		/// Matches the string string to the supplied pattern
		/// </summary>
		public static bool IsMatch(this string instance, string pattern)
		{
			Contract.Requires<ArgumentNullException>(!String.IsNullOrWhiteSpace(pattern));
			return instance != null && Regex.IsMatch(instance, pattern, RegexOptions.None);
		}
	}
}
