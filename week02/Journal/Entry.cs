public class Entry()
{
  public string _date = "November, 2025";
  public string _promptText;
  public string _entryText;
  public void Display()
  {
    Console.WriteLine($"{_date} - {_promptText}: {_entryText}");
  }
}