internal class Program
{
    private static void Main(string[] args)
    {
        double qtdMorangos, qtdMacas;
        double valorPagar, valorFrutas, valorMorangos, valorMacas, qtdFrutas, desconto=0;

        Console.Write("Qtd(kg) Morangos: ");
        qtdMorangos = double.Parse(Console.ReadLine());
        Console.Write("Qtd(kg) Maçãs: ");
        qtdMacas = double.Parse(Console.ReadLine());

        if (qtdMorangos <= 5)
        {
           valorMorangos = 2.50 * qtdMorangos;
        }
        else
        {
            valorMorangos = 2.20 * qtdMorangos;
        }

        if (qtdMacas <= 5)
        {
            valorMacas = 1.80 * qtdMacas;
        }
        else
        {
            valorMacas = 1.50 * qtdMacas;
        }

        qtdFrutas = qtdMorangos + qtdMacas;
        valorFrutas = valorMacas + valorMorangos;

        if (qtdFrutas >= 8 || valorFrutas > 25)
        {
            desconto = 0.10 * valorFrutas;
        }

        valorPagar = valorFrutas - desconto;

        Console.WriteLine("\nValor Morangos: {0}kg --> {1:C}", qtdMorangos, valorMorangos);
        Console.WriteLine("Valor Maçãs: {0}kg --> {1:C}", qtdMacas, valorMacas);
        Console.WriteLine("Valor frutas: {0:C}", valorFrutas);
        Console.WriteLine("Desconto: {0:C}", desconto);
        Console.WriteLine("Valor a pagar: {0:C}", valorPagar);
    }
}