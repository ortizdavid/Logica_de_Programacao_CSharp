internal class Program
{
    private static void Main(string[] args)
    {
        int numConta;
        float saldo, debito, credito;
        float saldoActual;
        string mensagem="";

        Console.Write("Numero da Conta: ");
        numConta = int.Parse(Console.ReadLine());    
        Console.Write("Saldo: ");
        saldo = float.Parse(Console.ReadLine());  
        Console.Write("Débito: ");
        debito = float.Parse(Console.ReadLine());   
        Console.Write("Crédito: ");
        credito = float.Parse(Console.ReadLine());  

        saldoActual = (saldo - debito + credito);

        if (saldoActual >= 0)
        {
            mensagem = "Saldo Positivo";
        } 
        else
        {
            mensagem = "Saldo Negativo";
        }       

        Console.WriteLine("\nSaldo: {0}\nStatus: {1}", saldo, mensagem);   
    }
}