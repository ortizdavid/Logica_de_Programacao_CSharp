internal class Program
{
    private static void Main(string[] args)
    {
        int numAlunos;
        double nota, soma=0, media;

        Console.Write("Numero de Alunos: ");
        numAlunos = int.Parse(Console.ReadLine());

        for (int i=1; i<=numAlunos; i++)
        {
            Console.Write("Nota do {0}º aluno: ", i);
            nota = double.Parse(Console.ReadLine());
            soma += nota;
        }

        media = soma / numAlunos;
        Console.WriteLine("\nSoma: {0}", soma);
        Console.WriteLine("Media: {0}", media);

    }
}