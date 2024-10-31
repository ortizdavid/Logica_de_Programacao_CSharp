internal class Program
{
    private static void Main(string[] args)
    {
        int horaInicio, horaFim, tempoMax=24;
        int duracaoJogo, duracaoAux, diff;
 
        Console.Write("Hora de Início: ");
        horaInicio = int.Parse(Console.ReadLine());
        Console.Write("Hora de Fim: ");
        horaFim = int.Parse(Console.ReadLine());

        if (horaFim >= 12 || horaInicio < 12)
        {
            duracaoJogo = horaFim - horaInicio;
        }
        else
        {
            duracaoJogo = (24 - horaInicio) + horaFim;
        }
       
        Console.WriteLine("Duração do Jogo: {0} horas", duracaoJogo);
    }
}