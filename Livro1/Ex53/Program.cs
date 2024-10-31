internal class Program
{
    private static void Main(string[] args)
    {
        int N;

        Console.Write("N: ");
        N = int.Parse(Console.ReadLine());

        if (N <= 0)
        {
            Console.WriteLine("N deve ser maior que 0");
            return;
        }

        for (int i = 1; i <= N; i++)
        {
            Console.WriteLine("{0}", i);
        }
    }
}