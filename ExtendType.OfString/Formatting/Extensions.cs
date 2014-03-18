using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtendType.OfString.Formatting
{
	public static class Extensions
	{
		/// <summary>
		/// A convenience shortcut to using System.Format string
		/// </summary>
		/// <param name="instance">The string to apply the format to</param>
		/// <param name="args">Arguments to apply in the format</param>
		/// <returns>Returns a string or null if the instance provided was null</returns>
		public static string FormatWith(this string instance, params object[] args)
		{
			string result = instance;
			if (!String.IsNullOrWhiteSpace(instance)) result = String.Format(instance, args);
			return result;
		}
		/// <summary>
		/// A convenience shortcut to using System.Format string
		/// </summary>
		/// <param name="instance">The string to apply the format to</param>
		/// <param name="provider">the format provider to be used against string</param>
		/// <param name="args">Arguments to apply in the format</param>
		/// <returns>Returns a string or null if the instance provided was null</returns>
		public static string FormatWith(this string instance, IFormatProvider provider, params object[] args)
		{
			string result = instance;
			if (!String.IsNullOrWhiteSpace(instance)) result = String.Format(provider, instance, args);
			return result;
		}
	}
}
