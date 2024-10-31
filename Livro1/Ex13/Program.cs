internal class Program
{
    private static void Main(string[] args)
    {
        float n1, n2, n3;
        float mediaFinal;

        Console.Write("Nota 1: ");
        n1 = float.Parse(Console.ReadLine());
        Console.Write("Nota 2: ");
        n2 = float.Parse(Console.ReadLine());
        Console.Write("Nota 3: ");
        n3 = float.Parse(Console.ReadLine());

        mediaFinal = (n1*2 + n2*3 + n3 * 5) / 10;
        Console.WriteLine("Média Final: {0}", mediaFinal);
    }
}