internal class Program
{
    private static void Main(string[] args)
    {
        int anos, meses, dias;
        int idadeEmDias;

        Console.Write("Idade em anos: ");
        anos = int.Parse(Console.ReadLine());
        Console.Write("Meses: ");
        meses = int.Parse(Console.ReadLine());
        Console.Write("dias: ");
        dias = int.Parse(Console.ReadLine());

        idadeEmDias = (anos * 365) + (meses * 30) + dias;

        Console.WriteLine("Idade total em dias: {0}\n", idadeEmDias);
    }
}