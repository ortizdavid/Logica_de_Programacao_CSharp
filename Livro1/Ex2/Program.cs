internal class Program
{
    static void ex2A(){
        Console.WriteLine("2.a)");
        int A = 10;
        int B = 20;
        Console.WriteLine("{0}", B);
        B = 5;
        Console.WriteLine("{0}, {1}\n", A, B);
    }

    static void ex2B(){
        Console.WriteLine("2.b)");
        int A = 30;
        int B = 20;
        int C = A + B;
        Console.WriteLine("{0}", C);
        B = 10;
        Console.WriteLine("{0}, {1}", B, C);
        C = A + B;
        Console.WriteLine("{0}, {1}, {2}\n", A, B, C);
    }

    static void ex2C(){
        Console.WriteLine("2.c)");
        int A = 10;
        int B = 20;
        int C = A;
        B = C;
        A = B;
        Console.WriteLine("{0}, {1}, {2}\n", A, B, C);
    }

    static void ex2D(){
        Console.WriteLine("2.d)");
        int A = 10;
        int B = A + 1;
        A = B + 1;
        B = A + 1;
        Console.WriteLine("{0}", A);
        A = B + 1;
        Console.WriteLine("{0}, {1}\n", A, B);
    }

    static void ex2E(){
        Console.WriteLine("2.e)");
        int A = 10;
        int B = 5;
        int C = A + B;
        B = 20;
        A = 10;
        Console.WriteLine("{0}, {1}, {2}\n", A, B, C);
    }

    static void ex2F(){
        Console.WriteLine("2.f)");
        int X = 1;
        int Y = 2;
        int Z = Y - X;
        Console.WriteLine("{0}", Z);
        X = 5;
        Y = X + Z;
        Console.WriteLine("{0}, {1}, {2}\n", X, Y, Z);
    }

    private static void Main(string[] args)
    {
        ex2A();
        ex2B();
        ex2C();
        ex2D();
        ex2E();
        ex2F();

    }
}