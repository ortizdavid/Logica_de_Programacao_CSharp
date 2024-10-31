internal class Program
{
    private static void Main(string[] args)
    {
        int x, y, z;
        char resposta;

        Console.Write("X: ");
        x = int.Parse(Console.ReadLine());
        Console.Write("Y: ");
        y = int.Parse(Console.ReadLine());

        z = (x * y) + 5;

        if (z <= 0)
        {
            resposta = 'A';
        }
        else
        {
            if (z <= 100)
            {
                resposta = 'B';
            }
            else
            {
                resposta = 'C';
            }
        }
        Console.WriteLine("\nZ\tResposta", z, resposta);
        Console.WriteLine("{0}\t{1}", z, resposta);
    }
}