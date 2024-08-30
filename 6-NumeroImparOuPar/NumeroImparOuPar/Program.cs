int n1;

void ParImpar()
{
    if (n1 % 2 == 0)
        Console.WriteLine("O numero é par!");
    else
        Console.WriteLine("O numero é impar!");
}

Console.WriteLine("Informe um numero: ");
n1 = int.Parse(Console.ReadLine());

ParImpar();