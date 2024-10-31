internal class Program
{
    // Por fazer ainda não percebi a lógica
    private static void Main(string[] args)
    {
        int X, Y;
        int limX=60, limY=10;

        Console.Write("X (coluna): ");
        X = int.Parse(Console.ReadLine());
        Console.Write("Y (linha): ");
        Y = int.Parse(Console.ReadLine());

        for (int i = 1; i <= limX; i++)
        {
            Console.Write("+");
        }  

        Console.WriteLine();  

        for (int j = 1; j <= limY; j++)
        {
            Console.WriteLine("+");
        }  
        
        for (int i = 1; i <= limX; i++)
        {
            Console.Write("+");
        }  


    }

    static string Tabulacao(int num)
    {
        string strTab = "";
        for (int i = 0; i < num; i++)
        {
            strTab += "\t";
        }
        return strTab;
    }
}