internal class Program
{
    private static void Main(string[] args)
    {
        float qtdActual, qtdMinima, qtdMaxima;
        float qtdMedia;
        string mensagem="";

        Console.Write("Qtd. Estoque Actual: ");
        qtdActual = float.Parse(Console.ReadLine());
        Console.Write("Qtd. Estoque Minima: ");
        qtdMinima = float.Parse(Console.ReadLine());
        Console.Write("Qtd. Estoque Maxima: ");
        qtdMaxima = float.Parse(Console.ReadLine());

        qtdMedia = (qtdMaxima + qtdMinima) / 2;

        Console.WriteLine("\nQtd. Média: {0}", qtdMedia);
        if (qtdActual >= qtdMedia)
        {
            mensagem = "Não efectuar compra";
        } 
        else
        {
            mensagem = "Efectuar compra";
        }
        Console.WriteLine("{0}", mensagem);
    }
}