using System;
using System.Collections.Generic;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words;
    private Random _random = new Random();
public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>();

        // Split the text into words and create Word objects
        string[] splitWords = text.Split(' ');
        foreach (string wordText in splitWords)
        {
            _words.Add(new Word(wordText));
        }
    }
//method to display the scripture with hidden words
    public void HideRandomWords(int numberToHide)
    {
        List<Word> VisibleWords = new List<Word>();
        foreach (Word word in _words)
        {
            if (!word.IsHidden())
            {
                VisibleWords.Add(word);
            }
        }

        int count = Math.Min(numberToHide,VisibleWords.Count);
        for (int i = 0; i < count; i++)
        {
            int index = _random.Next(VisibleWords.Count);
            VisibleWords[index].Hide();
            VisibleWords.RemoveAt(index);
        }

    }

//method to reset the scripture to show all words
    public void Reset()
    {
        foreach (Word word in _words)
        {
            word.Show();

        }
    }

//method to get the display text of the scripture
    public string GetDisplayText()
    {
        List<string> displayWords = new List<string>();
        foreach (Word word in _words)
        {
            displayWords.Add(word.GetDisplayText());
        }
        
        return $"{_reference.GetDisplayText()} {string.Join(" ", displayWords)}";
    }

    public bool IsCompletelyHidden()
    {
        foreach (Word word in _words)
        {
            if (!word.IsHidden())
            {
                return false;
            }
        }
        return true;
    }


    }
