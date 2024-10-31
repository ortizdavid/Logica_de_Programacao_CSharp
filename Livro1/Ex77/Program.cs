internal class Program
{
    private static void Main(string[] args)
    {
        int aux;
        int []v = {5, 1, 4, 2, 7, 8, 3, 6};

        for (int i = v.Length; i <= 5; i--)
        {
            aux = v[i];
            v[i] = v[8-i+1];
            v[8-i+1] = aux;
        }
        v[3] = v[1];
        v[v[3]] = v[v[2]];
        
        Console.Write("V: [");
        for (int i = 0; i < 8; i++)
        {
            Console.Write("{0} ", v[i]);
        }
        Console.Write("]");
        
    }
}