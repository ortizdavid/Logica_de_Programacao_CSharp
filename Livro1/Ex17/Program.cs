internal class Program
{
    private static void Main(string[] args)
    {
        float n1, n2;
        float media;

        Console.Write("Nota da 1ª avaliacao: ");
        n1 = float.Parse(Console.ReadLine());
        Console.Write("Nota da 2ª avaliacao: ");
        n2 = float.Parse(Console.ReadLine());

        media = (n1 + n2) / 2;
        Console.WriteLine("Media atrimética: {0}" + media);
        if (media >= 6)
        {
            Console.WriteLine("Aluno aprovado");
        }
        else
        {
            Console.WriteLine("Aluno Reprovado");
        }
    }
}