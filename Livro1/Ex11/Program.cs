internal class Program
{
    private static void Main(string[] args)
    {
        int numCarros;
        float valorTotalVendas, salarioFixo, comissao;
        float comissaoVendas, valorPorCarro, salarioFinal;

        Console.Write("Nº de Carros Vendidos: ");
        numCarros = int.Parse(Console.ReadLine());  
        Console.Write("Valor total das vendas: ");
        valorTotalVendas = float.Parse(Console.ReadLine());  
        Console.Write("Salário fixo: ");
        salarioFixo = float.Parse(Console.ReadLine()); 
        Console.Write("Comissão por carros vendidos: ");
        comissao = float.Parse(Console.ReadLine());  

        valorPorCarro = comissao * numCarros;
        comissaoVendas = valorTotalVendas * 0.5f;
        salarioFinal = salarioFixo + valorPorCarro + comissaoVendas;

        Console.WriteLine("\nComissão por carros: {0:C}", comissaoVendas);
        Console.WriteLine("Comissão sobre as vendas: {0:C}", valorPorCarro);
        Console.WriteLine("Salário Final: {0:C}", salarioFinal);

    }
}