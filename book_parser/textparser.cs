using System;
using System.IO;
using System.Text.RegularExpressions;

namespace book_parser
{
	public class TextParser
	{
		public Array GetWordArray (string path)
		{
			string textstring = GetWords (path);
			string wordstring = RemoveUnwantedCharacters (textstring);
			return CreateArrayOfWords(wordstring);
		}

		public string GetWords (string path)
		{
			string readText = File.ReadAllText(path);
			return readText;
		}

		public string RemoveUnwantedCharacters(string allchars)
		{
			string lowercasestring = allchars.ToLower();
			return Regex.Replace (lowercasestring, @"[\W]", " ");
		}

		public Array CreateArrayOfWords (string stringofwords)
		{
			string[] words = stringofwords.Split (new char[0], StringSplitOptions.RemoveEmptyEntries);
			return words;
		}
			
	}
}

