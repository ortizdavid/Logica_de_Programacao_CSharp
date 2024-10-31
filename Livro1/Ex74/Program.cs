internal class Program
{
    private static void Main(string[] args)
    {
        int numero, resultado;
        
        Console.WriteLine("Tabuada de 1 a 10");
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine("Número: {0}:", i);
            for (int j = 1; j <= 10; j++)
            {
                resultado = i * j;
                Console.WriteLine("{0} x {1} = {2}", i, j, resultado);
            }
            Console.WriteLine("-------------\n");
        }
    }
}