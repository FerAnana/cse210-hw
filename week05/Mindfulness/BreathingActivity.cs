public class BreathingActivity : Activity
{
  public BreathingActivity()
      : base("Breathing Activity", "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.")
  {
  }

  protected override void RunActivity()
  {
    DateTime startTime = DateTime.Now;
    DateTime endTime = startTime.AddSeconds(_duration);

    while (DateTime.Now < endTime)
    {
      Console.Write("Breathe in...");
      ShowCountdown(5);
      Console.WriteLine();

      if (DateTime.Now >= endTime) break;
      Console.Write("Breathe out...");
      ShowCountdown(5);
      Console.WriteLine();
    }
    Console.WriteLine();
  }
}