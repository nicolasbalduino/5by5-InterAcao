int num;

void CalcularTabuada()
{
    for (int i = 0; i < 11; i++)
    {
        Console.WriteLine(num + "x" + i + "=" + num * i);
    }
}

do
{
    Console.WriteLine("Informe um numero de 1 a 9 para fazer a tabuada: ");
    num = int.Parse(Console.ReadLine());
} while (num < 1 || num > 9);

CalcularTabuada();