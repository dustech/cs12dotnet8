// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, C#!");

new Cocco().Bongo(prodigioso: 9);

public class Cocco
{
  public void Bongo(int prodigioso)
  {
    for (var i = 0; i < prodigioso; i++)
    {
      Console.WriteLine("bongo");
    }

  }
}