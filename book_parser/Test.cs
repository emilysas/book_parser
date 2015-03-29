﻿using NUnit.Framework;
using System;
using System.Collections.Generic;

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
			dictionary.AddWord ("Hello");
			Assert.AreEqual(1, dictionary.NumberOfUniqueWords());
		}

		[Test ()]
		public void CanExtractContentsOfDictionary ()
		{
			dictionary.AddWord ("Hello");
			Assert.AreEqual ("Hello: 1\n", dictionary.GetContents ());
		}
	}
}

