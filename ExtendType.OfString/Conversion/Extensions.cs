using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtendType.OfString.Conversion
{
	public static class Extensions
	{
		/// <summary>
		/// A shortcut method to parsing a short from a string
		/// </summary>
		public static bool AsBoolOrDefault(this string instance, bool? @default = null)
		{
			bool result = @default.GetValueOrDefault();
			if (!String.IsNullOrWhiteSpace(instance) && !Boolean.TryParse(instance, out result)) result = @default.GetValueOrDefault();
			return result;
		}
		public static bool? AsBoolOrNull(this string instance)
		{
			bool result = false;
			if (String.IsNullOrWhiteSpace(instance) || !Boolean.TryParse(instance, out result)) return null;
			return result;
		}
		/// <summary>
		/// A shortcut method to parsing a byte from a string
		/// </summary>
		public static byte AsByteOrDefault(this string instance, byte? @default = null)
		{
			byte result = @default.GetValueOrDefault();
			if (!String.IsNullOrWhiteSpace(instance) && !Byte.TryParse(instance, out result)) result = @default.GetValueOrDefault();
			return result;
		}

		public static byte? AsByteOrNull(this string instance)
		{
			byte result = 0;
			if (String.IsNullOrWhiteSpace(instance) || !Byte.TryParse(instance, out result)) return null;
			return result;
		}
		/// <summary>
		/// A shortcut method to parsing a short from a string
		/// </summary>
		public static short AsShortOrDefault(this string instance, short? @default = null)
		{
			short result = @default.GetValueOrDefault();
			if (!String.IsNullOrWhiteSpace(instance) && !Int16.TryParse(instance, out result)) result = @default.GetValueOrDefault();
			return result;
		}
		public static short? AsShortOrNull(this string instance)
		{
			short result = 0;
			if (String.IsNullOrWhiteSpace(instance) || !Int16.TryParse(instance, out result)) return null;
			return result;
		}
		/// <summary>
		/// A shortcut method to parsing a int from a string
		/// </summary>
		public static int AsIntOrDefault(this string instance, int? @default = null)
		{
			int result = @default.GetValueOrDefault();
			if (!String.IsNullOrWhiteSpace(instance) && !Int32.TryParse(instance, out result)) result = @default.GetValueOrDefault();
			return result;
		}
		public static int? AsIntOrNull(this string instance)
		{
			int result = 0;
			if (String.IsNullOrWhiteSpace(instance) || !Int32.TryParse(instance, out result)) return null;
			return result;
		}
		/// <summary>
		/// A shortcut method to parsing a single or float from a string
		/// </summary>
		public static float AsFloatlOrDefault(this string instance, float? @default = null)
		{
			float result = @default.GetValueOrDefault();
			if (!String.IsNullOrWhiteSpace(instance) && !Single.TryParse(instance, out result)) result = @default.GetValueOrDefault();
			return result;
		}
		public static float? AsFloatlOrNull(this string instance)
		{
			float result = Single.NaN;
			if (String.IsNullOrWhiteSpace(instance) || !Single.TryParse(instance, out result)) return null;
			return result;
		}
		/// <summary>
		/// A shortcut method to parsing a double from a string
		/// </summary>
		public static double AsDoublelOrDefault(this string instance, double? @default = null)
		{
			double result = @default.GetValueOrDefault();
			if (!String.IsNullOrWhiteSpace(instance) && !Double.TryParse(instance, out result)) result = @default.GetValueOrDefault();
			return result;
		}
		public static double? AsDoublelOrNull(this string instance)
		{
			double result = Double.NaN;
			if (String.IsNullOrWhiteSpace(instance) || !Double.TryParse(instance, out result)) return null;
			return result;
		}
		/// <summary>
		/// A shortcut method to parsing a decimal from a string
		/// </summary>
		public static decimal AsDecimalOrDefault(this string instance, decimal? @default = null)
		{
			decimal result = @default.GetValueOrDefault();
			if (!String.IsNullOrWhiteSpace(instance) && !Decimal.TryParse(instance, out result)) result = @default.GetValueOrDefault();
			return result;
		}
		public static decimal? AsDecimalOrNull(this string instance)
		{
			decimal result = Decimal.Zero;
			if (String.IsNullOrWhiteSpace(instance) || !Decimal.TryParse(instance, out result)) return null;
			return result;
		}
		/// <summary>
		/// A shortcut method to parsing a date time from a string
		/// </summary>
		public static DateTime AsDateTimeOrDefault(this string instance, DateTime? @default = null)
		{
			DateTime result = @default.GetValueOrDefault();
			if (!String.IsNullOrWhiteSpace(instance) && !DateTime.TryParse(instance, out result)) result = @default.GetValueOrDefault();
			return result;
		}
		public static DateTime? AsDateTimeOrNull(this string instance)
		{
			DateTime result = DateTime.MinValue;
			if (String.IsNullOrWhiteSpace(instance) || !DateTime.TryParse(instance, out result)) return null;
			return result;
		}
		/// <summary>
		/// A shortcut method to parsing a timespan from a string
		/// </summary>
		public static TimeSpan AsTimeSpanOrDefault(this string instance, TimeSpan? @default = null)
		{
			TimeSpan result = @default.GetValueOrDefault();
			if (!String.IsNullOrWhiteSpace(instance) && !TimeSpan.TryParse(instance, out result)) result = @default.GetValueOrDefault();
			return result;
		}
		public static TimeSpan? AsDateTimeOrNull(this string instance)
		{
			TimeSpan result = TimeSpan.Zero;
			if (String.IsNullOrWhiteSpace(instance) || !TimeSpan.TryParse(instance, out result)) return null;
			return result;
		}



	}
}
