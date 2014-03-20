using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtendType.OfString.Capitalizaton
{
	public static class Extensions
	{
		public static bool IsAnyInvariantCaseEqual(this string instance, string value)
		{
			return String.Equals(instance, value, StringComparison.InvariantCultureIgnoreCase);
		}
		public static bool IsAnyCaseEqual(this string instance, string value)
		{
			return String.Equals(instance, value, StringComparison.CurrentCultureIgnoreCase);
		}
		public static bool IsCaseEqual(this string instance, string value)
		{
			return String.Equals(instance, value, StringComparison.CurrentCulture);
		}
		public static bool IsInvariantCaseEqual(this string instance, string value)
		{
			return String.Equals(instance, value, StringComparison.InvariantCulture);
		}		
	}
}
