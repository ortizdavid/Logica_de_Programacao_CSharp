internal class Program
{
    private static void Main(string[] args)
    {
        int numero;

        Console.Write("Número: ");
        numero = int.Parse(Console.ReadLine());

        if (numero >= 0)
        {
            Console.WriteLine("Número positivo");
        }
        else
        {
            Console.WriteLine("Numero negativo");
        }
    }
}