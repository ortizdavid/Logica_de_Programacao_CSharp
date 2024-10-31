internal class Program
{
    private static void Main(string[] args)
    {
        int quantidade=5;
        double preco;
        double maiorPreco=0, soma=0, media;

        for (int i = 1; i <= quantidade; i++)
        {
            Console.Write("Preço do {0}º produto: ", i);
            preco = double.Parse(Console.ReadLine());
            soma += preco;

            if (preco > maiorPreco)
            {
                maiorPreco = preco;
            }
        }

        media = soma / quantidade;
        Console.WriteLine("\nMaior preço: {0:C}", maiorPreco);
        Console.WriteLine("Média dos preços: {0:C}", media);
    }
}