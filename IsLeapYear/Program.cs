using Shared;

do
{
    var currentYear = DateTime.Now.Year;
    var message = string.Empty;
    var year = ConsoleExtension.GetInt("Ingrese año:");

    if (year == currentYear)
    {
        message = "es";
    } else if(year > currentYear)
    {
        message = "va a ser";
    }
    else
    {
        message = "fue";
    }


   if (year % 4 == 0)
    {
        if (year % 100 == 0)
        {
            if (year % 400 == 0)
            {
                Console.WriteLine($"El año: {year}, SI es bisiesto.");
            }
            else
            {
                Console.WriteLine($"El año: {year}, No es bisiesto.");
            }
        }
        else
        {
            Console.WriteLine($"El año: {year}, SI es bisiesto.");
        }
    }
    else
    {
        Console.WriteLine($"El año: {year}, No es bisiesto.");
    }
} while (true);
