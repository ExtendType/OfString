using System;
using ExtendType.OfString.Conversion;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading;
using System.Globalization;
using System.Diagnostics;

namespace ExtendType.OfString.Tests.Conversion
{
	[TestClass]
	public class ExtensionsTests
	{
		public TestContext TestContext
		{
			get;
			set;
		}

		[TestMethod]
		public void AsBoolOrDefaultTest()
		{
			((string)null).AsBoolOrDefault().Should().Be(false);
			("False").AsBoolOrDefault().Should().Be(false);
			("True").AsBoolOrDefault().Should().Be(true);
		}

		[TestMethod]
		public void AsBoolOrNullTest()
		{
			((string)null).AsBoolOrNull().Should().Be(null);
			("False").AsBoolOrNull().Should().Be(false);
			("True").AsBoolOrNull().Should().Be(true);
		}

		[TestMethod]
		public void AsByteOrDefaultTest()
		{
			((string)null).AsByteOrDefault().Should().Be(0);
			("32").AsByteOrDefault().Should().Be(32);
		}

		[TestMethod]
		public void AsByteOrNullTest()
		{
			((string)null).AsByteOrNull().Should().Be(null);
			("32").AsByteOrDefault().Should().Be(32);
		}

		[TestMethod]
		public void AsShortOrDefaultTest()
		{
			((string)null).AsShortOrDefault().Should().Be(0);
			("32").AsShortOrDefault().Should().Be(32);
		}

		[TestMethod]
		public void AsShortOrNullTest()
		{
			((string)null).AsShortOrNull().Should().Be(null);
			("32").AsShortOrDefault().Should().Be(32);
		}

		[TestMethod]
		public void AsIntOrDefaultTest()
		{
			((string)null).AsIntOrDefault().Should().Be(0);
			("32").AsIntOrDefault().Should().Be(32);
		}

		[TestMethod]
		public void AsIntOrNullTest()
		{
			((string)null).AsIntOrNull().Should().Be(null);
			("32").AsIntOrDefault().Should().Be(32);
		}

		[TestMethod]
		public void AsFloatOrDefaultTest()
		{
			((string)null).AsFloatOrDefault().Should().Be(0);
			("32.5").AsFloatOrDefault().Should().Be(32.5F);
		}

		[TestMethod]
		public void AsFloatOrNullTest()
		{
			((string)null).AsFloatOrNull().Should().Be(null);
			("32.5").AsFloatOrDefault().Should().Be(32.5F);
		}

		[TestMethod]
		public void AsDoubleOrDefaultTest()
		{
			((string)null).AsDoubleOrDefault().Should().Be(0);
			("32.5").AsDoubleOrDefault().Should().Be(32.5D);
		}

		[TestMethod]
		public void AsDoubleOrNullTest()
		{
			((string)null).AsDoubleOrNull().Should().Be(null);
			("32.5").AsDoubleOrDefault().Should().Be(32.5D);
		}

		[TestMethod]
		public void AsDecimalOrDefaultTest()
		{
			((string)null).AsDecimalOrDefault().Should().Be(0);
			("32.5").AsDecimalOrDefault().Should().Be(32.5M);
		}

		[TestMethod]
		public void AsDecimalOrNullTest()
		{
			((string)null).AsDecimalOrNull().Should().Be(null);
			("32.5").AsDecimalOrDefault().Should().Be(32.5M);
		}

		[TestMethod]
		public void AsDateTimeOrDefaultTest()
		{
			((string)null).AsDateTimeOrDefault().Should().Be(DateTime.MinValue);
			("01/01/2015").AsDateTimeOrDefault().Should().Be(new DateTime(2015, 1, 1));
		}

		[TestMethod]
		public void AsDateTimeOrNullTest()
		{
			((string)null).AsDateTimeOrNull().Should().Be(null);
			("01/01/2015").AsDateTimeOrNull().Should().Be(new DateTime(2015, 1, 1));
		}

		[TestMethod]
		public void AsTimeSpanOrDefaultTest()
		{
			((string)null).AsTimeSpanOrDefault().Should().Be(TimeSpan.Zero);
			("0.01:00:00.00").AsTimeSpanOrDefault().Should().Be(new TimeSpan(0, 1, 0, 0, 0));
		}

		[TestMethod]
		public void AsTimeSpanOrNullTest()
		{
			((string)null).AsTimeSpanOrNull().Should().Be(null);
			("0.01:00:00.00").AsTimeSpanOrNull().Should().Be(new TimeSpan(0, 1, 0, 0, 0));
		}

		private enum TestEnum
		{ 
			A,
			B
		}

		[TestMethod]
		public void AsEnumOrDefaultTest()
		{
			((string)null).AsEnumOrDefault<TestEnum>().Should().Be(TestEnum.A);
			("B").AsEnumOrDefault<TestEnum>().Should().Be(TestEnum.B);
		}

		[TestMethod]
		public void AsEnumOrNullTest()
		{
			((string)null).AsEnumOrNull<TestEnum>().Should().Be(null);
			("B").AsEnumOrNull<TestEnum>().Should().Be(TestEnum.B);
		}
	}
}
