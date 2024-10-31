internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Valor: ");
        int valor = Int32.Parse(Console.ReadLine());
        Console.WriteLine("Antecessor: {0}", valor-1);
    }
}