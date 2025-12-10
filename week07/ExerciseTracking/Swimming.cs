public class Swimming : Activity
{
  private double lapLength = 50.0;
  private double _lapsNum;

  public Swimming(double minutes, int laps) : base(minutes)
  {
    _lapsNum = laps;
  }

  public override double GetDistance()
  {
    return lapLength * 50 / 1000;
  }

  public override double GetSpeed()
  {
    return CalculateSpeed(GetDistance());
  }

  public override double GetPace()
  {
    return CalculatePace(GetDistance());
  }
}