internal class Program
{
    private static void Main(string[] args)
    {
        int anoActual, anoNascimento;
        int idade;

        Console.Write("Ano actual: ");
        anoActual = int.Parse(Console.ReadLine());
        Console.Write("Ano de nascimento: ");
        anoNascimento = int.Parse(Console.ReadLine());

        idade = anoActual - anoNascimento;
        Console.WriteLine("Idade: {0} anos", idade);
        
        if (idade >= 18)
        {
            Console.WriteLine("Pode Votar");
        }
        else
        {
            Console.WriteLine("Não  pode votar");
        }
    }
}