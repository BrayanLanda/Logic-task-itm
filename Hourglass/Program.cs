using Shared;

var answer = string.Empty;
var options = new List<string> { "s", "n" };

do
{
    var n = ConsoleExtension.GetInt("Ingrese orden de la matriz: ");

    var matriz = new int[n, n];

    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < n; j++)
        {
            matriz[i, j] = 2 * i + j;
        }
    }

    Console.WriteLine("MATRIZ COMPLETA");
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < n; j++)
        {
            Console.Write($"{matriz[i, j],4}");
        }
        Console.WriteLine();
    }

    Console.WriteLine("RELOJ DE ARENA");
    for (int i = 0; i < n; i++)
    {
        int k = Math.Min(i, n - 1 - i);
        for (int j = 0; j < n; j++)
        {
            if (j >= k && j <= n - 1 - k)
                Console.Write($"{matriz[i, j],4}");
            else
                Console.Write(new string(' ', 4));
        }
        Console.WriteLine();
    }

    do
    {
        answer = ConsoleExtension.GetValidOptions("¿Deseas continuar [S]í, [N]o?: ", options);
    } while (!options.Any(x => x.Equals(answer, StringComparison.CurrentCultureIgnoreCase)));

} while (answer!.Equals("s", StringComparison.CurrentCultureIgnoreCase));

Console.WriteLine("Game Over.");