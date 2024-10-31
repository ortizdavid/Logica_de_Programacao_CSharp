internal class Program
{
    private static void Main(string[] args)
    {
        string nome;
        int quantidade;
        double preco;
        double totalPagar, total, desconto=0;

        Console.Write("Descrição do produto(nome): ");
        nome = Console.ReadLine();
        Console.Write("Quantidade adquirida: ");
        quantidade = int.Parse(Console.ReadLine());
        Console.Write("Preço unitário: ");
        preco = double.Parse(Console.ReadLine());

        total = quantidade * preco;
        if (quantidade <= 5)
        {
            desconto = 0.02 * total;
        }
        else if(quantidade > 5 && quantidade <= 10)
        {
            desconto = 0.03 * total;
        }
        else
        {
            desconto = 0.05 * total;
        }

        totalPagar = total - desconto;
        Console.WriteLine("\nTotal: {0:C}", total);
        Console.WriteLine("Desconto: {0:C}", desconto);
        Console.WriteLine("Total a Pagar: {0:C}", totalPagar);
    }
}