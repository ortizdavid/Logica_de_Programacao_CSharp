internal class Program
{
    private static void Main(string[] args)
    {
        int totalEleitores;
        int votosBrancos, votosNulos, votosValidos;
        float percentBrancos, percentNulos, percentValidos, totalPercent;

        Console.Write("Total de Eleitores: ");
        totalEleitores = int.Parse(Console.ReadLine());
        Console.Write("Votos Válidos: ");
        votosValidos = int.Parse(Console.ReadLine());
        Console.Write("Votos brancos: ");
        votosBrancos = int.Parse(Console.ReadLine());
        Console.Write("Votos Nulos: ");
        votosNulos = int.Parse(Console.ReadLine());
     
        percentValidos = (votosValidos * 100) / totalEleitores;
        percentBrancos = (votosBrancos * 100) / totalEleitores;
        percentNulos = (votosNulos * 100) / totalEleitores;
        totalPercent = percentValidos + percentBrancos + percentNulos;

        if (totalPercent > 100) 
        {
            Console.WriteLine("\nVerifique a contagem. Percentagem total > 100%: {0}%", totalPercent);
        }
        else
        {
            Console.WriteLine("\nResultados das Eleições: %");
            Console.WriteLine("Votos Válidos: {0}%", percentValidos);
            Console.WriteLine("Votos Brancos: {0}%", percentBrancos);
            Console.WriteLine("Votos Nulos: {0}%", percentNulos);
        }
    }
}