public class Bicycling : Activity
{
  private double _speed;

  public Bicycling(double minutes, double speed) : base(minutes)
  {
    _speed = speed;
  }

  public override double GetDistance()
  {
    double totalHours = GetMinutes() / 60.0;
    return _speed * totalHours;
  }

  public override double GetSpeed()
  {
    return _speed;
  }

  public override double GetPace()
  {
    if (_speed == 0) return 0.0;
    return 60.0 / _speed;
  }
}