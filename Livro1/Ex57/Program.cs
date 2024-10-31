internal class Program
{
    private static void Main(string[] args)
    {
        int N, cont=1;
        int res;

        Console.Write("Numero: ");
        N = int.Parse(Console.ReadLine());

        if (N<1 || N>10)
        {
            Console.WriteLine("N deve estar no intervalo [1-10]");
            return;
        }

        do 
        {
            res = N * cont;
            Console.WriteLine("{0} x {1} = {2}", N, cont, res);
            cont++;
        } while (cont <= 10);
    }
}