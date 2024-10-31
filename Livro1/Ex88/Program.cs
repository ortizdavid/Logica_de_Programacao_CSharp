internal class Program
{
    private static void Main(string[] args)
    {
        int []vect = new int[20];
        int numero;
        bool achou = false;

        for (int i = 0; i < vect.Length; i++)
        {
            Console.Write("{0}º Elemento: ", (i+1));
            vect[i] = int.Parse(Console.ReadLine());
        }

        Console.Write("Numero a procurar: ");
        numero = int.Parse(Console.ReadLine());

        int novoTam = vect.Length;
        for (int i = 0; i < vect.Length; i++)
        {
            if (numero == vect[i])
            {
                achou = true;
                novoTam--;
                break;
            }
        }

        
        if (achou)
        {
            int []novoVect = new int[novoTam];
            int j = 0;
            for (int i = 0; i < vect.Length; i++)
            {
                if (vect[i] != numero)
                {
                    novoVect[j] = vect[i];
                    j++;
                }
            }

            Console.WriteLine("\nNovo vetor sem o número {0}:", numero);
            for (int i = 0; i < novoVect.Length; i++)
            {
                Console.Write("{0} ", novoVect[i]);
            }
        }
        else
        {
            Console.WriteLine("O número {0} não foi encontrado no vector", numero);
        }

    }
}