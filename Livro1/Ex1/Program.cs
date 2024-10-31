internal class Program
{
    private static void Main(string[] args)
    {
        int a = 10;
        int b = 20;
        Console.WriteLine("Antes da troca:\nA: {0}\nB: {1}", a, b);

        int tmp;
        tmp = a;
        a = b;
        b = tmp;
        /*(a, b) = (b, a);*/
        Console.WriteLine("Depois da troca:\nA: {0}\nB: {1}", a, b);
        
    }
}