internal class Program
{
    private static void Main(string[] args)
    {
        int valor1, valor2;
        int maior=0;

        Console.Write("Valor 1: ");
        valor1 = int.Parse(Console.ReadLine());
        Console.Write("Valor 2: ");
        valor2 = int.Parse(Console.ReadLine());

        if (valor1 == valor2)
        {
            Console.WriteLine("Números iguais. ");
        }   
        else
        {
            if (valor1 > valor2)
            {
                maior = valor1;
            }
            else
            {
                maior = valor2;
            }
            Console.WriteLine("Maior: {0}", maior);
        }
        
    }
}