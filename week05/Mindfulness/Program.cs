using System;

class Program
{
  static void Main(string[] args)
  {
    string choice = "";

    while (choice != "4")
    {
      choice = Activity.DisplayMenu();
      Activity activity = null;

      switch (choice)
      {
        case "1":
          activity = new BreathingActivity();
          break;
        case "2":
          activity = new ReflectionActivity();
          break;
        case "3":
          activity = new ListingActivity();
          break;
        case "4":
          break;
        default:
          Console.WriteLine("Invalid choice. Please enter 1, 2, 3, or 4.");
          break;
      }

      if (activity != null)
      {
        activity.Run();
      }
    }
  }
}