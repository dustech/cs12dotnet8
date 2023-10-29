using System.Text;
using static System.Console;


var laMiaStringaLunga = "Ciao sono un grassissimo cavallo pieno di peli e con 4 zoccoli";

var base64 = DaStringaABase64(laMiaStringaLunga);

WriteLine(base64);

var tornaStringa = DaBase64AStringa(base64);

WriteLine(tornaStringa);


static string DaStringaABase64(string myString) => Convert.ToBase64String(Encoding.UTF8.GetBytes(myString));

static string DaBase64AStringa(string myBase64String) => Encoding.UTF8.GetString(Convert.FromBase64String(myBase64String));
