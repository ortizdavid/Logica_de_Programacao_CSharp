internal class Program
{
    private static void Main(string[] args)
    {
        int v1, v2, v3;
        int maior;

        Console.Write("Valor 1: ");
        v1 = int.Parse(Console.ReadLine());
        Console.Write("Valor 2: ");
        v2 = int.Parse(Console.ReadLine());
        Console.Write("Valor 2: ");
        v3 = int.Parse(Console.ReadLine());

        if (v1 == v2 && v2 == v3)
        {
            Console.WriteLine("Valores Iguais");
            return;
        }
        if (v1 > v2 && v1 > v3)
        {
            maior = v1;
        }
        else if (v2 > v1 && v2 > v3)
        {
            maior = v2;
        }
        else
        {
            maior = v3;
        }
        Console.WriteLine("\nMaior: {0}", maior);
        
    }
}