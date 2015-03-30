using System;
using System.Text;
using System.Collections.Generic;
using System.Collections.Concurrent;

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

		public static string GetContents ()
		{
			StringBuilder word_data = new StringBuilder ();
			foreach (KeyValuePair<string, int> item in dictionary.Show()) {
				word_data.Append (item.Key)
					.Append ( ": ")
					.Append (item.Value)
					.Append (InformIfPrime(Convert.ToUInt64(item.Key)));
			}
			return word_data.ToString();
		}

		public static string InformIfPrime(ulong num)
		{
			if (calculator.IsAPrimeNumber(num))
				return " Prime \n";
			return "\n";
		}

		public static void PrintToConsole ()
		{
			Console.WriteLine (GetContents ());
		}
	}
}

