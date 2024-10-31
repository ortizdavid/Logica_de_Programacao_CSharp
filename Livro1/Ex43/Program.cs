internal class Program
{
    private static void Main(string[] args)
    {
        int a, b, c;
        string mens="";

        Console.Write("A: ");
        a = int.Parse(Console.ReadLine());
        Console.Write("B: ");
        b = int.Parse(Console.ReadLine());
        Console.Write("C: ");
        c = int.Parse(Console.ReadLine());

        if ((a < b+c) && (b < a+c) && (c < a+b))
        {
            if (a==b && b==c)
            {
                mens = "Triângulo Equilátero";
            }
            else
            {
                if (a==b || b==c || a==c)
                {
                    mens = "Triângulo Isosceles";
                }
                else
                {
                    mens = "Triângulo Escaleno";
                }
            }
        }
        else
        {
            mens = "Nao e possível formar um triangulo";
        }
        Console.WriteLine(mens);
    }
}