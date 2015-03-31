# book_parser

The brief is as follows:
1. To write an application that outputs the individual words that appear in the book, and how many times that word appears in the text file.
2. The second part is to also output whether the number of times each word appears is a prime number.

![Screenshot1](screenshot.png?raw=true)

##Issues Faced

Annoyingly, Xamarin stopped running all of my tests - despite having 11 tests it only runs 8. As such, I've had to cease TDD as I've no way to test other than to run the application!

At the moment, I hard code a file into the Program, but would like to get the user to input their own file.

The results are not ordered, it'd be good to order the output by the words with the greatest occurence.

I realised that in replacing symbols with whitespace, I risk chopping up words where a symbol such as an apostrophe occurs mid-word.

This has been a really interesting exercise, as a lot of the problems I had I originally put down to the perculiarities of C# but have since realised are just things that Ruby and Javascript have 'let me get away with'; I've learned a lot more about OOD as a result.

