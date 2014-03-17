using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtendType.OfString.Validation
{
	public static class Extensions
	{
		public static bool IsNullOrEmpty(this string instance)
		{
			return String.IsNullOrEmpty(instance);
		}

		public static bool IsNullOrWhiteSpace(this string instance)
		{
			return String.IsNullOrWhiteSpace(instance);
		}

		public static bool IsNotNullOrEmpty(this string instance)
		{
			return !String.IsNullOrEmpty(instance);
		}

		public static bool IsNotNullOrWhitespace(this string instance)
		{
			return !String.IsNullOrWhiteSpace(instance);
		}
	}
}
