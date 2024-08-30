double celsius, farenheit;

void ConverteTemperatura()
{
    farenheit = celsius * 1.8 + 32;
}

Console.Write("Informe a temperatura em graus celsius: ");
celsius = double.Parse(Console.ReadLine());

ConverteTemperatura();

Console.WriteLine("\nA temperatura e " + farenheit + "° Farenheit");