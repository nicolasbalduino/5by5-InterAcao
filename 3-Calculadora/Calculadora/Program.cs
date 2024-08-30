double num1, num2;
int opcao = 0;

int Menu()
{
    Console.Clear();
    Console.WriteLine("1 - Somar");
    Console.WriteLine("2 - Subtrair");
    Console.WriteLine("3 - Multiplicar");
    Console.WriteLine("4 - Dividir");
    Console.WriteLine("5 - Sair");
    Console.WriteLine("Escolha uma opção: ");

    return int.Parse(Console.ReadLine());
}

double CalcularSoma()
{
    return num1 + num2;
}

double CalcularSubtracao()
{
    return num1 - num2;
}

double CalcularMultiplicacao()
{
    return num1 * num2;
}

double CalcularDivisao()
{
    if (num2 == 0)
        return 0;
    else
        return num1 / num2;
}

Console.WriteLine("Informe o primeiro numero: ");
num1 = double.Parse(Console.ReadLine());

Console.WriteLine("Informe o segundo numero: ");
num2 = double.Parse(Console.ReadLine());

while (opcao != 5)
{
    opcao = Menu();

    switch (opcao)
    {
        default:
            Console.WriteLine("Opção inválida!");
            break;
        case 1:
            Console.WriteLine("A soma dos numeros é: " + CalcularSoma());
            break;
        case 2:
            Console.WriteLine("A subtração dos numeros é: " + CalcularSubtracao());
            break;
        case 3:
            Console.WriteLine("O produto dos numeros é: " + CalcularMultiplicacao());
            break;
        case 4:
            Console.WriteLine("A divisão dos numeros é: " + CalcularDivisao());
            break;
        case 5:
            Console.WriteLine("Até logo!");
            break;
    }

    Console.Write("Pressione uma tecla para continuar");
    Console.ReadLine();
}