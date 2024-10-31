internal class Program
{
    private static void Main(string[] args)
    {
        int inicio=15, fim=100;
        double media, soma=0;

        for (int i = inicio; i <= fim; i++)
        {
            soma += i;
        }
        media = soma / (fim-inicio);

        Console.WriteLine("\nSoma: {0}", soma);
        Console.WriteLine("Media: {0}", media);
    }
}