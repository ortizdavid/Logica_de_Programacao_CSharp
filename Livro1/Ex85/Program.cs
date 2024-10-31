internal class Program
{
    private static void Main(string[] args)
    {
        double []temperaturas = new double[365];
        double maiorTemp, menorTemp, mediaTemp, somaTemp=0, contInferior=0;

        Console.WriteLine("Temperaturas de todos os dias do Ano");
        for (int i = 0; i < temperaturas.Length; i++)
        {
            Console.Write("{0}º dia: ", (i+1));
            temperaturas[i] = double.Parse(Console.ReadLine());
            somaTemp += temperaturas[i];
        }
       
        mediaTemp = somaTemp / temperaturas.Length;
        maiorTemp = temperaturas[0];
        menorTemp = temperaturas[0];

        for (int i = 0; i < temperaturas.Length; i++)
        {
            if (maiorTemp < temperaturas[i])
            {
                maiorTemp = temperaturas[i];
            }

            if (menorTemp > temperaturas[i])
            {
                menorTemp = temperaturas[i];
            }

            if (temperaturas[i] < mediaTemp)
            {
                contInferior++;
            }
        }
        
        Console.WriteLine("\na)Menor temperatura do ano: {0}ºC", menorTemp);
        Console.WriteLine("b)Maior temperatura do ano: {0}ºC", maiorTemp);
        Console.WriteLine("c)Temperatura media anual: {0}ºC", mediaTemp);
        Console.WriteLine("d)Dias com temperatura inferior a média: {0} dias", contInferior);
    }
}