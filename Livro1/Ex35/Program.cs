internal class Program
{
    private static void Main(string[] args)
    {
        double litrosVendidos;
        char tipo;
        double totalPagar, totalSemDesconto, percentDesconto, desconto, preco;

        Console.Write("Nº de Litros Vendidos: ");
        litrosVendidos = double.Parse(Console.ReadLine());
        Console.Write("Tipo de Combustivel. A-álcool, G-gasolina: ");
        tipo = char.Parse(Console.ReadLine().ToUpper());

        if (tipo == 'A')
        {
            preco = 3.30;
            if (litrosVendidos <= 20)
            {
                percentDesconto =  0.03;
            }
            else
            {
                percentDesconto =  0.05;
            }
        }
        else if (tipo == 'G')
        {
            preco = 2.90;
            if (litrosVendidos <= 20)
            {
                percentDesconto =  0.04;
            }
            else
            {
                percentDesconto =  0.06;
            }
        }
        else
        {
            Console.WriteLine("Tipo de Combustivel Inválido");
            return;
        }

        totalSemDesconto = preco * litrosVendidos;
        desconto = (totalSemDesconto * percentDesconto);
        totalPagar = totalSemDesconto - desconto;

        Console.WriteLine("\nPreço do combustivel: {0:C}", preco);
        Console.WriteLine("Desconto aplicado: {0:C}", desconto);
        Console.WriteLine("Total sem Desconto: {0:C}", totalSemDesconto);
        Console.WriteLine("Total com Desconto: {0:C}", totalPagar);
    }
}