using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace book_parser
{
	[TestFixture ()]
	public class BookParserTest
	{

		[SetUp]
		public void Init ()
		{
		}

		[Test]
		public void CanParseTextAndIterateThroughToReturnWordsFrequencies()
		{
			Program.RunWordsThroughDictionary ("../../testfiles/ExampleTextFile.txt");
			StringAssert.Contains("cat: 100", Program.PrintToConsole ());
		}
	}
}

