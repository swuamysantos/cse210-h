using System;
using System.Collections.Generic;
using System.ComponentModel;

public class Scripture
{
    private References _reference;
    private List<Word> _words;
    private Random _random = new Random();
    public Scripture(References reference, string text)
    {
        _reference = reference;
        _words = new List<Word>();
        foreach (string wordText in text.Split(" "))
        {
            _words.Add(new Word(wordText));
        }
    }
    public void HideRandomWords(int count)
    {
        for (int i = 0; i < count; i++)
        {
            int index = _random.Next(_words.Count);
            _words[index].MarkAsMemorized();
        }
    }

    public bool IsCompletelyHidden()
    {
        foreach (Word word in _words)
        {
            if (!word.IsMemorized())
            {
                return false;
            }
        }
        return true;
    }

    public string GetDisplayText()
    {
        string text = "";
        foreach (Word word in _words)
        {
            text += word.GetDisplayText() + " ";
        }

        return $"{_reference.GetDisplayText()}\n{text}";
    }
}

