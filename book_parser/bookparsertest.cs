using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace book_parser
{
	[TestFixture ()]
	public class BookParserTest
	{
		TextParser textparser;
		RefDictionary dictionary;
		PrimeNumberCalculator calculator;
		Array words;

		[SetUp]
		public void Init ()
		{
			textparser = new TextParser ();
			dictionary = new RefDictionary ();
			calculator = new PrimeNumberCalculator ();
			words = textparser.GetWordArray ("../../testfiles/ExampleTextFile.txt");
		}

		[Test]
		public void CanParseTextAndIterateThroughToReturnWordsFrequencies()
		{
			Assert.Contains("cat: 100", Program.RunWordsThroughDictionary(words));
		}
	}
}

