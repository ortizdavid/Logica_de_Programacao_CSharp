internal class Program
{
    private static void Main(string[] args)
    {
        int valor;
        int qtdNum=10, contDentro=0, contFora=0;

        while (qtdNum > 0)
        {
            qtdNum--;
            Console.Write("Valor: ");
            valor = int.Parse(Console.ReadLine());

            if (valor>=10 && valor<=20)
            {
                contDentro++;
            }
            else
            {
                contFora++;
            }
        }
        
        Console.WriteLine("\nValores dentro do intervalo [10,20]: {0}", contDentro);
        Console.WriteLine("Valores fora do intervalo [10,20]: {0}", contFora);
    }
}