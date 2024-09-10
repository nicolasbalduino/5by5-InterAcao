int somaImpar = 0, somaPar = 0, num = 0;

void SomaPar()
{
    somaPar += num;
}

void SomaImpar()
{
    somaImpar += num;
}

void ParImpar()
{
    if (num % 2 == 0)
        SomaPar();
    else
        SomaImpar();
}

do
{
    ParImpar();

    Console.WriteLine("informe um numero de 1 a 999 para ser somado: ");
    num = int.Parse(Console.ReadLine());
} while (num > 0 && num < 1000);

Console.WriteLine("par: " + somaPar);
Console.WriteLine("impar: " + somaImpar);