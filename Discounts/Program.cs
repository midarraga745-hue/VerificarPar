using Shared;

var aswer = string.Empty;
var options = new List<string> { "s", "n }" };


do
{
    var desks = ConsoleExtension.GetInt("Numero de escritorios:");
    var valueToPay = CalculateValue(desks);
    Console.WriteLine($"El valor a pagar es..: {valueToPay:C2}");
    
    do
    {
        aswer = ConsoleExtension.GetValidOptions("¿Deseas continuar [S]í, [N]o?: ", options);
    } while (!options.Any(x => x.Equals(aswer, StringComparison.CurrentCultureIgnoreCase)));
} while (aswer!.Equals("s", StringComparison.CurrentCultureIgnoreCase));

decimal CalculateValue(int desks)
{
    float discount;
    if (desks < 5)
    {
        discount = 0.1f;
    }
    else if (desks < 10)
    {
        discount = 0.2f;
    }
    else
    {
        discount = 0.4f;
    }
    return desks * 650000M * (decimal)(1 - discount);
}

Console.WriteLine("Game Over.");
