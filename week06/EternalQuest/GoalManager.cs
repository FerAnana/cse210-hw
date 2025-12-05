public class GoalManager
{
  private List<Goal> _goals;
  private int _score;

  public GoalManager()
  {
    _goals = new List<Goal>();
    _score = 0;
  }

  public void Start()
  {
    while (true)
    {
      DisplayPlayerInfo();

      Console.WriteLine("\nMenu Options:");
      Console.WriteLine(" 1. Create New Goal");
      Console.WriteLine(" 2. List Goals");
      Console.WriteLine(" 3. Save Goals");
      Console.WriteLine(" 4. Load Goals");
      Console.WriteLine(" 5. Record Event");
      Console.WriteLine(" 6. Quit");
      Console.Write("Select a choice from the menu: ");

      string choice = Console.ReadLine();

      if (choice == "1") CreateGoal();
      else if (choice == "2") ListGoalDetails();
      else if (choice == "3") SaveGoals();
      else if (choice == "4") LoadGoals();
      else if (choice == "5") RecordEvent();
      else if (choice == "6") break;
      else Console.WriteLine("Invalid choice.");
    }
  }
  public void DisplayPlayerInfo()
  {
    Console.WriteLine($"You have {_score}");
  }
  public void ListGoalNames()
  {
    Console.WriteLine("The goals are;");
    for (int i = 0; i < _goals.Count; i++)
    {
      string details = _goals[i].GetDetailsString();
      Console.WriteLine($"{i + 1}. {_goals[1].GetDetailsString()}");
    }
  }
  public void ListGoalDetails()
  {
    Console.WriteLine("The goals are:");
    for (int i = 0; i < _goals.Count; i++)
    {
      Console.WriteLine($"{i + 1}. {_goals[i].GetDetailsString()}");
    }
  }
  public void CreateGoal()
  {
    Console.WriteLine("The types of Goals are:");
    Console.WriteLine(" 1. Simple Goal");
    Console.WriteLine(" 2. Eternal Goal");
    Console.WriteLine(" 3. Checklist Goal");
    Console.Write("Which type of goal would you like to create? ");
    string type = Console.ReadLine();

    Console.Write("What is the name of your goal? ");
    string name = Console.ReadLine();
    Console.Write("What is a short description of it? ");
    string desc = Console.ReadLine();
    Console.Write("What is the amount of points associated with this goal? ");
    string points = Console.ReadLine();

    if (type == "1")
    {
      _goals.Add(new SimpleGoal(name, desc, points));
    }
    else if (type == "2")
    {
      _goals.Add(new EternalGoal(name, desc, points));
    }
    else if (type == "3")
    {
      Console.Write("How many times does this goal need to be accomplished for a bonus?");
      int target = int.Parse(Console.ReadLine());
      Console.Write("What is the bonus for accomplishing it that many times? ");
      int bonus = int.Parse(Console.ReadLine());
      _goals.Add(new ChecklistGoal(name, desc, points, target, bonus));
    }
  }
  public void RecordEvent()
  {
    ListGoalNames();
    Console.Write("Which goal did you accomplish");
    int index = int.Parse(Console.ReadLine()) - 1;

    if (index >= 0 && index < _goals.Count)
    {
      Goal goal = _goals[index];

      bool wasComplete = goal.IsComplete();

      goal.RecordEvent();

      string goalString = goal.GetStringRepresentation();
      string[] parts = goalString.Split(":");
      string[] data = parts[1].Split(",");

      int pointsEarned = int.Parse(data[2]);

      if (goal is SimpleGoal && wasComplete)
      {
        pointsEarned = 0;
      }

      if (goal is ChecklistGoal)
      {
        if (!wasComplete && goal.IsComplete())
        {
          int bonus = int.Parse(data[3]);
          pointsEarned += bonus;
        }
      }

      _score += pointsEarned;

      if (pointsEarned > 0)
      {
        Console.WriteLine($"Congratulations! You have earned {pointsEarned} points!");
        Console.WriteLine($"You now have {_score} points.");
      }
      else
      {
        Console.WriteLine($"Goal already completed");
      }
    }
  }
  public void SaveGoals()
  {
    Console.Write("What is the filename for the gaol file? ");
    string filename = Console.ReadLine();

    using (StreamWriter outputFile = new StreamWriter(filename))
    {
      outputFile.WriteLine(_score);
      foreach (Goal goal in _goals)
      {
        outputFile.WriteLine(goal.GetStringRepresentation());
      }
    }
  }
  public void LoadGoals()
  {
    Console.Write("What is the filename for the goal file? ");
    string filename = Console.ReadLine();

    if (File.Exists(filename))
    {
      string[] lines = File.ReadAllLines(filename);
      _score = int.Parse(lines[0]);
      _goals.Clear();

      for (int i = 1; i < lines.Length; i++)
      {
        string[] parts = lines[i].Split(":");
        string type = parts[0];
        string[] data = parts[1].Split(",");

        if (type == "SimpleGoal")
        {
          SimpleGoal sg = new SimpleGoal(data[0], data[1], data[2]);
          if (bool.Parse(data[3]))
          {
            sg.RecordEvent();
          }
          _goals.Add(sg);
        }
        else if (type == "EternalGoal")
        {
          _goals.Add(new EternalGoal(data[0], data[1], data[2]));
        }
        else if (type == "ChecklistGoal")
        {
          ChecklistGoal cg = new ChecklistGoal(data[0], data[1], data[2], int.Parse(data[4]), int.Parse(data[3]));

          int amountCompleted = int.Parse(data[5]);
          for (int j = 0; j < amountCompleted; j++)
          {
            cg.RecordEvent();
          }
          _goals.Add(cg);
        }
      }
    }
  }
}
