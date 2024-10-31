internal class Program
{
    private static void Main(string[] args)
    {
        double []notas = new double[20];
        double media, soma=0;
        int contagem=0;

        for (int i = 0; i < notas.Length; i++)
        {
            Console.Write("Nota do {0}º aluno: ", (i+1));
            notas[i] = double.Parse(Console.ReadLine());

            soma += notas[i];
        }

        media = soma / notas.Length;

        for (int i = 0; i < notas.Length; i++)
        {
            if (notas[i] > media)
            {
                contagem++;
            }
        }

        Console.WriteLine("\nMédia das notas: {0}", media);
        Console.WriteLine("Alunos acima da média: {0}", contagem);
    }
}