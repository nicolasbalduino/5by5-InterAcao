internal class Program
{
    public class Pessoa
    {
        string _nome;
        string _sobrenome;

        public Pessoa () { }

        public void DefinirNome(string nome)
        {
            this._nome = nome;
        }
        public string RetornarNome() 
        { 
            return this._nome; 
        }

        public void DefinirSobrenome(string sobrenome)
        {
            this._sobrenome = sobrenome;
        }
        public string RetornarSobrenome()
        {
            return this._sobrenome;
        }

        public string RetornarNomeCompleto()
        {
            return RetornarNome() + " " + RetornarSobrenome();
            //return Console.WriteLine("Nome completo:" + RetornarNome() + RetornarSobrenome());
        }

    }
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        Pessoa p = new Pessoa ();

        Console.Write("Informe o seu nome: ");
        p.DefinirNome(Console.ReadLine());

        Console.Write("Informe o seu sobrenome: ");
        p.DefinirSobrenome(Console.ReadLine());

        Console.WriteLine("Seja bem vindo a orientação a objetos, " + p.RetornarNomeCompleto() );
    }
}