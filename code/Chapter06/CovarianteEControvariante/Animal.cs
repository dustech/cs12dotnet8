using System.ComponentModel.DataAnnotations;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography;

namespace CovarianteEControvariante;


public abstract record Animal(string Name, int Mass)
{
  public int Mass { get; } = ValidateMass(Mass) ? Mass : throw new ArgumentOutOfRangeException();
  private static bool ValidateMass(int mass) => mass >= 0;

  public virtual int MetersMoved(double energy)
  {
    return Mass switch
    {
      0 => 0,
      int m => (int)Math.Round(energy / m)
    };
  }
}

public record Cat(string Name, int Mass) : Animal(Name, Mass)
{

  public override int MetersMoved(double energy)
  {
    return base.MetersMoved(energy) * 2;
  }
}

public record Dog : Animal
{
  public Dog(string name, int mass) : base(name, mass)
  {
  }
  public string Bark(int howManyTimes)
  {
    return AddBarks(howManyTimes);

    string AddBarks(int h)
    {
      return h switch
      {
        <= 0 => String.Empty,
        int n when n == 1 => "wof",
        int n => string.Join(" ", "wof", AddBarks(n - 1))
      };
    }

  }
}

public record Joy(string Name, int Mass) : Dog(Name, Mass);

public record AnimalPrinter : IPrint<Animal>
{
  public string Print(Animal toPrint)
  {
    return toPrint.Name;
  }
}

public record AnimalTransformer : ITransformer<Animal, Animal>
{
  public Animal Transform(Animal toTransForm)
  {
    var random = Random.Shared.Next(0, 2);

    return random switch
    {
      0 => new Cat(toTransForm.Name, toTransForm.Mass),
      1 => new Dog(toTransForm.Name, toTransForm.Mass),
      _ => throw new ArgumentOutOfRangeException(nameof(random))

    };

  }
}

public record DogTransformer : ITransformer<Animal, Dog>
{
  public Dog Transform(Animal toTransForm)
  {
    return new Dog(toTransForm.Name, toTransForm.Mass);
  }
}

public record JoyTransformer : ITransformer<Animal, Joy>
{
  public Joy Transform(Animal toTransForm)
  {
    return new Joy(toTransForm.Name, toTransForm.Mass);
  }
}

public record Murrino(string Name, int Mass) : Animal(Name, Mass);

public record MurrinoTransformer : ITransformer<Animal, Murrino>
{
  public Murrino Transform(Animal toTransForm)
  {
    return new Murrino(toTransForm.Name, toTransForm.Mass);
  }
}

public interface IPrint<in T>
{
  string Print(T toPrint);
}

public interface ITransformer<T1, T2>
{
  T2 Transform(T1 toTransForm);
}