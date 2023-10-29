
using MiePiccoleProve;

Console.WriteLine("Hello, World!");

PiccoleProveFelici cannolo = new() { Cannolo = "piccolo cane" };

Console.WriteLine(cannolo.Cannolo);

(string, int) congo = cannolo.Trick();

var primo = congo.Item1;
var secondo = congo.Item2;

(string canga, int roo) = congo;

WriteLine("{0} - {1} - {2} - {3}", primo, secondo, canga, roo);

var pane = cannolo.Trick2();
var bongami = pane.Bongami;
var pippo = pane.Quanto;

WriteLine("{0} | {1}", bongami, pippo);