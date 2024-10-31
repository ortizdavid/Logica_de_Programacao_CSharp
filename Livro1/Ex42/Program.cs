internal class Program
{
    private static void Main(string[] args)
    {
        int anoNascimento, anoIngresso, codigo, anoActual=2024;
        int idade, anosTrabalho;
        string mensagem;

        Console.Write("Cod. Funcionário: ");
        codigo = int.Parse(Console.ReadLine());
        Console.Write("Ano de Ingresso: ");
        anoIngresso = int.Parse(Console.ReadLine());
        Console.Write("Ano de Nascimento: ");
        anoNascimento = int.Parse(Console.ReadLine());

        idade = anoActual - anoNascimento;
        anosTrabalho = anoActual - anoIngresso;

        if (idade >= 60 || anosTrabalho >= 30 || (idade >= 60 && anosTrabalho >= 25))
        {
            mensagem = "Requer Aposentadoria";
        }
        else
        {
            mensagem = "Não requer aposentadoria";
        }

        Console.WriteLine("\nIdade: {0} anos", idade);
        Console.WriteLine("Anos de trabalho: {0} anos", anosTrabalho);
        Console.WriteLine("Situação: {0}", mensagem);

    }
}