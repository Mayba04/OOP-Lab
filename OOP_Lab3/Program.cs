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

    public double CalculateDiscriminant()
    {
        return b * b - 4 * a * c;
    }

    public bool HasRealRoots()
    {
        double discriminant = b * b - 4 * a * c;
        return discriminant >= 0;
    }


}


class Program
{

    private static void Task1()
    {
        Console.Write("Enter the number of quadratic equations: ");
        int count = int.Parse(Console.ReadLine());

        QuadraticEquation[] equations = new QuadraticEquation[count];

        for (int i = 0; i < count; i++)
        {
            Console.WriteLine($"Enter the coefficients a, b, and c for the equation{i + 1}:");
            Console.Write("A: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("B: ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("C: ");
            double c = double.Parse(Console.ReadLine());
            equations[i] = new QuadraticEquation(i + 1, a, b, c);
        }

       

        for (int i = 0; i < count; i++)
        {
            if (equations[i].HasRealRoots())
            {
                Console.WriteLine($"Equation {equations[i]} has real roots.");
            }
            else
            {
                Console.WriteLine($"Equation {equations[i]} has no valid roots.");
            }
        }

        for (int i = 0; i < count; i++)
        {
            equations[i] = null;
        }
       
       

    }

    static void Main(string[] args)
    {
        Task1();
        GC.Collect();
        Console.ReadLine();
    }
}