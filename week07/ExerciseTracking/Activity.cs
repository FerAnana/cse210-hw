using System.Reflection.Metadata.Ecma335;

public abstract class Activity
{
  private readonly DateTime _date;
  private double _minutes;

  public Activity(double minutes)
  {
    _date = DateTime.Now;
    _minutes = minutes;
  }

  public double GetMinutes()
  {
    return _minutes;
  }
  public abstract double GetDistance();
  public abstract double GetSpeed();
  public abstract double GetPace();

  public double CalculateSpeed(double distance)
  {
    if (_minutes == 0) return 0.0;
    return (distance / _minutes) * 60;
  }

  public double CalculatePace(double distance)
  {
    if (_minutes == 0) return 0.0;
    return _minutes / distance;
  }

  public string GetSummary()
  {
    double distance = GetDistance();
    double speed = GetSpeed();
    double pace = GetPace();
    string activityType = this.GetType().Name;

    return $"{_date:dd MMM yyyy} {activityType} ({_minutes:0} min)- Distance {distance:0}km, Speed: {speed:0}kph, Pace: {pace:0} min per km";
  }
}