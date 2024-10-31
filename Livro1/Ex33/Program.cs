internal class Program
{
    private static void Main(string[] args)
    {
        int v1, v2;

        Console.Write("Valor 1: ");
        v1 = int.Parse(Console.ReadLine());
        Console.Write("Valor 2: ");
        v2 = int.Parse(Console.ReadLine());

        if (v1 == v2)
        {
            Console.WriteLine("Números Iguais");
        }
        else if (v1 > v2)
        {
            Console.WriteLine("Primeiro é maior");
        }
        else
        {
            Console.WriteLine("Segundo é maior");
        }
    }
}