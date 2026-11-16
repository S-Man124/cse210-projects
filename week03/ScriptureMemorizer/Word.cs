
public class Word
{
    // Private attributes
    private string _text;
    private bool _isHidden;

    // Constructor
    public Word(string text)
    {
        _text = text;
        _isHidden = false;
    }

    // Hide the word
    public void Hide()
    {
        _isHidden = true;
    }

    // Show the word
    public void Show()
    {
        _isHidden = false;
    }

    // Check whether the word is hidden
    public bool IsHidden()
    {
        return _isHidden;
    }

    // Return the word or underscores
    
    public string GetDisplayText()
    {
        if (!_isHidden)
        {
            return _text;
        }

        // Replace letters with underscores,
        // but preserve punctuation and numbers.
        char[] characters = _text.ToCharArray();

        for (int i = 0; i < characters.Length; i++)
        {
            if (char.IsLetter(characters[i]))
            {
                characters[i] = '_';
            }
        }

        return new string(characters);
    }

}
