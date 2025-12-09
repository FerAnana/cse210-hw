public class Activity
{
  private double _distance;
  private double _speed;
  private double _pace;

  public Activity(double distance, double speed, double pace)
  {
    _distance = distance;
    _speed = speed;
    _pace = pace;
  }

  public virtual string GetSummary()
  {
    return "";
  }
}