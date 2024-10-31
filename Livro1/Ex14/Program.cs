internal class Program
{
    private static void Main(string[] args)
    {
        int valor;

        Console.Write("Valor: ");
        valor = int.Parse(Console.ReadLine());

        if (valor > 10)
        {
            Console.WriteLine("É MAIOR QUE 10");
        }
        else
        {
            Console.WriteLine("NÃO É MAIOR QUE 10");
        }
    }
}