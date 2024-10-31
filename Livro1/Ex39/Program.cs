internal class Program
{
    private static void Main(string[] args)
    {
        bool A = true, B = true, C = false;

        Console.WriteLine("(A e B) ou (A xou B) --> {0}", (A&&B) || (A^B));
        Console.WriteLine("(A ou B) e (A e C) --> {0}", (A||B) && (A&&B));
        Console.WriteLine("(A ou C) xou (A e C) --> {0}", (A||C) ^ (A&&!B));
    }
}