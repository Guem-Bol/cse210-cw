
public class Scripture
{
    public Reference _Reference;
    public List<Word> _words = new List<Word>();

    private Random _random = new Random();

    public Scripture(Reference Reference, string text)
    {
        _Reference = Reference;
       ParseTextIntoWords(text);
    }

    private void ParseTextIntoWords(string text)
    {
        // A robust way to split text while handling various spaces and some punctuation.
        // You might need to adjust the Regex pattern based on how you want to handle
        // all types of punctuation.
        string[] rawWords = Regex.Split(text, @"\s+"); // Split by one or more whitespace characters

        foreach (string wordText in rawWords)
        {
            // Only add non-empty words after splitting
            if (!string.IsNullOrWhiteSpace(wordText))
            {
                // Here, you would decide if you clean punctuation *before* creating the Word object
                // or if the Word object itself handles punctuation.
                // For simplicity, let's assume the Word class will display it as given.
                // If you want to remove trailing punctuation before making it a Word:
                // string cleanedWord = Regex.Replace(wordText, @"[.,!?;:]$", "");
                // _words.Add(new Word(cleanedWord));

              _words.Add(new Word(wordText)); // Add the word as-is, let Word class handle display
            }
        }
    }


    public void HideRandomWords(int numberToHide)
    {
        int wordsToHideCount = Math.Min(numberToHide, _words.Count(w => !w.IsHidden()));

        if (wordsToHideCount == 0)
        {
            return; // No unhidden words left to hide
        }


    }

    public string GetDisplayText()
    {
        // Start with the reference
        string displayText = _Reference.GetDisplayText() + " "; // Assuming Reference has a GetDisplayText()

        // Append each word's display text, separated by a space
        foreach (Word word in _words)
        {
            displayText += word.GetDisplayText() + " ";
        }

        return displayText.Trim(); // Remove any trailing space
    }

    public bool IsCompletelyHidden()
    {
        return _words.All(word => word.IsHidden());
    }

    public void ShowAllWords()
    {
        foreach (Word word in _words)
        {
            word.Show();
        }
    }
}