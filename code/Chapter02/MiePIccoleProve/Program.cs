using System;
//using static System.Console; // l'opzione statica e' messa nel file di progetto 

namespace MiePiccoleProve
{
  class Program
  {
    static void Main(string[] args)
    {
      WriteLine("Hello, World!");
      ProngoMizio prongo = new();
      WriteLine($$"""{{prongo.DimmiTutto}}""");

    }
  }

  public class ProngoMizio
  {
    public string DimmiTutto { get => "Dimmi Tutto"; }
  }
}