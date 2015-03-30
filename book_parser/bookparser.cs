using System;

namespace book_parser
{
	public class Program
	{
		static TextParser parser;
		static RefDictionary dictionary;
		static PrimeNumberCalculator calculator;
		static Array words;

		public static void Main (string[] args)
		{
			parser = new TextParser ();
			dictionary = new RefDictionary ();
			calculator = new PrimeNumberCalculator ();
 		}

		public static void RunWordsThroughDictionary(string path)
		{
			words = parser.GetWordArray(path);
			foreach (string word in words) {
				dictionary.UpdateDictionary(word);
			}
		}

		public static void GetData()
		{
			dictionary.GetContents ();
		}

		public static void PrintToConsole ()
		{
			Console.WriteLine (GetData());
		}
	}
}

