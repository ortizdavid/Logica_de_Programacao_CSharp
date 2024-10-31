internal class Program
{
    private static void Main(string[] args)
    {
        double n1, n2;
        double media;
        char resp='S';

        while (resp == 'S')
        {
            do
            {
                Console.Write("\nNota 1: ");
                n1 = double.Parse(Console.ReadLine());
                Console.Write("Nota 2: ");
                n2 = double.Parse(Console.ReadLine());
                
            } while (!(n1>=0 && n1<=10) || !(n2>=0 && n2<=10));
        
            media = (n1 + n2) / 2;
            Console.WriteLine("Media: {0}", media);
            Console.Write("\nNovo cálculo (S/N)? ");
            resp = char.Parse(Console.ReadLine().ToUpper());
        }
    }
}