internal class Program
{
    private static void Main(string[] args)
    {
       int qtdCompradas;
       float custoTotal, preco;

       Console.Write("Quantidade compradas: ");
       qtdCompradas = int.Parse(Console.ReadLine());

       if (qtdCompradas < 12)
       {
            preco = 1.30f;
       }
       else
       {
            preco = 1.00f;
       }
       custoTotal = qtdCompradas * preco;

       Console.WriteLine("Preço unitário: {0:C}", preco);
       Console.WriteLine("Custo total: {0:C}", custoTotal);
    }
}