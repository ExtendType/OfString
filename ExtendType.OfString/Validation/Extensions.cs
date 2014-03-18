using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtendType.OfString.Validation
{
	public static class Extensions
	{
		/// <summary>
		/// Provides a shortcut method to using String.IsNullOrEmpty
		/// </summary>
		/// <param name="instance">The string to be validated</param>
		/// <returns>True if the string is null or empty false if not</returns>
		public static bool IsNullOrEmpty(this string instance)
		{
			return String.IsNullOrEmpty(instance);
		}
		/// <summary>
		/// Provides a shortcut method to using String.IsNullOrWhitespace
		/// </summary>
		/// <param name="instance">The string to be validated</param>
		/// <returns>True if the string is null, empty or contains whitespace false if not</returns>
		public static bool IsNullOrWhiteSpace(this string instance)
		{
			return String.IsNullOrWhiteSpace(instance);
		}
		/// <summary>
		/// Provides a shortcut method to using String.IsNullOrEmpty
		/// </summary>
		/// <param name="instance">The string to be validated</param>
		/// <returns>False if the string is null or empty true if not</returns>
		public static bool IsNotNullOrEmpty(this string instance)
		{
			return !String.IsNullOrEmpty(instance);
		}
		/// <summary>
		/// Provides a shortcut method to using String.IsNullOrWhitespace
		/// </summary>
		/// <param name="instance">The string to be validated</param>
		/// <returns>False if the string is null, empty or contains whitespace true if not</returns>
		public static bool IsNotNullOrWhitespace(this string instance)
		{
			return !String.IsNullOrWhiteSpace(instance);
		}
	}
}
