internal class Program
{
    private static void Main(string[] args)
    {
        float fahrenheit;
        float celsius;

        Console.Write("Temperatura Fahrenheit (ºF): ");
        fahrenheit = float.Parse(Console.ReadLine());

        celsius = ((fahrenheit - 32) * 5) / 9;
        Console.WriteLine("Temperatura em Celsius (ºC): {0}", celsius);
    }
}