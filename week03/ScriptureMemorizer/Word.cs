using System;

public class Word
{
    private string _text;
    private bool _isHidden;

    //Constructor to connect word with text
     public Word(string text)
    {
       _text = text;
       _isHidden = false; 
    }

    //Method to hide the word
    public void Hide()
    {
        _isHidden = true;
    }

    public void Show()
    {
        _isHidden = false;
    }
    public bool IsHidden()
    {
        return _isHidden;
    }
    
    //Get the display text for the words, show underscore for hidden words
    public string GetDisplayText()
    {
        if (!_isHidden)
        {
            return _text;
        }

        string hiddenText = "";
        foreach (char c in _text)
        {
            if(char.IsLetterOrDigit(c))
            {
                hiddenText += "_";
            }
            else
            {
                hiddenText += c;
            }
        }
        return hiddenText ;

    }



   

}