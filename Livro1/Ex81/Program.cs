internal class Program
{
    private static void Main(string[] args)
    {
        int []Q = new int[20];
        int menor, pos=0;
       
        for (int i = 0; i < Q.Length; i++)
        {
            Console.Write("{0}º Elemento: ", (i+1));
            Q[i] = int.Parse(Console.ReadLine());

            if (Q[i] < 0)
            {
                Console.WriteLine("Apenas numeros positivos");
                return;
            }
        }

        menor = Q[0];
        for (int i = 0; i < Q.Length; i++)
        {
            if (menor > Q[i])
            {
                menor = Q[i];
                pos = i;
            }
        }

        Console.WriteLine("\nMenor elemento: {0}", menor);
        Console.WriteLine("Posicao: {0}", (pos+1));
    }
}