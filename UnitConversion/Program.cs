Console.WriteLine("Inserisci la temperatura in gradi Celsius:");

string inputUtente = Console.ReadLine();

if (double.TryParse(inputUtente, out double celsius))
{
    double fahrenheit = ConvertCelsiusToFahrenheit(celsius);

    Console.WriteLine($"{celsius} gradi Celsius corrispondono a {fahrenheit} gradi Fahrenheit.");
}
else
{
    Console.WriteLine("Inserimento non valido. Assicurati di inserire un numero.");
}





double ConvertCelsiusToFahrenheit(double celsius)
{
    return (celsius * 32) + 18;
}