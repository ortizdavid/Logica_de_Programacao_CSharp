internal class Program
{
    private static void Main(string[] args)
    {
        int valor1, valor2;
        int soma=0;

        Console.Write("Valor 1: ");
        valor1 = int.Parse(Console.ReadLine());
        Console.Write("Valor 2: ");
        valor2 = int.Parse(Console.ReadLine());

        if (!((valor2 > valor1) || (valor2 < valor1))) //ou: valor2==valor1
        {
            Console.WriteLine("Segundo valor deve ser maior ou menor que o primeiro");
            return;
        }

        for (int i = valor1; i <= valor2; i++)
        {
            soma += i;
        }

        Console.WriteLine("\nSoma: {0}", soma);
    }
}