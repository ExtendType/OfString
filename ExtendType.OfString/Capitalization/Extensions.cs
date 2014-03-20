using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtendType.OfString.Capitalizaton
{
	public static class Extensions
	{
		/// <summary>
		/// Shortcut method to evaluating a strings invariant equality ignoring case
		/// </summary>
		public static bool IsAnyInvariantCaseEqual(this string instance, string value)
		{
			return String.Equals(instance, value, StringComparison.InvariantCultureIgnoreCase);
		}
		/// <summary>
		/// Shortcut method to evaluating a strings equality ignoring case
		/// </summary>
		public static bool IsAnyCaseEqual(this string instance, string value)
		{
			return String.Equals(instance, value, StringComparison.CurrentCultureIgnoreCase);
		}
		/// <summary>
		/// Shortcut method to evaluating a strings equality considering case
		/// </summary>
		public static bool IsCaseEqual(this string instance, string value)
		{
			return String.Equals(instance, value, StringComparison.CurrentCulture);
		}
		/// <summary>
		/// Shortcut method to evaluating an invariant strings equality considering case
		/// </summary>
		public static bool IsInvariantCaseEqual(this string instance, string value)
		{
			return String.Equals(instance, value, StringComparison.InvariantCulture);
		}		
	}
}
