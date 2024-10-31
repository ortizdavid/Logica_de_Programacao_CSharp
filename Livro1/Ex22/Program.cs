internal class Program
{
    private static void Main(string[] args)
    {
        int horasSemanais, horasExtras, horasMensais;
        float salarioTotal, salarioHora, salarioHoraExtra, acresimo=0;

        Console.Write("Horas trabalhadas no mes: ");
        horasMensais = int.Parse(Console.ReadLine());
        Console.Write("Salário por Hora: ");
        salarioHora = float.Parse(Console.ReadLine());
        Console.Write("Horas extras feitas: ");
        horasExtras = int.Parse(Console.ReadLine());

        horasSemanais = horasMensais / 4;

        if (horasSemanais > 40)
        {
            acresimo = salarioHora + (0.5f *  salarioHora);
        }
        salarioHoraExtra = horasExtras * salarioHora;
        salarioTotal = acresimo + (salarioHora * horasMensais) + salarioHoraExtra;

        Console.WriteLine("\nHoras Semanais: {0}h", horasSemanais);
        Console.WriteLine("Acréscimo Horas Extras: {0:C}", acresimo);
        Console.WriteLine("Salário por Horas Extras: {0:C}", salarioHoraExtra);
        Console.WriteLine("Salário Total: {0:C}", salarioTotal);
    }
}