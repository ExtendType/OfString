using System;
using ExtendType.OfString.Conventions;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading;

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
		public void CamelBack()
		{
			const string control = "thisIsTest";
			string experemental = "This is Test";
			((string)null).ToCamelBack().Should().Be(null);
			String.Empty.ToCamelBack().Should().Be(String.Empty);
			control.ToCamelBack().Should().Be(control);
			experemental.ToCamelBack().Should().Be(control);				
		}
	}
}
