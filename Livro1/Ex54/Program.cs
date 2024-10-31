internal class Program
{
    private static void Main(string[] args)
    {
        int N;

        do
        {
            Console.Write("N: ");
            N = int.Parse(Console.ReadLine());
        } while (N <= 0);
       
        for (int i = 0; i <= N; i++)
        {
            Console.WriteLine("{0}", i);
        }
    }
}