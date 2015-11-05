using System;
using ExtendType.OfString.Conventions;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading;
using System.Globalization;
using System.Diagnostics;

namespace ExtendType.OfString.Tests.Conventions
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
		public void CamelBackTest()
		{

			((string)null).ToCamelBack().Should().Be(null);
			String.Empty.ToCamelBack().Should().Be(String.Empty);

			string control = "thisIsATest";
			string experemental = "This-is a.Test";
			control.ToCamelBack().Should().Be(control);
			experemental.ToCamelBack().Should().Be(control);				
		}

		[TestMethod]
		public void ToTitleCaseTest()
		{
			((string)null).ToTitleCase(null).Should().Be(null);
			String.Empty.ToTitleCase(null).Should().Be(String.Empty);

			string control = "This Is A Test";
			string experemental = "this is a test";
			control.ToTitleCase().Should().Be(control);
			experemental.ToTitleCase().Should().Be(control);
		}
	}
}
