using System;
using System.Collections.Generic;
using System.Collections;
using System.Collections.Concurrent;
using System.Linq; 
using System.Text;

namespace book_parser
{
	public class RefDictionary
	{
		ConcurrentDictionary<string, int> dictionary;

		public RefDictionary ()
		{
			dictionary = new ConcurrentDictionary<string, int> ();	
		}

		public void UpdateDictionary(string word)
		{
			dictionary.AddOrUpdate(word, 1, (key, value) => value + 1);
		}

		public int NumberOfUniqueWords()
		{
			return dictionary.Count;
		}

		public string GetContents ()
		{
			StringBuilder word_data = new StringBuilder ();
			foreach (KeyValuePair<string, int> item in dictionary) {
				word_data.Append (item.Key)
					.Append( ": ")
					.Append (item.Value)
					.Append ("\n");
			}
			return word_data.ToString();
		}

		public void WriteDataToConsole(string word_data)
		{
			Console.WriteLine (GetContents());
		}
	}
}

