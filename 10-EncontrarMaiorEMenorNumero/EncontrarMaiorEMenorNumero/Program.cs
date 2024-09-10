float[] num = new float[15];
float maior, menor;
int cont = 0;

void MaiorNumero()
{
    if (num[cont] > maior)
        maior = num[cont];
}

void MenorNumero()
{
    if(num[cont] < menor)
        menor = num[cont];
}

do
{
    Console.WriteLine("Informe o " + (cont + 1) + " numero: ");
    num[cont] = float.Parse(Console.ReadLine());
    cont++;
} while (cont < 15);

maior = num[0];
menor = num[0];

for (cont = 1; cont < num.Length; cont++)
{
    MaiorNumero();

    MenorNumero();

}

Console.WriteLine("O maior numero e " + maior);
Console.WriteLine("O menor numero e " + menor);