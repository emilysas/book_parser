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
//		static string fileName;

		public static void Main (string[] args)
		{
			parser = new TextParser ();
			dictionary = new RefDictionary ();
			calculator = new PrimeNumberCalculator ();
//			string fileName = GetInputFromUser ();
			RunWordsThroughDictionary ("../../testfiles/CatInTheHat.txt");
			PrintToConsole ();
 		}

//		private static string GetInputFromUser ()
//		{
//			Console.WriteLine ("Please enter the path of the file that you'd like to read");
//			return Console.ReadLine ();
//		}

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
					.Append (InformIfPrime((ulong)item.Value));
			}
			return word_data.ToString();
		}

		private static string InformIfPrime(ulong num)
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

