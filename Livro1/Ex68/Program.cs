internal class Program
{
    private static void Main(string[] args)
    {
        int totalMercadorias;
        double valorMercadoria;
        double valorTotalEstoque=0, mediaValor;

        Console.Write("Total de mercadorias no estoque: ");
        totalMercadorias = int.Parse(Console.ReadLine());

        for (int i = 1; i <= totalMercadorias; i++)
        {
            Console.Write("Valor da {0}ª mercadoria: ", i);
            valorMercadoria = double.Parse(Console.ReadLine());

            valorTotalEstoque += valorMercadoria;
        }
        mediaValor = valorTotalEstoque / totalMercadorias;

        Console.WriteLine("\nValor total do estoque: {0:C}", valorTotalEstoque);
        Console.WriteLine("Média do total: {0:C}", mediaValor);
    }
}