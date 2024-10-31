internal class Program
{
    private static void Main(string[] args)
    {
        int []A = new int[10];
        int []M = new int[10];
        int X;

        for (int i = 0; i < A.Length; i++)
        {
            Console.Write("{0}º Elemento: ", (i+1));
            A[i] = int.Parse(Console.ReadLine());
        }

        Console.Write("Valor de X: ");
        X = int.Parse(Console.ReadLine());

        for (int i = 0; i < A.Length; i++)
        {
            M[i] = A[i] * X;
        }

        Console.WriteLine("\nNovo vector M -> (A[i] * X): ");
        for (int i = 0; i < A.Length; i++)
        {
            Console.Write("{0} ", M[i]);
        }
    }
}