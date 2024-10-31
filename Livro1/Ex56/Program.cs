internal class Program
{
    private static void Main(string[] args)
    {
        int N;
        int res;

        Console.Write("Numero: ");
        N = int.Parse(Console.ReadLine());

        if (N<1 || N>10)
        {
            Console.WriteLine("N deve estar no intervalo [1-10]");
            return;
        }

        for (int i = 1; i <= 10; i++)
        {
            res = N * i;
            Console.WriteLine("{0} x {1} = {2}", N, i, res);
        }
    }
}