using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace book_parser
{
	[TestFixture ()]
	public class TextParserTest
	{
		TextParser textparser;
		string[] wordarray;
		string catInTheHatString;

		[SetUp]
		public void Init ()
		{
			textparser = new TextParser ();
			catInTheHatString = "And then something went BUMP! How that bump made us jump! We looked! Then we saw him step in on the mat! We looked! And we saw him! The Cat in the Hat!";
			wordarray = new string[] {
				"and",
				"then",
				"something",
				"went",
				"bump",
				"how",
				"that",
				"bump",
				"made",
				"us",
				"jump",
				"we",
				"looked",
				"then",
				"we",
				"saw",
				"him",
				"step",
				"in",
				"on",
				"the",
				"mat",
				"we",
				"looked",
				"and",
				"we",
				"saw",
				"him",
				"the",
				"cat",
				"in",
				"the",
				"hat"
			};
		}

		[Test ()]
		public void WillParseTextFileAndReturnString ()
		{
			Assert.AreEqual("hello world", textparser.GetWords("../../testfiles/ExampleTextFile.txt"));
		}

		[Test ()]
		public void WillRemoveUnwantedChars ()
		{
			Assert.AreEqual ("hello  how are you    ", textparser.RemoveUnwantedCharacters ("HELLO, how are you?!?!"));
		}

		[Test ()]
		public void WillCreateArrayOfStrings ()
		{
			string symbolsRemoved = textparser.RemoveUnwantedCharacters (catInTheHatString);
			Assert.AreEqual(wordarray, textparser.CreateArrayOfWords(symbolsRemoved));
		}
			
	}
}
