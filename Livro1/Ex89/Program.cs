internal class Program
{
    private static void Main(string[] args)
    {
        int []V1 = new int[15];
        int []V2 = new int[15];
        int cont=0;

        Console.WriteLine("Vector V1");
        for (int i = 0; i < V1.Length; i++)
        {
            Console.Write("{0}º Elemento: ", (i+1));
            V1[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("\nVector V2");
        for (int i = 0; i < V1.Length; i++)
        {
            Console.Write("{0}º Elemento: ", (i+1));
            V2[i] = int.Parse(Console.ReadLine());
        }

        for (int i = 0; i < V1.Length; i++)
        {
            if (V1[i] == V2[i])
            {
                cont++;
            }
        }

        Console.WriteLine("\nV1 e V2 possuem mesmos numeros e nas mesmas posições {0} vezes", cont);
    }
}