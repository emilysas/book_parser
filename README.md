# book_parser

The brief is as follows:
1. To write an application that outputs the individual words that appear in the book, and how many times that word appears in the text file.
2. The second part is to also output whether the number of times each word appears is a prime number.
3. 

##Output

This is a snapshot of the program run with the text from 'Cat In The Hat':

![Screenshot](book_parser/screenshot2.png?raw=true)

##Issues Faced

Annoyingly, Xamarin stopped running all of my tests - despite having 11 tests it only runs 8. As such, I've had to cease TDD as I've no way to test other than to run the application!

The results are not ordered, it'd be good to order the output by the words with the greatest occurence.

I realised that in replacing symbols with whitespace, I risk chopping up words where a symbol such as an apostrophe occurs mid-word.

This has been a really interesting exercise, as a lot of the problems I had I originally put down to the perculiarities of C# but have since realised are just things that Ruby and Javascript have 'let me get away with'; I've learned a lot more about OOD as a result.

##Future Intentions

I would like to sort the output in descending order that words are displayed according to their frequency.

It would perhaps also be good to allow users to search for particular words.

