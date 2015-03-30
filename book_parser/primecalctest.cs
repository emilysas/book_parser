using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace book_parser
{
	[TestFixture ()]
	public class PrimeNumberCalculatorTest
	{
		PrimeNumberCalculator calculator;

		[SetUp]
		public void Init ()
		{
			calculator = new PrimeNumberCalculator ();
		}

		[Test ()]
		public void CanCalculateWhetherANumberIsAPrime ()
		{
			Assert.True (calculator.IsAPrimeNumber (7));
		}

		[Test ()]
		public void CanCalculateWhetherANumberIsNotPrime ()
		{
			Assert.False (calculator.IsAPrimeNumber (8));
		}
	}
}

