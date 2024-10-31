internal class Program
{
    private static void Main(string[] args)
    {
        int []vect = new int[30];
        int numero, cont=0;

        for (int i = 0; i < vect.Length; i++)
        {
            Console.Write("{0}º Elemento: ", (i+1));
            vect[i] = int.Parse(Console.ReadLine());
        }

        Console.Write("Número a procurar: ");
        numero = int.Parse(Console.ReadLine());

        for (int i = 0; i < vect.Length; i++)
        {
            if (numero == vect[i])
            {
                cont++;
            }
        }

        Console.WriteLine("\nO número {0} aparece {1} vezes no vector", numero, cont);
    }
}