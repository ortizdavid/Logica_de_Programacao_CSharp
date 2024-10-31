internal class Program
{
    private static void Main(string[] args)
    {
        int A, B, C;
        int somaA, somaB, somaC;
        string mensagem="";

        Console.Write("A: ");
        A = int.Parse(Console.ReadLine());
        Console.Write("B: ");
        B = int.Parse(Console.ReadLine());
        Console.Write("C: ");
        C = int.Parse(Console.ReadLine());

        somaA = B + C;
        somaB =  A + C;
        somaC = A + B;

        if (A<somaA && B<somaB && C<somaC)
        {
            mensagem = "É um triângulo";
        }
        else
        {
            mensagem = "Não é um triângulo";
        }

        Console.WriteLine("\nSoma dos Lados\nLado A: {0}\nLado B: {1}\nLado C: {2}", somaA, somaB, somaC);
        Console.WriteLine("Resultado: {0}", mensagem);
    }
}