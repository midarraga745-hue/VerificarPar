using Shared;

var answer = string.Empty;
var options = new List<string> { "s", "n" };

do
{
    Console.WriteLine("Ingrese 3 numeros diferentes");
    var a = ConsoleExtension.GetInt("Ingrese primer numero : ");
    var b = ConsoleExtension.GetInt("Ingrese segundo numero: ");
    var c = ConsoleExtension.GetInt("Ingrese tercero numero: ");

    if (a > b && a > c)
            {
        Console.WriteLine($"El numero {a} es el mayor");
    }
    else if (b > a && b > c)
    {
        Console.WriteLine($"El numero {b} es el mayor");
    }
    else 
    {
        Console.WriteLine($"El numero {c} es el mayor");
    }
    do
    {
        answer = ConsoleExtension.GetValidOptions("¿Deseas continuar [S]í, [N]o?: ", options);
    } while (!options.Any(x => x.Equals(answer, StringComparison.CurrentCultureIgnoreCase)));

} while (answer!.Equals("s", StringComparison.CurrentCultureIgnoreCase));

Console.WriteLine("Game Over,");