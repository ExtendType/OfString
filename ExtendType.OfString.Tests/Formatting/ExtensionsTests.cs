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
		public void FormatWith()
		{
			const string control = "test";
			string experemental = "{0}";
			TestContext.WriteLine("Success: Returns null or empty if format is null or empty ");
			((string)null).FormatWith(control)
				.Should().Be(null);
			String.Empty.FormatWith(control)
				.Should().Be(String.Empty);
			TestContext.WriteLine("Success: Expect format when one provided");
			experemental.FormatWith(control)
				.Should().Be(control);
			TestContext.WriteLine("Success: Expect format when one provided with custom format provider");
			experemental.FormatWith(Thread.CurrentThread.CurrentCulture,control)
				.Should().Be(control);				
		}
	}
}
