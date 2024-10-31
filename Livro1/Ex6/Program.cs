internal class Program
{
    private static void Main(string[] args)
    {
        float b, h, area;
        Console.Write("Base: ");
        b = float.Parse(Console.ReadLine());
        Console.Write("Altura: ");
        h = float.Parse(Console.ReadLine());
        area = (b * h) * 2;
        Console.WriteLine("Area: {0} u2", area);
    }
}