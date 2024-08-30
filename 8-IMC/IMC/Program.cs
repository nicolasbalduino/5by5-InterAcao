float altura, peso, imc;
char sexo;

void CalcularIMC(){
    imc = peso / (altura * altura);
}

Console.WriteLine("Informe a sua altura: ");
altura = float.Parse(Console.ReadLine());

Console.WriteLine("Informe o seu peso: ");
peso = float.Parse(Console.ReadLine());

Console.WriteLine("Informe o seu sexo: ");
sexo = char.Parse(Console.ReadLine().ToUpper());

CalcularIMC();

if (sexo == 'M')
{
    if (imc < 20.7)
    {
        Console.WriteLine("Abaixo do peso");
    }
    else
    {
        if (imc < 26.5)
        {
            Console.WriteLine("Peso ideal");
        }
        else
        {
            if (imc < 27.9)
            {
                Console.WriteLine("Pouco acima do peso");
            }
            else
            {
                if (imc < 31.2)
                {
                    Console.WriteLine("acima do peso");
                }
                else
                {
                    Console.WriteLine("Obesidade");
                }
            }
        }
    }
}
else
{
    if (imc < 19.1)
    {
        Console.WriteLine("Abaixo do peso");
    }
    else
    {
        if (imc < 25.9)
        {
            Console.WriteLine("Peso ideal");
        }
        else
        {
            if (imc < 27.4)
            {
                Console.WriteLine("Pouco acima do peso");
            }
            else
            {
                if (imc < 32.4)
                {
                    Console.WriteLine("acima do peso");
                }
                else
                {
                    Console.WriteLine("Obesidade");
                }
            }
        }
    }
}