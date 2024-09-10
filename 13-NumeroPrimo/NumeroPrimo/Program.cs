float num;
int aux;

void NumeroPrimo()
{
    for (int i = 2; i < num; i++)
        if (num % i == 0)
            aux = i;
}

Console.WriteLine("Digite um numero para saber se e primo: ");
num = float.Parse(Console.ReadLine());

aux = 0;
NumeroPrimo();

if (aux == 0)
    Console.WriteLine("Este numero é primo!");
else
{
    Console.WriteLine("Este numero nao e primo!");
}