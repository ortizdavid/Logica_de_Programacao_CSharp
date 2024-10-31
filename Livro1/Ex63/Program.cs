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
            soma += numero;
        }

        Console.WriteLine("Soma: {0}", soma);
    }
}