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

		[Test ()]
		public void CanExtractContentsOfDictionary ()
		{
			Program.RunWordsThroughDictionary("../../../ExampleTextFile.txt");
			Assert.AreEqual ("Hello: 1\nWord: 1\n", Program.GetContents ());
		}

		[Test ()]
		public void WillNoteIfPrime ()
		{
			Program.RunWordsThroughDictionary("../../../CatInTheHat.txt");
			Assert.AreEqual("Cat: 25 Prime\n", Program.GetContents ());
		}
	}
}

