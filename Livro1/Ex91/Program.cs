internal class Program
{
    private static void Main(string[] args)
    {
        int []VET = new int[10];
        int pos, repetido;

        for (int i = 0; i < VET.Length; i++)
        {
            Console.Write("{0}º Elemento: ", (i+1));
            VET[i] = int.Parse(Console.ReadLine());
        }

        repetido = VET[0];
        for (int i = 0; i < VET.Length - 1; i++)
        {
            for (int j = i + 1; j < VET.Length; j++)
            {
                if (VET[i] == VET[j])    
                {
                    Console.WriteLine("Número {0} nas posições {1} e {2}", VET[i], i, j);
                }
            }
        }
    }
}