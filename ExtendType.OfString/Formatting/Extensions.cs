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
		/// A shortcut method to using System.Format string
		/// </summary>
		public static string FormatWith(this string instance, params object[] args)
		{
			string result = instance;
			if (!String.IsNullOrWhiteSpace(instance)) result = String.Format(instance, args);
			return result;
		}
		/// <summary>
		/// A shortcut method to using System.Format string
		/// </summary>
		public static string FormatWith(this string instance, IFormatProvider provider, params object[] args)
		{
			string result = instance;
			if (!String.IsNullOrWhiteSpace(instance)) result = String.Format(provider, instance, args);
			return result;
		}
	}
}
