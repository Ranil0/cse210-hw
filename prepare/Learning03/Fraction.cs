using System;

public class Fraction
{
  private int _numer;
  private int _denom;

  public Fraction()
  {
    _numer = 1;
    _denom = 1;
  }
  public Fraction(int wholeNumber)
  {
    _numer = wholeNumber;
    _denom = 1;
  }

  public Fraction(int numer, int denom )
  {
    _numer = numer;
    _denom = denom;
  }

  public string GetFractionString()
  {
    String text = $"{_numer}/{_denom}";
    return text;
  }
  public double GetDecimalValue()
  {
    return (double)_numer / (double)_denom;
  }
}