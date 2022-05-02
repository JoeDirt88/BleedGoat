using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BleedGoat.Utilities
{
    class Program
    {
        static void Main(string[] args)
        {
            const string shortString = "Hello there, I love you!";
            const string paragraphString = "By keeping,all these questions in our mind today we have come up with a new topic called “A Guide on Paragraph Writing”. With this guide, we’ll try to answer all these questions about paragraph writing. Paragraphs act as the main role in a student’s life. While writing any topic in an exam or competition needs paras to explain the concept in an understandable way for the readers. I think this is bullshit.";
            Console.WriteLine("This is the original string:");
            Console.WriteLine(shortString);

            Console.WriteLine("\nThis is the original string with my extension method applied:");
            Console.WriteLine(shortString.MakeHearts('o'));

            CUtils.Continue(true);

            // I want you to continue below and in the MooncakeUtils.cs file
            // Look at the JoeUtils.cs file if you get stuck

            // Assignment 1: create a new branch with my help called:
            // Fundamentals/Utilities/Strings_and_Such
            // Then make the following 3 string utilities:
            // Utility 1: [Easy as Pie]
            // Count the amount of words in the paragraph above called 'paragraphString'
            // Display the answer using the following by selecting it and uncommenting it:
            //Console.Write($"The number of words in the paragraph:\n{paragraphString}\n\nis: ");
            //Console.WriteLine(paragraphString.[YourMethodNameHere]());
            //CUtils.Continue();

            Console.Write($"The number of words in the paragraph:\n{paragraphString}\n\nis: ");
            Console.WriteLine(paragraphString.CountWords());
            CUtils.Continue();

            var lowercaseParagraph = paragraphString.ToLower();
            // Utility 2: [Hardcore Shit]
            // Make all words in the paragraph 'lowercaseParagraph' longer than 3 characters have an upper case first letter
            // Conditionally also uppercase "i" if it is a word by itself
            // use the output template above to construct your output
        }
    }
}
