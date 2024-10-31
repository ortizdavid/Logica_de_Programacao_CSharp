internal class Program
{
    private static void Main(string[] args)
    {
        int valor1, valor2;
        int tmp;

        Console.Write("Valor 1: ");
        valor1 = int.Parse(Console.ReadLine());
        Console.Write("Valor 2: ");
        valor2 = int.Parse(Console.ReadLine());

        if (valor1 == valor2)
        {
            Console.WriteLine("Valores iguais");
        }
        else
        {
            if (valor1 > valor2)
            {
                Console.WriteLine("{0}, {1}", valor2, valor1);
            } 
            else
            {
                Console.WriteLine("{0}, {1}", valor1, valor2);
            }
        }
    }
}