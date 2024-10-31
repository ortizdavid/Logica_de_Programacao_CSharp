internal class Program
{
    private static void Main(string[] args)
    {
        int qtdNum=10, soma=0;
        int valor;
        double media;

        while (qtdNum > 0)
        {
            qtdNum--;
            Console.Write("Valor: ");
            valor = int.Parse(Console.ReadLine());
            soma += valor;
        }
        media = soma / 10;
        
        Console.WriteLine("\nSoma: {0}", soma);
        Console.WriteLine("Media: {0}", media);
    }
}