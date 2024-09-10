float precoAlcool, precoGasolina;

float RazaoCombustivel()
{
    return precoAlcool / precoGasolina;
}

Console.WriteLine("Informe o preco do alcool: ");
precoAlcool = float.Parse(Console.ReadLine());

Console.WriteLine("Informe o preco da gasolina: ");
precoGasolina = float.Parse(Console.ReadLine());

if (RazaoCombustivel() <= 0.72)
    Console.WriteLine("Compre alcool");
else
    Console.WriteLine("Compre Gasolina");