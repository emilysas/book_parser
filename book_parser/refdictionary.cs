using System;
using System.Collections.Concurrent;


namespace book_parser
{
	public class RefDictionary
	{
		ConcurrentDictionary<string, int> dictionary;

		public RefDictionary ()
		{
			dictionary = new ConcurrentDictionary<string, int> ();	
		}

		public ConcurrentDictionary<string, int> Show ()
		{
			return dictionary;
		}

		public void UpdateDictionary(string word)
		{
			dictionary.AddOrUpdate(word, 1, (key, value) => value + 1);
		}

		public int NumberOfUniqueWords()
		{
			return dictionary.Count;
		}

	}
}

