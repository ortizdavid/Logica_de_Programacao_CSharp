internal class Program
{
    private static void Main(string[] args)
    {
        int numero;
        int soma=0;
        
        for (int i = 1; i <= 10; i++)
        {
            Console.Write("{0}º Numero: ", i);
            numero = int.Parse(Console.ReadLine());

            if (numero < 40)
            {
                soma += numero;
            }
        }
        
        Console.WriteLine("\nSoma: {0}", soma);
    }
}