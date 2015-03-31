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
			Assert.AreEqual(1, dictionary.Show().Count);
		}

		[Test ()]
		public void WillNotAddExistingWordToDictionary ()
		{
			dictionary.UpdateDictionary ("Hello");
			dictionary.UpdateDictionary ("Hello");
			Assert.AreEqual (1, dictionary.Show ().Count);
		}

	}
}

