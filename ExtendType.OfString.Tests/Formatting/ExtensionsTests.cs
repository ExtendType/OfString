using System;
using ExtendType.OfString.Formatting;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading;

namespace ExtendType.OfString.Tests.Formatting
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
		public void FormatWithTest()
		{
			const string control = "test";
			string experemental = "{0}";
			((string)null).FormatWith(control).Should().Be(null);
			String.Empty.FormatWith(control).Should().Be(String.Empty);
			experemental.FormatWith(control).Should().Be(control);
			experemental.FormatWith(Thread.CurrentThread.CurrentCulture,control).Should().Be(control);				
		}
	}
}
