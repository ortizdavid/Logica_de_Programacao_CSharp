internal class Program
{
    private static void Main(string[] args)
    {
        int v1, v2, v3;
        int maior1=0, maior2=0, somaMaior;

        Console.Write("Valor 1: ");
        v1 = int.Parse(Console.ReadLine());
        Console.Write("Valor 2: ");
        v2 = int.Parse(Console.ReadLine());
        Console.Write("Valor 2: ");
        v3 = int.Parse(Console.ReadLine());

        if (v1 == v2 && v2 == v3)
        {
            Console.WriteLine("Valores Iguais");
            return;
        }
      
        if (v1 > v2 && v2 > v3)
        {
            maior1 = v1;
            if (v2 > v3)
            {
                maior2 = v2;
            }
            else
            {
                maior2 = v3;
            }
            
        }
        else if (v2 > v1 && v2 > v3)
        {
            maior1 = v2;
            if (v1 > v3)
            {
                maior2 = v1;
            }
            else
            {
                maior2 = v3;
            }
        }
        else
        {
            maior1 = v3;
            if (v1 > v2)
            {
                maior2 = v1;
            }
            else
            {
                maior2 = v2;
            }
        }
        somaMaior = maior1 + maior2;
        Console.WriteLine("\nMaior 1: {0}\nMaior 2: {1}", maior1, maior2);
        Console.WriteLine("Soma dos maiores: {0}", somaMaior);
    }
    
}