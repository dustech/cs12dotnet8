using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using CovarianteEControvariante;

Dog axel = new("Axel", 15);
Cat limon = new("Lion", 5);
AnimalPrinter printer = new();


WriteLine(printer.Print(axel));

AnimalTransformer transformer = new();

var myAnimal = transformer.Transform(axel);

Func<Animal, string> tellMeTheAnimal = (myAnimal) =>
{
  return myAnimal switch
  {
    Cat a => "Abbiamo un bel gatto {0}",
    Dog a => "Abbiamo un bel cane {0}",
    _ => "Abbiamo un animale di specie non identificata!"

  };
};

DogTransformer dogTransformer = new();

var poorLimon = dogTransformer.Transform(limon);

WriteLine(tellMeTheAnimal(myAnimal), myAnimal.Name);

WriteLine(tellMeTheAnimal(poorLimon), poorLimon.Name);



