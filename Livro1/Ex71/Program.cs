internal class Program
{
    private static void Main(string[] args)
    {
        int quantidade, numero;
        int soma=0, maior=0;
        double media;

        Console.Write("Quantidade de números: ");
        quantidade = int.Parse(Console.ReadLine());

        for (int i = 1; i <= quantidade; i++)
        {
            Console.Write("{0}º Número: ", i);
            numero = int.Parse(Console.ReadLine());
            soma += numero;

            if (numero > maior)
            {
                maior = numero;
            }
        }

        media = soma / quantidade;
        
        Console.WriteLine("\nMaior: {0}", maior);
        Console.WriteLine("Soma: {0}", soma);
        Console.WriteLine("Media: {0}", media);
    }
}