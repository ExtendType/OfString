using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtendType.OfString.Whitespace
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
		public static bool IsNotNullOrWhiteSpace(this string instance)
		{
			return !String.IsNullOrWhiteSpace(instance);
		}
		public static string IfNullOrEmpty(this string instance, string value)
		{
			string result = instance;
			if (String.IsNullOrEmpty(instance)) result = value;
			return result;
		}
		public static string IfNullOrEmpty(this string instance)
		{
			string result = instance;
			if (String.IsNullOrEmpty(instance)) result = String.Empty;
			return result;
		}
		public static string IfNullOrWhiteSpace(this string instance, string value)
		{
			string result = instance;
			if (String.IsNullOrWhiteSpace(instance)) result = value;
			return result;
		}
		public static string IfNullOrWhiteSpace(this string instance)
		{
			string result = instance;
			if (String.IsNullOrWhiteSpace(instance)) result = String.Empty;
			return result;
		}
	}
}
