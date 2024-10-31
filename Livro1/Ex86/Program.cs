internal class Program
{
    private static void Main(string[] args)
    {
        int []vect = new int[5];
        int aux;

        for (int i = 0; i < vect.Length; i++)
        {
            Console.Write("{0}º Elemento: ", (i+1));
            vect[i] = int.Parse(Console.ReadLine());
        }

        for (int i = 0; i < vect.Length-1; i++)
        {
            for (int j = vect.Length-1; j > i; j--) {
                if (vect[j] < vect[j-1])
                {
                    aux = vect[j-1];
                    vect[j-1] = vect[j];
                    vect[j] = aux;
                }
            }
        }

        Console.WriteLine("Vector Ordenado: ");
        for (int i = 0; i < vect.Length; i++)
        {
            Console.Write("{0} ", vect[i]);
        }
    }
}