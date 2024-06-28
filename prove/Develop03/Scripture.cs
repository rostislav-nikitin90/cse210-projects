namespace Develop03;

public class Scripture
{
    private readonly List<Word> _words  = [];
    private readonly List<Word> _availableWords  = [];
    private readonly Reference _reference;
    private Random _generator;

    public Scripture(Reference reference, string text, Random generator)
    {
        _reference = reference;
        _generator = generator;

        string[] wordArray = text.Split(' ');
        foreach (string word in wordArray)
        {
            _words.Add(new Word(word));
        }

        _availableWords = [.._words];
    }

    public void HideRandomWords()
    {
        int amount = _generator.Next(1, 3);

        for (int i = 0; i < amount; i++) {
            
            if (amount > _availableWords.Count)
            {
                amount = _availableWords.Count;
            }
            
            int index = _generator.Next(0, _availableWords.Count - 1);
            Word word = _availableWords[index];
            word.Hide();
            _availableWords.RemoveAt(index);
        }
    }

    public bool IsCompletelyHidden() => _words.All(word => word.IsHidden());
 

    public string DisplayScripture()
    {
        return $"{_reference.DisplayReference()}| {string.Join(" ", _words.Select(word => word.GetWord()))}";
    }

}