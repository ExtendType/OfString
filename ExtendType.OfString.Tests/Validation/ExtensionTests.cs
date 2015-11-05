using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExtendType.OfString.Validation;
using FluentAssertions;
namespace ExtendType.OfString.Tests.Validation
{
	[TestClass]
	public class ExtensionTests
	{
		public TestContext TestContext
		{ get; set; }
		[TestMethod]
		public void IsNullOrEmptyTest()
		{
			((string)null).IsNullOrEmpty().Should().Be(true);
			String.Empty.IsNullOrEmpty().Should().Be(true);
			"test".IsNullOrEmpty().Should().Be(false);
		}
		[TestMethod]
		public void IsNotNullOrEmptyTest()
		{
			"test".IsNotNullOrEmpty().Should().Be(true);
			((string)null).IsNotNullOrEmpty().Should().Be(false);
			String.Empty.IsNotNullOrEmpty().Should().Be(false);
		}
		[TestMethod]
		public void IsNullOrWhiteSpaceTest()
		{
			((string)null).IsNullOrWhiteSpace().Should().Be(true);
			String.Empty.IsNullOrWhiteSpace().Should().Be(true);
			" ".IsNullOrWhiteSpace().Should().Be(true);
			"test".IsNullOrWhiteSpace().Should().Be(false);
		}
		[TestMethod]
		public void IsNullOrWhitespaceTest()
		{
			"test".IsNotNullOrWhiteSpace().Should().Be(true);
			((string)null).IsNotNullOrWhiteSpace().Should().Be(false);
			String.Empty.IsNotNullOrWhiteSpace().Should().Be(false);
			" ".IsNotNullOrWhiteSpace().Should().Be(false);
		}
	}
}
