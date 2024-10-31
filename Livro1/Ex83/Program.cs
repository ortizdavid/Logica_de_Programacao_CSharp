internal class Program
{
    private static void Main(string[] args)
    {
        int []vect = new int[5];
        
        for (int i = 0; i < vect.Length; i++)
        {
            Console.Write("{0}º Elemento: ", (i+1));
            vect[i] = int.Parse(Console.ReadLine());
        }

        for (int i = 0; i < vect.Length / 2; i++)
        {
            int aux = vect[i];
            vect[i] = vect[vect.Length - 1 - i];  
            vect[vect.Length - 1 - i] = aux;
        }

        Console.WriteLine("\nVector na ordem Inversa: ");
        for (int i = 0; i < vect.Length; i++)
        {
            Console.Write("{0} ", vect[i]);
        }
    }
}