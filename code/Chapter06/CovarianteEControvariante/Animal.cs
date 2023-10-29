using System.Security.Cryptography;

namespace CovarianteEControvariante;

public abstract class Animal(string name)
{
  public string Name { get; } = name;


}

public class Cat(string name) : Animal(name);

public class Dog : Animal
{
  public Dog(string name) : base(name)
  {
  }
}

public class AnimalPrinter : IPrint<Animal>
{
  public string Print(Animal toPrint)
  {
    return toPrint.Name;
  }
}

public class AnimalTransformer : ITransformer<Animal, Animal>
{
  public Animal Transform(Animal toTransForm)
  {
    var random = Random.Shared.Next(0, 2);

    return random switch
    {
      0 => new Cat(toTransForm.Name),
      1 => new Dog(toTransForm.Name),
      _ => throw new ArgumentOutOfRangeException(nameof(random))

    };

  }
}

public class DogTransformer : ITransformer<Animal, Dog>
{
  public Dog Transform(Animal toTransForm)
  {
    return new Dog(toTransForm.Name);
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