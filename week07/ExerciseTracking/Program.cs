using System;

class Program
{
    static void Main(string[] args)
    {
        Running run1 = new Running(20, 5);
        Bicycling cycle1 = new Bicycling(45, 40);
        Swimming swim1 = new Swimming(35, 6);

        List<Activity> activities = new List<Activity> { run1, cycle1, swim1 };

        foreach(Activity activity in activities)
    {
            Console.WriteLine(activity.GetSummary());
    }
    }
}