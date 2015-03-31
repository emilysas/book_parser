using System;
using System.IO;
using System.Text.RegularExpressions;

namespace book_parser
{
	public class TextParser
	{
		public Array GetWordArray (string path)
		{
			string textString = GetWords (path);
			string wordString = RemoveUnwantedCharacters (textString);
			return CreateArrayOfWords(wordString);
		}

		public string GetWords (string path)
		{
			string readText = File.ReadAllText(path);
			return readText;
		}

		public string RemoveUnwantedCharacters(string allChars)
		{
			string lowerCaseString = allChars.ToLower();
			return Regex.Replace (lowerCaseString, @"[\W]", " ");
		}

		public Array CreateArrayOfWords (string stringOfWords)
		{
			string[] words = stringOfWords.Split (new char[0], StringSplitOptions.RemoveEmptyEntries);
			return words;
		}
			
	}
}

