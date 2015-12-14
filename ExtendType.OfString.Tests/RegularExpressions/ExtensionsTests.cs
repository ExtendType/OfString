using System;
using ExtendType.OfString.RegularExpressions;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading;
using System.Text.RegularExpressions;

namespace ExtendType.OfString.Tests.RegularExpressions
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
		public void ToRegexTest()
		{
			string experemental = @"023\d+";
			((string)null).ToRegex().Should().Be(null);
			String.Empty.ToRegex().IsMatch("012346").Should().BeTrue();
			experemental.ToRegex().IsMatch("023456").Should().BeTrue();
			String.Empty.ToRegex(RegexOptions.IgnoreCase).IsMatch("012346").Should().BeTrue();
			experemental.ToRegex(RegexOptions.IgnoreCase).IsMatch("023456").Should().BeTrue();
		}

		[TestMethod]
		public void ToWildcard()
		{
			string experemental = @"something.*";
			((string)null).ToWildcard().Should().Be(null);
			String.Empty.ToWildcard().IsMatch("something.txt").Should().BeFalse();
			experemental.ToWildcard().IsMatch("something.txt").Should().BeTrue();
		}

		[TestMethod]
		public void MatchTest()
		{
			string match = "0123456";
			string pattern = @"0123\d+";
			match.Match(pattern).Success.Should().BeTrue();
			match.Match(pattern,RegexOptions.IgnoreCase).Success.Should().BeTrue();
		}
		[TestMethod]
		public void IsMatchTest()
		{
			string match = "0123456";
			string pattern = @"0123\d+";
			match.IsMatch(pattern).Should().BeTrue();
			match.IsMatch(pattern, RegexOptions.IgnoreCase).Should().BeTrue();
		}
	}
}
