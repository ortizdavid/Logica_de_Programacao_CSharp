internal class Program
{
    private static void Main(string[] args)
    {
        int codigo, senha;
        int codigoValido=1234, senhaValida=9999;
        string mensagem = "";

        Console.Write("Código Usuario: ");
        codigo = int.Parse(Console.ReadLine());
        
        if (codigo == codigoValido)
        {
            Console.Write("Senha Usuario: ");
            senha = int.Parse(Console.ReadLine());

            if (senha == senhaValida)
            {
                Console.WriteLine("Acesso Permitido!");
            }
            else
            {
                Console.Write("Senha Incorrecta");
                return;
            }
        } 
        else
        {
            Console.WriteLine("Usuário Inválido");
            return;
        }
    }
}