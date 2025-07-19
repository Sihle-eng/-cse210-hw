using System;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    public Scripture(string text)
    {
        _words = text.Split(' ').Select(w => new Word(w)).ToList();
    }
    public void HideRandomWord(int numbersToHide)
    {
        Random random = new Random();
        int hiddenCount = 0;

        while (hiddenCount < numbersToHide)
        {
            // below is a way to get a random word by using word count
            int index = random.Next(_words.Count);
            // below we are checking if words have been hidden before 
            if (!_words[index].IsHidden())
            {
                // if word was not hidden we call the hide() to replace the word with underscore
                _words[index].Hide();
                // below we increase the count so as the loop to knwo we have hidden another word
                hiddenCount++;
            }
        }
    }
    public string GetDisplayText()
    {
        // below the code _words.Select(w => w.GetDisplay() goes through my list of word objects and gets the correnct text either visible or hidden
        string unseen = string.Join(" ", _words.Select(w => w.GetDisplayText())); 
        return $"{_reference}: {unseen}";
    }
    public bool IsCompletelyHidden()
    {
        // checking if all the words are hidden
        return _words.All(w => w.IsHidden());
    }

}