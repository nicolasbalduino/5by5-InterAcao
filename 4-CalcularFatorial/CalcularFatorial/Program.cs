int num;

int calcularFatorial(int valor)
{
    if (valor == 0)
        return 1;
    return valor * (calcularFatorial(valor - 1));
}

Console.Write("Digite um numero para calcular seu fatorial: ");
num = int.Parse(Console.ReadLine());

Console.WriteLine($"\n{num}! = {calcularFatorial(num)}");