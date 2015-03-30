using System;
using System.IO;

namespace book_parser
{
	public class TextParser
	{
		public TextParser ()
		{
		}

		public string GetWords (string path)
		{
			string readText = File.ReadAllText(path);
			return readText;
		}

		public Array CreateArrayOfWords (string wordstring)
		{
			string[] separators = {",", ".", "!", "?", ";", ":", " "};
			string[] words = wordstring.Split(separators, StringSplitOptions.RemoveEmptyEntries);
			return words;
		}
			
	}
}

