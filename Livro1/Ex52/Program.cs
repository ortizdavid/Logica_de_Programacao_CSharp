internal class Program
{
    private static void Main(string[] args)
    {
        int count = 0;
        for (int i = 101; ; i++)
        {
            Console.WriteLine("{0}", i);
            count++;
            if (count == 10)
            {
                break;
            }
        }
    }
}