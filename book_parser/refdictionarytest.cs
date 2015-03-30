using NUnit.Framework;
using System;


namespace book_parser
{
	[TestFixture ()]
	public class RefDictionaryTest
	{
		RefDictionary dictionary;

		[SetUp]
		public void Init ()
		{
			dictionary = new RefDictionary ();
		}

		[Test ()]
		public void WillAddNewWordToDictionary ()
		{
			dictionary.UpdateDictionary ("Hello");
			Assert.AreEqual(1, dictionary.NumberOfUniqueWords());
		}

		[Test ()]
		public void WillNotAddExistingWordToDictionary ()
		{
			dictionary.UpdateDictionary ("Hello");
			dictionary.UpdateDictionary ("Hello");
			Assert.AreEqual(1, dictionary.NumberOfUniqueWords());
		}

//		[Test ()]
//		public void WillIncreaseWordCount ()
//		{
//			dictionary.UpdateDictionary ("Hello");
//			dictionary.UpdateDictionary ("Hello");
//			Assert.AreEqual(2, dictionary.GetContents ());
//		}

	}
}

