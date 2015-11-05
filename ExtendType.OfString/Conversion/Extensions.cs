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
		/// Parse string as boolean or default, false if none
		/// </summary>
		public static bool AsBoolOrDefault(this string instance, bool? @default = null)
		{
			bool result = @default.GetValueOrDefault();
			if (!String.IsNullOrWhiteSpace(instance) && !Boolean.TryParse(instance, out result)) result = @default.GetValueOrDefault();
			return result;
		}
		/// <summary>
		/// Parse string as boolean or null
		/// </summary>
		public static bool? AsBoolOrNull(this string instance)
		{
			bool result = false;
			if (String.IsNullOrWhiteSpace(instance) || !Boolean.TryParse(instance, out result)) return null;
			return result;
		}

		/// <summary>
		/// Parse string as byte or default, 0 if none
		/// </summary>
		public static byte AsByteOrDefault(this string instance, byte? @default = null)
		{
			byte result = @default.GetValueOrDefault();
			if (!String.IsNullOrWhiteSpace(instance) && !Byte.TryParse(instance, out result)) result = @default.GetValueOrDefault();
			return result;
		}
		/// <summary>
		/// Parse string as byte or null
		/// </summary>
		public static byte? AsByteOrNull(this string instance)
		{
			byte result = 0;
			if (String.IsNullOrWhiteSpace(instance) || !Byte.TryParse(instance, out result)) return null;
			return result;
		}
	
		/// <summary>
		/// Parse string as short or default, 0 if none
		/// </summary>
		public static short AsShortOrDefault(this string instance, short? @default = null)
		{
			short result = @default.GetValueOrDefault();
			if (!String.IsNullOrWhiteSpace(instance) && !Int16.TryParse(instance, out result)) result = @default.GetValueOrDefault();
			return result;
		}
		/// <summary>
		/// Parse string as short or null
		/// </summary>
		public static short? AsShortOrNull(this string instance)
		{
			short result = 0;
			if (String.IsNullOrWhiteSpace(instance) || !Int16.TryParse(instance, out result)) return null;
			return result;
		}
		
		/// <summary>
		/// Parse string as int or default, 0 if none
		/// </summary>
		public static int AsIntOrDefault(this string instance, int? @default = null)
		{
			int result = @default.GetValueOrDefault();
			if (!String.IsNullOrWhiteSpace(instance) && !Int32.TryParse(instance, out result)) result = @default.GetValueOrDefault();
			return result;
		}
		/// <summary>
		/// Parse string as int or null
		/// </summary>
		public static int? AsIntOrNull(this string instance)
		{
			int result = 0;
			if (String.IsNullOrWhiteSpace(instance) || !Int32.TryParse(instance, out result)) return null;
			return result;
		}

		/// <summary>
		/// Parse string as float or default, 0.0 if none
		/// </summary>
		public static float AsFloatOrDefault(this string instance, float? @default = null)
		{
			float result = @default.GetValueOrDefault();
			if (!String.IsNullOrWhiteSpace(instance) && !Single.TryParse(instance, out result)) result = @default.GetValueOrDefault();
			return result;
		}
		/// <summary>
		/// Parse string as float or null
		/// </summary>
		public static float? AsFloatOrNull(this string instance)
		{
			float result = Single.NaN;
			if (String.IsNullOrWhiteSpace(instance) || !Single.TryParse(instance, out result)) return null;
			return result;
		}

		/// <summary>
		/// Parse string as double or default, 0.0 if none
		/// </summary>
		public static double AsDoubleOrDefault(this string instance, double? @default = null)
		{
			double result = @default.GetValueOrDefault();
			if (!String.IsNullOrWhiteSpace(instance) && !Double.TryParse(instance, out result)) result = @default.GetValueOrDefault();
			return result;
		}
		/// <summary>
		/// Parse string as double or null
		/// </summary>
		public static double? AsDoubleOrNull(this string instance)
		{
			double result = Double.NaN;
			if (String.IsNullOrWhiteSpace(instance) || !Double.TryParse(instance, out result)) return null;
			return result;
		}

		/// <summary>
		/// Parse string as decimal or default, 0.0 if none
		/// </summary>
		public static decimal AsDecimalOrDefault(this string instance, decimal? @default = null)
		{
			decimal result = @default.GetValueOrDefault();
			if (!String.IsNullOrWhiteSpace(instance) && !Decimal.TryParse(instance, out result)) result = @default.GetValueOrDefault();
			return result;
		}
		/// <summary>
		/// Parse string as decimal or null
		/// </summary>
		public static decimal? AsDecimalOrNull(this string instance)
		{
			decimal result = Decimal.Zero;
			if (String.IsNullOrWhiteSpace(instance) || !Decimal.TryParse(instance, out result)) return null;
			return result;
		}

		/// <summary>
		/// Parse string as date time or default, DateTime.MinValue if none
		/// </summary>
		public static DateTime AsDateTimeOrDefault(this string instance, DateTime? @default = null)
		{
			DateTime result = @default.GetValueOrDefault();
			if (!String.IsNullOrWhiteSpace(instance) && !DateTime.TryParse(instance, out result)) result = @default.GetValueOrDefault();
			return result;
		}
		/// <summary>
		/// Parse string as date time or null
		/// </summary>
		public static DateTime? AsDateTimeOrNull(this string instance)
		{
			DateTime result = DateTime.MinValue;
			if (String.IsNullOrWhiteSpace(instance) || !DateTime.TryParse(instance, out result)) return null;
			return result;
		}

		/// <summary>
		/// Parse timespan or default, TimeSpan.Zero if none
		/// </summary>
		public static TimeSpan AsTimeSpanOrDefault(this string instance, TimeSpan? @default = null)
		{
			TimeSpan result = @default.GetValueOrDefault();
			if (!String.IsNullOrWhiteSpace(instance) && !TimeSpan.TryParse(instance, out result)) result = @default.GetValueOrDefault();
			return result;
		}
		/// <summary>
		/// Parse timespan or null
		/// </summary>
		public static TimeSpan? AsTimeSpanOrNull(this string instance)
		{
			TimeSpan result = TimeSpan.Zero;
			if (String.IsNullOrWhiteSpace(instance) || !TimeSpan.TryParse(instance, out result)) return null;
			return result;
		}

		/// <summary>
		/// Parse string as Enum or default
		/// </summary>
		/// <remarks>
		/// Generic type constraint is only limited to structs as an enum type is not allowed as a generic constraint. 
		/// </remarks>
		public static T AsEnumOrDefault<T>(this string instance, T? @default = null)
			where T : struct
		{
			T result = @default.GetValueOrDefault();
			if (String.IsNullOrWhiteSpace(instance) || !Enum.TryParse<T>(instance, out result)) return default(T);
			return result;

		}
		/// <summary>
		/// Parse string as enum or null
		/// </summary>
		public static T? AsEnumOrNull<T>(this string instance)
			where T : struct
		{
			T result = default(T);
			if (String.IsNullOrWhiteSpace(instance) || !Enum.TryParse<T>(instance, out result)) return null;
			return result;
		}
	}
}