internal class Program
{
    private static void Main(string[] args)
    {
        double N1, N2, N3;
        double mediaExercicios, mediaAproveitamento;
        char conceito;

        Console.Write("Nota 1: ");
        N1 = double.Parse(Console.ReadLine());
        Console.Write("Nota 2: ");
        N2 = double.Parse(Console.ReadLine());
        Console.Write("Nota 3: ");
        N3 = double.Parse(Console.ReadLine());
        Console.Write("Media dos Exercícios: ");
        mediaExercicios = double.Parse(Console.ReadLine());

        mediaAproveitamento = (N1 + N2 * 2 + N3 * 3 + mediaExercicios) / 7;
        
        if (mediaAproveitamento >= 9.0)
        {
            conceito = 'A';
        }
        else if (mediaAproveitamento >= 7.5 && mediaAproveitamento < 9.0)
        {
            conceito = 'B';
        }
        else if (mediaAproveitamento >= 6.0 && mediaAproveitamento < 7.5)
        {
            conceito = 'C';
        }
        else
        {
            conceito = 'D';
        }

        Console.WriteLine("Média de Aproveitamento: {0}", mediaAproveitamento);
        Console.WriteLine("Conceito: {0}", conceito);
    }
}