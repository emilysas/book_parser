using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace book_parser
{
	[TestFixture ()]
	public class TextParserTest
	{
		TextParser textparser;
		string[] textarray;

		[SetUp]
		public void Init ()
		{
			textparser = new TextParser ();
			textarray = new Array {"hello", "world"};
		}

		[Test ()]
		public void WillParseTextFileAndCreateArrayOfWords ()
		{
			Assert.AreEqual(textarray, textparser.GetWords());
		}

	}
}
