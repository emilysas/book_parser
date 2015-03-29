using System;
using System.Collections.Generic;

namespace book_parser
{
	public class RefDictionary
	{
		Dictionary<string, int> dictionary;

		public RefDictionary ()
		{
			dictionary = new Dictionary<string, int> ();	
		}

		public void AddWord (string word)
		{
			dictionary.Add (word, 1);
		}

		public int NumberOfUniqueWords()
		{
			return dictionary.Count;
		}
	}
}

