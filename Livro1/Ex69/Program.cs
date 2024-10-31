internal class Program
{
    private static void Main(string[] args)
    {
        int cont=0;
        double valorMercadoria;
        double valorTotalEstoque=0, mediaValor;
        char resp;

        do
        {
            cont++;
            Console.Write("Valor da {0}ª mercadoria: ", cont);
            valorMercadoria = double.Parse(Console.ReadLine());
            valorTotalEstoque += valorMercadoria;

            Console.Write("Mais mercadorias (S/N)? ");
            resp = char.Parse(Console.ReadLine().ToUpper());
            
        } while (resp == 'S');
        
        mediaValor = valorTotalEstoque / cont;

        Console.WriteLine("\nValor total do estoque: {0:C}", valorTotalEstoque);
        Console.WriteLine("Média do total: {0:C}", mediaValor);
    }
}