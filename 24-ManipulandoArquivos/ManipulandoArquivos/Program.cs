using System.Globalization;
using ManipulandoArquivos;

internal class Program
{
    private static void Main(string[] args)
    {
        string name;
        string file;
        char gender;

        string fixedtext = @"";

        Person person1 = CreatePerson();
        Person person2 = CreatePerson();

        WriteFile(person1);

        WriteFile(person2);

        Console.Clear();

        Console.Write("Informe o nome do arquivo a ser lido: ");
        file = Console.ReadLine();

        var texto = ReadFile(file);

        Console.WriteLine(texto);

        void WriteFile(Person person)
        {
            try
            {
                if (File.Exists("backup.txt"))
                {
                    var temp = ReadFile("backup.txt");
                    StreamWriter sw = new("backup.txt");
                    sw.WriteLine(temp + person.ToString());
                    sw.Close();
                }
                else
                {
                    StreamWriter sw = new("backup.txt");
                    sw.WriteLine(person.ToString());
                    sw.Close();
                }
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                Console.WriteLine("Registro Gravado com Sucesso!");
                Thread.Sleep(1000);
            }
        }

        string ReadFile(string f)
        {
            StreamReader sr = new StreamReader(f);
            string text = "";
            try
            {
                text = sr.ReadToEnd();
                sr.ReadLine();
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                sr.Close();
            }
            return text;
        }

        Person CreatePerson()
        {
            Console.Write("Informe o nome da pessoa: ");
            var name = Console.ReadLine();
            Console.Write("\nInforme o genero da pessoa: ");
            var gender = char.Parse(Console.ReadLine());

            return new Person(name, gender);
        }
    }
}