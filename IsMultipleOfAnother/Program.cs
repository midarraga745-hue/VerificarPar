using Shared;

do
{
    var a = ConsoleExtension.GetInt("Ingrese primer numero : ");
    var b = ConsoleExtension.GetInt("Ingrese segundo numero:");
    if (b % a == 0)
    {
        Console.WriteLine($"{a} es multiplo {b}");               
    }
    else
    {
        Console.WriteLine($"{a} no es multiplo {b}");
    }
} while (true);


