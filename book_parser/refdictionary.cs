using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq; 
using System.Text;

namespace book_parser
{
	public class RefDictionary
	{
		Dictionary<string, int> dictionary;

		public RefDictionary ()
		{
			dictionary = new Dictionary<string, int> ();	
		}

		public void UpdateDictionary(string word)
		{
			if (CheckForWord(word)){
				UpdateWordCount (word);
			} else {
				AddWord (word);
			}

		}

		public bool CheckForWord(string word)
		{
			return dictionary.ContainsKey (word);
		}

		public void AddWord (string word)
		{
			dictionary.Add (word, 1);
		}

		public void UpdateWordCount (string word)
		{

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

