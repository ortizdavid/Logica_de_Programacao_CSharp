internal class Program
{
    private static void Main(string[] args)
    {
        int v1, v2, v3;
        int menor, maior, meio;

        Console.Write("Valor 1: ");
        v1 = int.Parse(Console.ReadLine());
        Console.Write("Valor 2: ");
        v2 = int.Parse(Console.ReadLine());
        Console.Write("Valor 3: ");
        v3 = int.Parse(Console.ReadLine());

        if (v1 == v2 && v2 == v3)
        {
            Console.WriteLine("Os Valores são Iguais");
            return;
        }
        if (v1 < v2 && v2 < v3)
        {
            menor = v1;
            if (v2 < v3)
            {
                meio = v2;
                maior = v3;
            }
            else
            {
                meio = v3;
                maior = v2;
            }
        }
        else if (v2 < v1 && v2 < v3)
        {
            menor = v2;
            if (v1 < v3)
            {
                meio = v1;
                maior = v3;
            }
            else
            {
                meio = v3;
                maior = v1;
            }
        }
        else
        {
            menor = v3;
            if (v1 < v2)
            {
                meio = v1;
                maior = v2;
            }
            else
            {
                meio = v2;
                maior = v1;
            }
        }
        Console.WriteLine("Valores ordenados: {0}, {1}, {2}", menor, meio, maior);
    }
}