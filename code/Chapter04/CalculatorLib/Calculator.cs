namespace CalculatorLib;

public class Calculator
{
  public double Add(double a, double b)
  {
    return a + b;
  }

  public double Divide(double dividendo, double divisore)
  {
    ArgumentOutOfRangeException.ThrowIfNegativeOrZero(divisore, paramName: nameof(divisore));
    return dividendo / divisore;
  }

}
