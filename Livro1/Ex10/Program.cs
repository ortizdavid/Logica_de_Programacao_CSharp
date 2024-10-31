internal class Program
{
    private static void Main(string[] args)
    {
        float custoFabrica, percentDist, impostos;
        float custoFinal, custoPercentDist, custoImposto;

        Console.Write("Custo de Fábrica: ");
        custoFabrica = float.Parse(Console.ReadLine());
        Console.Write("Percentual de Distribuidor (%): ");
        percentDist = float.Parse(Console.ReadLine());
        Console.Write("Impostos (%): ");
        impostos = float.Parse(Console.ReadLine());

        custoPercentDist = custoFabrica * (percentDist/100);
        custoImposto = custoFabrica * (impostos/100);
        custoFinal = custoFabrica + custoPercentDist + custoImposto;

        Console.WriteLine("Percentagem do Distribuidor: {0:C}", custoPercentDist);
        Console.WriteLine("Imposto: {0:C}", custoImposto);
        Console.WriteLine("Custo final do Carro: {0:C}", custoFinal);
    }
}