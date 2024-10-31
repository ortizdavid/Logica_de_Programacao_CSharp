internal class Program
{
    private static void Main(string[] args)
    {
        double v1, v2;
        double divisao;

        Console.Write("Valor 1: ");
        v1 = double.Parse(Console.ReadLine());

        do
        {
            Console.Write("Valor 2: ");
            v2 = double.Parse(Console.ReadLine());
        } while (v2 == 0);

        divisao = v1 / v2;
        Console.WriteLine("\nDivisao: {0}", divisao);
    }
}