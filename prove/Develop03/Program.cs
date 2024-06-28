/* Exceeds requirements: The program works with a library of scriptures rather
than a single one and chooses scriptures at random to present to the user. */

using System.Collections.Specialized;

namespace Develop03;

static class Program
{
    static void Main(string[] args)
    {
        ScriptureLibrary library = new ScriptureLibrary();
        Scripture scripture = library.GetRandomScripture();

        while (true)
        {
            Console.Clear();
            Console.WriteLine(scripture.DisplayScripture());

            if (scripture.IsCompletelyHidden()) break;

            Console.Write("\nPress Enter to continue (hide a word) or type 'quit' to exit: ");
            string userInput = Console.ReadLine();

            if (userInput != null && userInput.ToLower() == "quit") break;
            
            if (string.IsNullOrEmpty(userInput))
            {
                scripture.HideRandomWords();
                continue;
            }
            Console.Write("Wrong Command. You need to choose either to press Enter or type 'quit'!");
            Thread.Sleep(3000);
        }
    }
}