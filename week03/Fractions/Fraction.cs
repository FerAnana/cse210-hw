using System.Diagnostics;
using System.Reflection.Metadata;
using System.Reflection.Metadata.Ecma335;

public class Fraction
{
  private int _top;
  private int _bottom;

  public Fraction()
  {
    _top = 1;
    _bottom = 1;
  }

  public Fraction(int wholeNumber)
  {
    _top = wholeNumber;
    _bottom = 1;
  }

  public Fraction(int top, int bottom)
  {
    _top = top;
    _bottom = bottom;
  }

  public int GetTop()
  {
    return _top;
  }

  public int SetTop(int top)
  {
    _top = top;

    return _top;
  }

    public int GetBottom()
  {
    return _bottom;
  }

  public int SetBottom(int bottom)
  {
    _bottom = bottom;

    return _bottom;
  }

  public string GetFractionString()
  {
    string _getFraction = $"{GetTop()}/{GetBottom()}";
    return _getFraction;
  }

  public double GetDecimalValue()
  {
    return (double)_top / (double)_bottom;
  }
}