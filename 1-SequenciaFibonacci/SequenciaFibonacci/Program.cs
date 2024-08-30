int parada, numAnterior, numAtual;

do
{
    Console.Write("Informe a posicao de parada (deve ser maior que zero): ");
    parada = int.Parse(Console.ReadLine());
} while (parada < 1);

numAnterior = 1;
numAtual = 0;

for (int i = 0; i < parada; i++)
{
    numAtual += numAnterior;
    numAnterior = numAtual - numAnterior;
    Console.WriteLine(numAtual);
}