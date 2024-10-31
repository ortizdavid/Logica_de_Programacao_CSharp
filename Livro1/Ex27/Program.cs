internal class Program
{
    private static void Main(string[] args)
    {
        int valor;
        
        Console.Write("Valor: ");
        valor = int.Parse(Console.ReadLine());

        if (valor > 0)
        {
            Console.WriteLine("Valor positivo");
        }
        else if (valor < 0)
        {
            Console.WriteLine("Valor negativo");
        }
        else 
        {
            Console.WriteLine("Zero");
        } 
    }
}