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
	}
}

