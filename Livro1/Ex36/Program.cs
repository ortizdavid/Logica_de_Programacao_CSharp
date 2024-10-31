internal class Program
{
    private static void Main(string[] args)
    {
        int idadeH1, idadeH2;
        int idadeM1, idadeM2;
        int homemMaisVelho, homemMaisNovo, mulherMaisVelha, mulherMaisNova;
        int somaIdades, produtoIdades;

        Console.Write("Idade do 1º Homem: ");
        idadeH1 = int.Parse(Console.ReadLine());
        Console.Write("Idade do 2º Homem: ");
        idadeH2 = int.Parse(Console.ReadLine());

        Console.Write("Idade da 1ª Mulher: ");
        idadeM1 = int.Parse(Console.ReadLine());
        Console.Write("Idade da 2ª Mulher: ");
        idadeM2 = int.Parse(Console.ReadLine());

        if (idadeH1 > idadeH2)
        {
            homemMaisVelho = idadeH1;
            homemMaisNovo = idadeH2;
        } 
        else
        {
            homemMaisVelho = idadeH2;
            homemMaisNovo = idadeH1;
        }

        if (idadeM1 > idadeM2)
        {
            mulherMaisVelha = idadeM1;
            mulherMaisNova = idadeM2;
        } 
        else
        {
            mulherMaisVelha = idadeH2;
            mulherMaisNova = idadeM1;
        }

        somaIdades = homemMaisVelho + mulherMaisNova;
        produtoIdades = mulherMaisVelha * homemMaisNovo;

        Console.WriteLine("\nHomem mais velho: {0} anos", homemMaisVelho);
        Console.WriteLine("Homem mais novo: {0} anos", homemMaisNovo);
        Console.WriteLine("Mulher mais velha: {0} anos", mulherMaisVelha);
        Console.WriteLine("Mulher mais nova: {0} anos", mulherMaisNova);

        Console.WriteLine("\nHomem mais velho + Mulher mais nova: {0}", somaIdades);
        Console.WriteLine("Mulher mais velha x Homem mais novo: {0}", produtoIdades);
    }
}