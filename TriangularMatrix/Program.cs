
using Shared;

var answer = string.Empty;
var options = new List<string> { "s", "n" };

do
{
    var number = ConsoleExtension.GetInt("Ingrese un numero: ");
}
while (answer!.Equals("s", StringComparison.CurrentCultureIgnoreCase));