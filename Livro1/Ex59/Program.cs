internal class Program
{
    private static void Main(string[] args)
    {
        int valor
        int cont=0, qtdNum=10;

        while (qtdNum > 0)
        {
            qtdNum--;
            Console.Write("Valor: ");
            valor = int.Parse(Console.ReadLine());
            if (valor < 0)
            {
                cont++;
            }
            
        }
        
        Console.WriteLine("\nValores negativos: {0}", cont);
    }
}