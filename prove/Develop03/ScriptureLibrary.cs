using System.Net.Http.Headers;

namespace Develop03;

public class ScriptureLibrary
{
    private readonly List<Scripture> _scriptures = [];
    private readonly Random _generator = new();

    public ScriptureLibrary()
    {
        _scriptures.Add(new Scripture(new Reference("Proverbs", 3, 5, 6), "Trust in the Lord with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths.", _generator));
        _scriptures.Add(new Scripture(new Reference("1 John", 4, 15), "Whosoever shall confess that Jesus is the Son of God, God dwelleth in him, and he in God.", _generator));
        _scriptures.Add(new Scripture(new Reference("Colossians", 3, 2), "Set your affection on things above, not on things on the earth.", _generator));
        _scriptures.Add(new Scripture(new Reference("Psalm", 31, 24), "Be of good courage, and he shall strengthen your heart, all ye that hope in the Lord.", _generator));
        _scriptures.Add(new Scripture(new Reference("Isaiah", 43, 15), "I am the Lord, your Holy One, the creator of Israel, your King.", _generator));
        _scriptures.Add(new Scripture(new Reference("Phillipians", 4, 13), "I can do all things through Christ which strengtheneth me.", _generator));
        _scriptures.Add(new Scripture(new Reference("1 Chronicles", 16, 11), "Seek the Lord and his strength, seek his face continually.", _generator));
        _scriptures.Add(new Scripture(new Reference("1 Corinthians", 16, 13, 14), "Watch ye, stand fast in the faith, quit you like men, be strong. Let all your things be done with charity.", _generator));
        _scriptures.Add(new Scripture(new Reference("Ephesians", 6, 10), "Finally, my brethren, be strong in the Lord, and in the power of his might.", _generator));
        _scriptures.Add(new Scripture(new Reference("Matthew", 6, 33), "But seek ye first the kingdom of God, and his righteousness; and all these things shall be added unto you.", _generator));
    }

    public Scripture GetRandomScripture()
    {
        if (_scriptures.Count  >= 0)
        {
            return _scriptures[_generator.Next(0, _scriptures.Count)];
        }
        Console.WriteLine("The scripture library is empty.");
        return null;
    }
}