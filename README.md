# book_parser

The brief is as follows:
1. To write an application that outputs the individual words that appear in the book, and how many times that word appears in the text file.
2. The second part is to also output whether the number of times each word appears is a prime number.


##Issues Faced

Whilst all the component parts work, I'm struggling to pull it altogether in the Program class. I'm also struggling to write an integration test in NUnit. Finally, I realised that my PrimeNumberCalculator expects to receive integers/ulongs as arguments, and that Program is not going to receive these (instead receiving one long string that contains number strings). I am therefore going to have to think carefully about where I should call the PrimeNumberCalculator, and whether I need to change the ReferenceDictionary so that it contains the word frequencies as ulongs.

This has been a really interesting exercise, as a lot of the problems I had I originally put down to the perculiarities of C# but have since realised are just things that Ruby and Javascript have 'let me get away with'; I've learned a lot more about OOD as a result.

