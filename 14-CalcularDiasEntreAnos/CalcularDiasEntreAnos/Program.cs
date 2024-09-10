int anoInicial, anoFinal, ano, qtdDias = 0;

void AnoBissexto()
{
    if (ano % 400 == 0 || ((ano % 4 == 0) && (ano % 100 != 0)))
        qtdDias += 1;
}

Console.WriteLine("Informe o ano inicial: ");
anoInicial = int.Parse(Console.ReadLine());

Console.WriteLine("Informe o ano final: ");
anoFinal = int.Parse(Console.ReadLine());

for (ano = anoInicial; ano < anoFinal; ano++)
    AnoBissexto();

qtdDias += (anoFinal - anoInicial) * 365;

Console.WriteLine("Tiveram " + qtdDias + " dias.");