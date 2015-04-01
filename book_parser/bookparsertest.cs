using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace book_parser
{
	[TestFixture ()]
	public class BookParserTest
	{
		TextParser parser;
		RefDictionary dictionary;
		PrimeNumberCalculator calculator;

		[SetUp]
		public void Init ()
		{
			parser = new TextParser ();
			dictionary = new RefDictionary ();
			calculator = new PrimeNumberCalculator ();
		}

		[Test ()]
		public void CanExtractContentsOfDictionary ()
		{
			Program.RunWordsThroughDictionary(parser, dictionary, "../../testfiles/ExampleTextFile.txt");
			Assert.AreEqual ("world: 1\nhello: 1\n", Program.GetContents (dictionary, calculator));
		}

		[Test ()]
		public void WillNoteIfPrime ()
		{
			Program.RunWordsThroughDictionary(parser, dictionary, "../../testfiles/CatInTheHat.txt");
			Assert.That(Program.GetContents (dictionary, calculator), HasMember "big: 5 Prime \n");
		}
	}
}

