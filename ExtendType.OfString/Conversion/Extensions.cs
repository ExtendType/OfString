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
			if (!String.IsNullOrWhiteSpace(instance)) if (!Boolean.TryParse(instance, out result)) result = @default.GetValueOrDefault();
			return result;
		}
		/// <summary>
		/// A shortcut method to parsing a byte from a string
		/// </summary>
		public static byte AsByteOrDefault(this string instance, byte? @default = null)
		{
			byte result = @default.GetValueOrDefault();
			if (!String.IsNullOrWhiteSpace(instance)) if (!Byte.TryParse(instance, out result)) result = @default.GetValueOrDefault();
			return result;
		}
		/// <summary>
		/// A shortcut method to parsing a short from a string
		/// </summary>
		public static short AsShortOrDefault(this string instance, short? @default = null)
		{
			short result = @default.GetValueOrDefault();
			if (!String.IsNullOrWhiteSpace(instance)) if (!Int16.TryParse(instance, out result)) result = @default.GetValueOrDefault();
			return result;
		}
		/// <summary>
		/// A shortcut method to parsing a int from a string
		/// </summary>
		public static int AsIntOrDefault(this string instance, int? @default = null)
		{
			int result = @default.GetValueOrDefault();
			if (!String.IsNullOrWhiteSpace(instance)) if (!Int32.TryParse(instance, out result)) result = @default.GetValueOrDefault();
			return result;
		}
		/// <summary>
		/// A shortcut method to parsing a single or float from a string
		/// </summary>
		public static float AsFloatlOrDefault(this string instance, float? @default = null)
		{
			float result = @default.GetValueOrDefault();
			if (!String.IsNullOrWhiteSpace(instance)) if (!Single.TryParse(instance, out result)) result = @default.GetValueOrDefault();
			return result;
		}
		/// <summary>
		/// A shortcut method to parsing a double from a string
		/// </summary>
		public static double AsDoublelOrDefault(this string instance, double? @default = null)
		{
			double result = @default.GetValueOrDefault();
			if (!String.IsNullOrWhiteSpace(instance)) if (!Double.TryParse(instance, out result)) result = @default.GetValueOrDefault();
			return result;
		}
		/// <summary>
		/// A shortcut method to parsing a decimal from a string
		/// </summary>
		public static decimal AsDecimalOrDefault(this string instance, decimal? @default = null)
		{
			decimal result = @default.GetValueOrDefault();
			if (!String.IsNullOrWhiteSpace(instance)) if (!Decimal.TryParse(instance, out result)) result = @default.GetValueOrDefault();
			return result;
		}
		/// <summary>
		/// A shortcut method to parsing a date time from a string
		/// </summary>
		public static DateTime AsDateTimeOrDefault(this string instance, DateTime? @default = null)
		{
			DateTime result = @default.GetValueOrDefault();
			if (!String.IsNullOrWhiteSpace(instance)) if (!DateTime.TryParse(instance, out result)) result = @default.GetValueOrDefault();
			return result;
		}
		
	}
}
