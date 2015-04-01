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
			RunWordsThroughDictionary (parser, dictionary, fileName);
			PrintToConsole (dictionary, calculator);
 		}

		public static void GetFile()
		{
			Console.WriteLine ("Please input the filename that you would like to read");
			string input = Console.ReadLine ();
			CheckFile (input);
		}

		private static void CheckFile(string input)
		{
			if (File.Exists (input)) {
				fileName = input;
			} else {
				GetFile ();
			}
		}

		public static void RunWordsThroughDictionary(TextParser parser, RefDictionary dictionary, string path)
		{
			words = parser.GetWordArray(path);
			foreach (string word in words) {
				dictionary.UpdateDictionary (word);
			}
		}

		public static string GetContents (RefDictionary dictionary, PrimeNumberCalculator calculator)
		{
			StringBuilder wordData = new StringBuilder ();
			foreach (KeyValuePair<string, int> item in dictionary.Show()) {
				wordData.Append (item.Key)
					.Append ( ": ")
					.Append (item.Value)
					.Append (InformIfPrime(calculator, (ulong)item.Value));
			}
			return wordData.ToString();
		}

		private static string InformIfPrime(PrimeNumberCalculator calculator, ulong num)
		{
			if (calculator.IsAPrimeNumber(num))
				return " Prime \n";
			return "\n";
		}

		public static void PrintToConsole (RefDictionary dictionary, PrimeNumberCalculator calculator)
		{
			Console.WriteLine (GetContents (dictionary, calculator));
		}
	}
}

