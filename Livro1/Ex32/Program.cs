internal class Program
{
    private static void Main(string[] args)
    {
        string nomeTime1, nomeTime2;
        int numGolos1, numGolos2;
        string mensagem="";

        Console.Write("Nome do Time 1: ");
        nomeTime1 = Console.ReadLine();
        Console.Write("Nº de Golos Time 1: ");
        numGolos1 = int.Parse(Console.ReadLine());
        Console.Write("Nome do Time 2: ");
        nomeTime2 = Console.ReadLine();
        Console.Write("Nº de Golos Time 2: ");
        numGolos2 = int.Parse(Console.ReadLine());

        if ((numGolos1 > numGolos2))
        {
            mensagem = "Vencedor: "+ nomeTime1;
        }
        else if ((numGolos2 > numGolos1))
        {
            mensagem = "Vencedor: "+ nomeTime2;
        }
        else
        {
            mensagem = "Empate";
        }
        Console.WriteLine("\n{0}", mensagem);
    }
}