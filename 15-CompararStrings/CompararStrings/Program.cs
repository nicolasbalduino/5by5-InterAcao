string frase, fraseCompara;

Console.Write("Digite alguns caracteres: ");
frase = Console.ReadLine();

Console.Write("Digite mais alguns caracteres: ");
fraseCompara = Console.ReadLine();

if (frase.Equals(fraseCompara))
    Console.Write("\nAs strings são iguais\n");
else
    Console.Write("\nAs strings são diferentes\n");