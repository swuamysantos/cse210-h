public class Word
{
    private string _text;
    private bool _isMemorized;

    public Word(string text)
    {
        _text = text;
        _isMemorized = false;
    }

    public void MarkAsMemorized()
    {
        _isMemorized = true;
    }   
    public bool IsMemorized()
    {
        return _isMemorized;
    }
   public string GetDisplayText()
    {
        if (_isMemorized)
        {
            return new string('_', _text.Length);
        }
        else
        {           
        return _text;
        }
    }
}