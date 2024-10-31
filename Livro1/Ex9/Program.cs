internal class Program
{
    private static void Main(string[] args)
    {
        float salario, percentReajuste;
        float novoSalario, salarioReajuste, percentReal;

        Console.Write("Salário Actual: ");
        salario = float.Parse(Console.ReadLine());
        Console.Write("Percentual de Reajuste: ");
        percentReajuste = float.Parse(Console.ReadLine());

        if (percentReajuste <= 0 || percentReajuste > 100)
        {
            Console.WriteLine("Percentagem de reajuste inválida! deve estar [0 a 100]");
        }
        
        percentReal = percentReajuste / 100;
        salarioReajuste = (salario * percentReal);
        novoSalario = salario + salarioReajuste;
        Console.WriteLine("Reajuste de {0}%: {1:C}", percentReajuste, salarioReajuste);
        Console.WriteLine("Novo salário: {0:C}", novoSalario);
    }
}