public class PromptGenerator
{
  public List<string> _prompts = new List<string>
  { 
    "How did I see the hand of the Lord in my life today?",
    "If I had one thing I could do over today, what would it be and why?",
    "Who was the most interesting person I interacted with today?",
    "Did I do something good today?",
    "What do I remember the most of today?"
  };
  public string GetRandomPrompt()
  {
    Random prompt = new Random();
    int promptIndex = prompt.Next(_prompts.Count);
    string randomPrompt = _prompts[promptIndex];
    return randomPrompt;
  }
}