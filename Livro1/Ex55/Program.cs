internal class Program
{
    private static void Main(string[] args)
    {
        int res;
        for (int i = 1; i < 8; i++)
        {
            res = 8 * i;
            Console.WriteLine("8 x {0} = {1}", i, res);
        }
    }
}