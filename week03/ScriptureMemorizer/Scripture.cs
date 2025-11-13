public class Scripture
{
  private Reference _reference;
  private List<Word> _words;

  public Scripture(Reference reference, string text)
  {
    _reference = reference;
    _words = text.Split(' ').Select(wordText => new Word(wordText)).ToList();
  }

  public void HideRandomWords(int numberToHide)
  {
    List<Word> availableWords = _words.Where(w => !w.IsHidden()).ToList();

    if (availableWords.Count == 0)
      return;

    Random _random = new Random();

    int wordsToHide = Math.Min(numberToHide, availableWords.Count);

    for (int i = 0; i < wordsToHide; i++)
    {
      int randomIndex = _random.Next(0, availableWords.Count);

      availableWords[randomIndex].Hide();

      availableWords.RemoveAt(randomIndex);
    }
  }

  public bool IsCompletelyHidden()
  {
    return _words.All(w => w.IsHidden());
  }

  public string GetDisplayText()
  {
    string referenceText = _reference.GetDisplayText();

    string scriptureText = string.Join(" ", _words.Select(w => w.GetDisplayText()));

    return $"{referenceText} {scriptureText}";
  }
}