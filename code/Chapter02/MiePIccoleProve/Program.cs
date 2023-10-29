using System;
namespace MiePiccoleProve
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Hello, World!");
      ProngoMizio prongo = new();
      Console.WriteLine($$"""{{prongo.DimmiTutto}}""");

    }
  }

  public class ProngoMizio
  {
    public string DimmiTutto { get => "Dimmi Tutto"; }
  }
}