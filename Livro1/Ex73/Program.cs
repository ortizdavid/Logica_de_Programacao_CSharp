internal class Program
{
    private static void Main(string[] args)
    {
        int numHabitantes, numFilhos;
        int totalNumFilhos=0, contMenorSalario=0;
        double salario;
        double totalSalario=0, maiorSalario=0, mediaSalario, mediaFilhos, percentMenorSalario;

        Console.Write("Numero de Habitantes: ");
        numHabitantes = int.Parse(Console.ReadLine());

        for (int i = 1; i <= numHabitantes; i++)
        {
            Console.Write("Salário do {0}º habitante: ", i);
            salario = double.Parse(Console.ReadLine());
            Console.Write("Numero de Filhos: ");
            numFilhos = int.Parse(Console.ReadLine());

            totalSalario += salario;
            totalNumFilhos += numFilhos;

            if (salario < 150)
            {
                contMenorSalario++;
            }

            if (salario > maiorSalario)
            {
                maiorSalario = salario;
            }

            if (salario < 0)
            {
                Console.WriteLine("Salário negativo não é permitido");
                return;
            }
        }

        mediaSalario = totalSalario / numHabitantes;
        mediaFilhos = totalNumFilhos / numHabitantes;
        percentMenorSalario =  (contMenorSalario * 100) / numHabitantes;

        Console.WriteLine("\na) Média do salário da população: {0:C}", mediaSalario);
        Console.WriteLine("b) Média do numero de filhos: {0}", mediaFilhos);
        Console.WriteLine("c) Maior salário: {0:C}", maiorSalario);
        Console.WriteLine("d) Percentual de pessoas com salários menor que $150,00: {0}%", percentMenorSalario);
    }
}