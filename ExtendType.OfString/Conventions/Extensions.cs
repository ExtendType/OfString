using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ExtendType.OfString.Conventions
{
	public static class Extensions
	{
		/// <summary>
		/// Converts supplied string to alpha numeric string with first letter in string lower case
		/// </summary>
		/// <example>
		/// camelCase
		/// </example>
		public static string ToCamelBack(this string instance)
		{
			string result = instance;
			if (!String.IsNullOrWhiteSpace(instance))
			{
				var start = true;
				var upper = false;
				var builder = new StringBuilder();
				foreach (char character in instance)
				{
					if (Char.IsLetter(character) || Char.IsNumber(character))
					{
						var letterOrDigit = character;
						if (start)
						{
							letterOrDigit = Char.ToLower(letterOrDigit);
							start = false;
						}
						else
						{
							if (upper)
							{
								letterOrDigit = Char.ToUpper(letterOrDigit);
								upper = false;
							}
						}
						builder.Append(letterOrDigit);
					}
					else if (Char.IsWhiteSpace(character)) upper = true;
				}
				result = builder.ToString();
			}
			return result;
		}
	}
}
