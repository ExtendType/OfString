using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExtendType.OfString.Whitespace;
using FluentAssertions;
namespace ExtendType.OfString.Tests.Whitespace
{
	[TestClass]
	public class ExtensionTests
	{
		public TestContext TestContext
		{ get; set; }
		[TestMethod]
		public void IsNullOrEmptyTest()
		{
			TestContext.WriteLine("Success: value is null");
			((string)null).IsNullOrEmpty()
				.Should().Be(true);
			TestContext.WriteLine("Success: value is empty");
			String.Empty.IsNullOrEmpty()
				.Should().Be(true);
			TestContext.WriteLine("Fail: value is not null or empty");
			"test".IsNullOrEmpty()
				.Should().Be(false);
		}
		[TestMethod]
		public void IsNotNullOrEmptyTest()
		{
			TestContext.WriteLine("Success: value is not null or empty");
			"test".IsNotNullOrEmpty()
				.Should().Be(true);
			TestContext.WriteLine("Fail: value is null");
			((string)null).IsNotNullOrEmpty()
				.Should().Be(false);
			TestContext.WriteLine("Fail: value is empty");
			String.Empty.IsNotNullOrEmpty()
				.Should().Be(false);
		}
		[TestMethod]
		public void IsNullOrWhiteSpaceTest()
		{
			TestContext.WriteLine("Success: value is null");
			((string)null).IsNullOrWhiteSpace()
				.Should().Be(true);
			TestContext.WriteLine("Success: value is empty");
			String.Empty.IsNullOrWhiteSpace()
				.Should().Be(true);
			TestContext.WriteLine("Success: value is white space");
			" ".IsNullOrWhiteSpace()
				.Should().Be(true);
			TestContext.WriteLine("Fail: value is not null or empty");
			"test".IsNullOrWhiteSpace()
				.Should().Be(false);
		}
		[TestMethod]
		public void IsNullOrWhitespaceTest()
		{
			TestContext.WriteLine("Success: value is not null, empty or whitespace");
			"test".IsNotNullOrWhiteSpace()
				.Should().Be(true);
			TestContext.WriteLine("Fail: value is null");
			((string)null).IsNotNullOrWhiteSpace()
				.Should().Be(false);
			TestContext.WriteLine("Fail: value is empty");
			String.Empty.IsNotNullOrWhiteSpace()
				.Should().Be(false);
			TestContext.WriteLine("Fail: value is whitespace");
			" ".IsNotNullOrWhiteSpace()
				.Should().Be(false);
		}
	}
}
