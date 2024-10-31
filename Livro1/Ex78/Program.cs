internal class Program
{
    private static void Main(string[] args)
    {
        string []vectorNomes = new string[10];
        string nome, mensagem="";

        for (int i = 0; i < vectorNomes.Length; i++)
        {
            Console.Write("Nome da {0}ª pessoa: ", (i+1));
            vectorNomes[i] = Console.ReadLine();
        }

        Console.Write("Pesquise o nome: ");
        nome = Console.ReadLine();

        for (int i = 0; i < vectorNomes.Length; i++)
        {
            if (nome == vectorNomes[i])
            {
                mensagem = "ACHEI";
                break;
            }
            else
            {
                mensagem = "NÃO ACHEI";
            }
        }

        Console.WriteLine("\n{0} o nome '{1}'", mensagem, nome);
    }
}