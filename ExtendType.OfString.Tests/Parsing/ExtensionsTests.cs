using System;
using ExtendType.OfString.Parsing;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading;

namespace ExtendType.OfString.Tests.Parsing
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
		public void ToNumericTest()
		{
			const string control = "1234565";
			string experemental = "A1b2.3$4%5+65";
			((string)null).ToNumeric().Should().Be(null);
			String.Empty.ToNumeric().Should().Be(String.Empty);
			experemental.ToNumeric().Should().Be(control);
		}

		[TestMethod]
		public void ToAlphabeticTest()
		{
			const string control = "Abcd";
			string experemental = "A1b2.3c4%5d+65";
			((string)null).ToAlphabetic().Should().Be(null);
			String.Empty.ToAlphabetic().Should().Be(String.Empty);
			experemental.ToAlphabetic().Should().Be(control);
		}

		[TestMethod]
		public void ToAlphaNumericTest()
		{
			const string control = "A1b23c45d65";
			string experemental = "A1b2.3c4%5d+65";
			((string)null).ToAlphaNumeric().Should().Be(null);
			String.Empty.ToAlphaNumeric().Should().Be(String.Empty);
			experemental.ToAlphaNumeric().Should().Be(control);
		}
	}
}
