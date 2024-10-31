internal class Program
{
    private static void Main(string[] args)
    {
        int N;
       
        Console.Write("Valor de N: ");
        N = int.Parse(Console.ReadLine());
        
        int []A = new int[N];
        int []B = new int[N];
        int []Soma = new int[N];

        Console.WriteLine("\nVector A");
        for (int i = 0; i < N ; i++)
        {
            Console.Write("{0}º Elemento: ", (i+1));
            A[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("\nVector B");
        for (int i = 0; i < N ; i++)
        {
            Console.Write("{0}º Elemento: ", (i+1));
            B[i] = int.Parse(Console.ReadLine());
        }

        for (int i = 0; i < N; i++)
        {
            Soma[i] = A[i] + B[i];
        }
        
        Console.WriteLine("\nSoma dos 2 vectores: ");
        for (int i = 0; i < N; i++)
        {
            Console.Write("{0} ", Soma[i]);
        }
    }
}