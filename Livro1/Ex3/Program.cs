internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("A --> (4/2)+(2/4) = {0}", (4/2)+(4/2));
        Console.WriteLine("A --> 4/2+2/4 = {0}\n", 4/2+2/4);

        Console.WriteLine("B --> 4/(2+2)/4 = {0}", 4/(2+2)/4);
        Console.WriteLine("B --> 4/2+2/4 = {0}\n", 4/2+2/4);

        Console.WriteLine("C --> (4+2)*2-4 = {0}", (4+2)*2-4);
        Console.WriteLine("C --> 4+2*2-4 = {0}\n", 4+2*2-4);
    }
}