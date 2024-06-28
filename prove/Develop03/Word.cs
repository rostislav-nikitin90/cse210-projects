using System.Text;

namespace Develop03;

internal class Word(string text)
{
    private string _text = text;
    private bool _isHidden;

    public void Hide()
    {
        if (!IsHidden())
        {
            StringBuilder builder = new StringBuilder();
            foreach (char character in _text)
            {
                
                if (char.IsLetterOrDigit(character))
                {
                    builder.Append("_");
                    continue;
                }

                builder.Append(character);
            }
            _text = builder.ToString();
            _isHidden = !_isHidden;
        }
    }
    public bool IsHidden() => _isHidden;
    public string GetWord() => _text;
}