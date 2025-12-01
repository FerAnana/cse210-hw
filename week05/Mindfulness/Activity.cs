public class Activity
{
  private string _name;
  private string _description;
  protected int _duration;

  public Activity(string name, string description)
  {
    _name = name;
    _description = description;
  }

  public static string DisplayMenu()
    {
      Console.Clear();
      Console.WriteLine("Mindfulness Program Menu");
      Console.WriteLine("1. Breathing Activity");
      Console.WriteLine("2. Reflection Activity");
      Console.WriteLine("3. Listing Activity");
      Console.WriteLine("4. Quit");
      Console.Write("Select a choice from the menu: ");
      return Console.ReadLine();
    }

  public void Run()
  {
    DisplayStartingMessage();

    Console.Clear();
    Console.WriteLine("Get ready...");
    ShowSpinner(3);

    RunActivity();

    DisplayEndingMessage();
  }
  
  protected void DisplayStartingMessage()
  {
    Console.Clear();
    Console.WriteLine($"Welcome to the {_name}");
    Console.WriteLine();
    Console.WriteLine($"Description: {_description}");
    Console.WriteLine();
    Console.Write("How long, in seconds, would you like for your session? ");
    
    while (!int.TryParse(Console.ReadLine(), out _duration) || _duration <= 0)
    {
      Console.Write("Invalid input. Please enter a positive number of seconds: ");
    }
  }

  protected virtual void RunActivity()
  {

  }

  protected void DisplayEndingMessage()
  {
    Console.WriteLine();
    Console.WriteLine("Well done!!");
    ShowSpinner(3);

    Console.WriteLine();
    Console.WriteLine($"You have completed the {_name} activity for {_duration} seconds.");
    ShowSpinner(4);
  }

  protected void ShowSpinner(int seconds)
  {
    string[] spinner = { "|", "/", "-", "\\" };
    DateTime startTime = DateTime.Now;
    DateTime endTime = startTime.AddSeconds(seconds);
    int i = 0;

    while (DateTime.Now < endTime)
    {
      Console.Write(spinner[i]);
      Thread.Sleep(250);
      Console.Write("\b");
      i = (i + 1) % spinner.Length;
    }
  }

  protected void ShowCountdown(int seconds)
  {
    for (int i = seconds; i > 0; i--)
    {
      Console.Write($"{i}");
      Thread.Sleep(1000);
      Console.Write("\b \b"); 
    }
  }
}