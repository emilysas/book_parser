using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace book_parser
{
	[TestFixture ()]
	public class RefDictionary
	{
		Dictionary<string, int> dictionary;

		[SetUp]
		public void Init ()
		{
			dictionary = new Dictionary<string, int> ();
		}

		[Test ()]
		public void WillAddNewWordToDictionary ()
		{
			Assert.AreEqual("Hello: 1", dictionary.AddWord("Hello"));
		}
	}
}

