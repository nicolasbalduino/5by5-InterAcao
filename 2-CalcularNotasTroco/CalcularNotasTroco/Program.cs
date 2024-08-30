float valorConta, valorPago, troco; 
int qtdNotas;

Console.WriteLine("Informe o valor da conta: ");
valorConta = float.Parse(Console.ReadLine());

Console.WriteLine("Informe o valor pago: ");
valorPago = float.Parse(Console.ReadLine());

troco = valorPago - valorConta;

if (troco >= 100)
{
    qtdNotas = (int)troco / 100;
    troco = troco % 100;
    Console.WriteLine(qtdNotas + " Notas de 100");
}
if (troco >= 50)
{
    qtdNotas = (int)troco / 50;
    troco = troco % 50;
    Console.WriteLine(qtdNotas + " Notas de 50");
}
if (troco >= 20)
{
    qtdNotas = (int)troco / 20;
    troco = troco % 20;
    Console.WriteLine(qtdNotas + " Notas de 20");
}
if (troco >= 10)
{
    qtdNotas = (int)troco / 10;
    troco = troco % 10;
    Console.WriteLine(qtdNotas + " Notas de 10");
}
if (troco >= 5)
{
    qtdNotas = (int)troco / 5;
    troco = troco % 5;
    Console.WriteLine(qtdNotas + " Notas de 5");
}
if (troco >= 2)
{
    qtdNotas = (int)troco / 2;
    troco = troco % 2;
    Console.WriteLine(qtdNotas + " Notas de 2");
}
if(troco != 0)
{
    Console.WriteLine("Falta " + troco + " real(is)");
}