internal class Program
{
    private static void Main(string[] args)
    {
        float salario, valorVenda;
        float comissao, salarioTotal;

        Console.Write("Salário Fixo: ");
        salario = float.Parse(Console.ReadLine());
        Console.Write("Valor da Venda: ");
        valorVenda = float.Parse(Console.ReadLine());

        if (valorVenda > 1500)
        {
           comissao = 0.05f * valorVenda; 
        }
        else 
        {
            comissao = 0.03f * valorVenda;
        }
        salarioTotal = salario + comissao;
        
        Console.WriteLine("\nComissão sobre as vendas: {0:C}", comissao);
        Console.WriteLine("Salário total: {0:C}", salarioTotal);
    }
}