using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace book_parser
{
	[TestFixture ()]
	public class TextParserTest
	{
		TextParser textparser;

		[SetUp]
		public void Init ()
		{
			textparser = new TextParser ();
		}

		[Test ()]
		public void WillParseTextFileAndReturnString ()
		{
			Assert.AreEqual("hello world", textparser.GetWords("../../testfiles/ExampleTextFile.txt"));
		}

	}
}
