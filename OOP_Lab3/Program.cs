public class QuadraticEquation
{
    private double a, b, c;
    private int equationNumber;

    public QuadraticEquation(int equationNumber, double a, double b, double c)
    {
        this.equationNumber = equationNumber;
        this.a = a;
        this.b = b;
        this.c = c;
    }

    ~QuadraticEquation()
    {
        Console.WriteLine($"Equation {equationNumber} destroyed.");
    }

    public bool HasRealRoots()
    {
        double discriminant = b * b - 4 * a * c;
        return discriminant >= 0;
    }

    public override string ToString()
    {
        return $"{equationNumber}";
    }
}

class Program
{
    private static void Task()
    {
        Console.Write($" Enter the number of quadratic equations: ");
        int count = int.Parse(Console.ReadLine());

        QuadraticEquation[] equations = new QuadraticEquation[count];
        Random random = new Random();
        for (int i = 0; i < count; i++)
        {
            double a = random.Next(1, 100);

            double b = random.Next(1, 100);

            double c = random.Next(1, 100);
            equations[i] = new QuadraticEquation(i + 1, a, b, c);
        }

        for (int i = 0; i < count; i++)
        {
            if (!equations[i].HasRealRoots())
            {
                Console.WriteLine($"Equation {equations[i]} has no valid roots.");
            }
            else
            {
                Console.WriteLine($"Equation {equations[i]} has real roots.");
            }
        }
    }

    static void Main(string[] args)
    {
        double memory1 = GC.GetTotalMemory(true);
        Console.WriteLine($"{memory1} bytes");
        Task();
        double memory2 = GC.GetTotalMemory(true);
        Console.WriteLine($"{memory2} bytes");
        Console.ReadLine();
    }
}