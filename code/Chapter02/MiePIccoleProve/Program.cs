using System;
//using static System.Console; // l'opzione statica e' messa nel file di progetto 

namespace MiePiccoleProve
{
  class Program
  {
    static void Main(string[] args)
    {
      // WriteLine("Hello, World!");
      // ProngoMizio prongo = new();
      // WriteLine($$"""{{prongo.DimmiTutto}}""");
      ProngoMizio prongy = new("Gino");
      prongy = null;
      int bonzio = prongy?.Cannolo ?? 20;
      int cano = prongy?.Cannolo ?? 35;
      string myS = prongy?.DimmiTutto;
      WriteLine(myS);

    }
  }

  public class ProngoMizio
  {
    public ProngoMizio(string pinuccio)
    {
      if (string.IsNullOrEmpty(pinuccio))
      {
        throw new ArgumentException($"'{nameof(pinuccio)}' cannot be null or empty.", nameof(pinuccio));
      }

      Pinuccio = pinuccio;
    }
    public int Cannolo => 10;
    public string DimmiTutto { get => "Dimmi Tutto"; }
    public string Pinuccio { get; }
  }
}