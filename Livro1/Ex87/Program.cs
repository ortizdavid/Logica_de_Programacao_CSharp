internal class Program
{
    private static void Main(string[] args)
    {
        int []vect = new int[10];
        int aux, numero;

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

        Console.Write("Novo elemento: ");
        numero = int.Parse(Console.ReadLine());

        //-- Novo vector
        int []novoVect = new int[vect.Length + 1];

        int k = 0;
        bool inserido = false;

        for (int i = 0; i < vect.Length; i++)
        {
            if (!inserido && numero < vect[i])
            {
                novoVect[k++] = numero;
                inserido = true;
            }
            novoVect[k++] = vect[i];
        }

        if (!inserido)
        {
            novoVect[k] = numero;
        }

        Console.WriteLine("Vector Ordenado: ");
        for (int i = 0; i < novoVect.Length; i++)
        {
            Console.Write("{0} ", novoVect[i]);
        }
    }

}