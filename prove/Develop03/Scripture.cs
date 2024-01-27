using System;
using System.Diagnostics.Contracts;
public class Scripture
{
    private Reference _reference;
    private List<Word> _words = new List<Word>();


    public List<Word> Words
        {
            get {return _words;}
        }


    public Scripture(Reference Reference, string text)
    {
        _reference = Reference;
         string[] wordArray = text.Split(" ");
        // Create Word objects   
        foreach (string wordText in wordArray)
        {
            _words.Add(new Word(wordText));
        }
    }

    public void HideRandomWords(int numberToHide)
    {
    Random random = new Random();
    HashSet<Word> wordsToHide = new HashSet<Word>();

        for (int i = 0; i < numberToHide; i++)
        {
            Word word;

            do
            {
                int index = random.Next(_words.Count);
                word = _words[index];
            } while (wordsToHide.Contains(word));

            word.Hide();
            wordsToHide.Add(word);
        }
    }
    
    public string GetDisplayText()
    {
        string displayText = $"{_reference.GetDisplayText()}\n";
        foreach (Word word in _words)
        {
            displayText = $"{displayText}{word.GetDisplayText()} ";
        }
        return displayText.Trim();
    }

    public bool IsCompletelyHidden()
    {
        foreach (Word word in _words)
        {
            if (word.IsHidden()==false)
              {
                return false;
              }
            
        }
        return true;
    }

}