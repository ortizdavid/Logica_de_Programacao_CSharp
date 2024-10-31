internal class Program
{
    private static void Main(string[] args)
    {
        int valor;
        int maior=0, menor=0;

        for (int i = 1; i <= 100 ; i++)
        {
            Console.Write("{0}º Valor: ", i);
            valor = int.Parse(Console.ReadLine());

            if (valor < menor)
            {
                menor = valor;
            } 
          
            if (valor > maior)
            {
                maior = valor;
            } 
        }

        Console.WriteLine("\nMaior: {0}", maior);
        Console.WriteLine("Menor: {0}", menor);
    }
}