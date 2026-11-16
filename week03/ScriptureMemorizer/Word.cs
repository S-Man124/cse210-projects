
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
        // Implementation will be added later
    }

    // Show the word
    public void Show()
    {
        // Implementation will be added later
    }

    // Check whether the word is hidden
    public bool IsHidden()
    {
        return _isHidden;
    }

    // Get the word's display text
    public string GetDisplayText()
    {
        return _text;
    }
}
