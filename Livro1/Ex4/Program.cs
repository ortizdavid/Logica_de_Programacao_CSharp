internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("A --> 6*(3+2) = {0}", 6*(3+2));
        Console.WriteLine("A --> 6*5 = {0}\n", 6*5);

        Console.WriteLine("B --> 2+(6*(3+2)) = {0}", 2+(6*(3+2)));
        Console.WriteLine("B --> 2+6*5 = {0}\n", 2+6*5);

        Console.WriteLine("C --> 2+(3*6)/(2+4) = {0}", 2+(3*6)/(2+4));
        Console.WriteLine("C --> 2+18/6 = {0}\n", 2+18/6);

        Console.WriteLine("D --> 2*(8/(3+1)) = {0}", 2*(8/(3+1)));
        Console.WriteLine("D --> 2*8/4 = {0}\n", 2*8/4);
        
        Console.WriteLine("E --> 3+(16-2)/(2*(9-2)) = {0}", 3+(16-2)/(2*(9-2)));
        Console.WriteLine("E --> 3+14/2*7 = {0}\n", 3+14/2*7);
        
        Console.WriteLine("F --> (6/3)+(8/2) = {0}", (6/3)+(8/2));
        Console.WriteLine("F --> 2+4 = {0}\n", 2+4);
        
        Console.WriteLine("G --> ((3+(8/2))*4)+(3*2) = {0}", ((3+(8/2))*4)+(3*2));
        Console.WriteLine("G --> ((3+4)*4)+(3*2) = {0}\n", ((3+(8/2))*4)+(3*2));
        
        Console.WriteLine("H --> (6*(3*3)+6)-10  = {0}", (6*(3*3)+6)-10);
        Console.WriteLine("H --> (6*3*3+6)-10 = {0}\n", (6*3*3+6)-10);
        
        Console.WriteLine("I --> (((10*8)+3)*9) = {0}", (((10*8)+3)*9));
        Console.WriteLine("I --> ((10*8+3)*9) = {0}\n", ((10*8+3)*9));
        
        Console.WriteLine("J --> ((-12)*(-4))+(3*(-4)) = {0}", ((-12)*(-4))+(3*(-4)));
        Console.WriteLine("J --> 12*4+3*(-4) = {0}\n", 12*4+3*(-4));
    }
}