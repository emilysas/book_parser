using System;
using System.Text;
using System.Collections.Generic;
using System.IO;

namespace book_parser
{
	public class Program
	{
		static TextParser parser;
		static RefDictionary dictionary;
		static PrimeNumberCalculator calculator;
		static Array words;
		static string fileName;

		public static void Main (string[] args)
		{
			parser = new TextParser ();
			dictionary = new RefDictionary ();
			calculator = new PrimeNumberCalculator ();
			GetFile ();
			RunWordsThroughDictionary (fileName);
			PrintToConsole ();
 		}

		public static void GetFile()
		{
			Console.WriteLine ("Please input the filename that you would like to read");
			string input = Console.ReadLine ();
			if (File.Exists (input)) {
				fileName = input;
			} else {
				GetFile ();
			}
		}

		public static void RunWordsThroughDictionary(string path)
		{
			words = parser.GetWordArray(path);
			foreach (string word in words) {
				dictionary.UpdateDictionary (word);
			}
		}

		public static string GetContents ()
		{
			StringBuilder wordData = new StringBuilder ();
			foreach (KeyValuePair<string, int> item in dictionary.Show()) {
				wordData.Append (item.Key)
					.Append ( ": ")
					.Append (item.Value)
					.Append (InformIfPrime((ulong)item.Value));
			}
			return wordData.ToString();
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

