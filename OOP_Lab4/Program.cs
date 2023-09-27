using System;

class MovingPoint
{
    protected double x0;
    protected double a1;

    public MovingPoint(double x0, double a1)
    {
        this.x0 = x0;
        this.a1 = a1;
    }

    public void SetInitialPosition(double x0)
    {
        this.x0 = x0;
    }

    public void SetCoefficients(double a1)
    {
        this.a1 = a1;
    }

    public virtual void DisplayCoordinates(double t)
    {
        double x = x0 + a1 * Math.Sin(t);
        double y = 0;
        double z = 0;
        Console.WriteLine($"Coordinates at time t={t}: x={x}, y={y}, z={z}");
    }
}

class MovingPoint3D : MovingPoint
{
    private double y0;
    private double z0;
    private double a3;
    private double a2;

    public MovingPoint3D(double x0, double y0, double z0, double a1, double a2, double a3): base(x0, a1)
    {
        this.y0 = y0;
        this.z0 = z0;
        this.a2 = a2;
        this.a3 = a3;
    }

    public void SetInitialPosition(double x0, double y0, double z0)
    {
        base.SetInitialPosition(x0);
        this.y0 = y0;
        this.z0 = z0;
    }

    public void SetCoefficients(double a1, double a2, double a3)
    {
        base.SetCoefficients(a1);
        this.a2 = a2;
        this.a3 = a3;
    }

    public override void DisplayCoordinates(double t)
    {
        double x = x0 + a1 * Math.Sin(t);
        double y = y0 + a2 * Math.Cos(t);
        double z = z0 + a3 * t * t;
        Console.WriteLine($"Coordinates at time t={t}: x={x}, y={y}, z={z}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter the initial x0 for MovingPoint: ");
        double x0 = double.Parse(Console.ReadLine());

        Console.Write("Enter the coefficient a1 for MovingPoint: ");
        double a1 = double.Parse(Console.ReadLine());

        MovingPoint pointX = new MovingPoint(x0, a1);

        Console.Write("Enter the initial x0 for MovingPoint3D: ");
        x0 = double.Parse(Console.ReadLine());

        Console.Write("Enter the initial y0 for MovingPoint3D: ");
        double y0 = double.Parse(Console.ReadLine());

        Console.Write("Enter the initial z0 for MovingPoint3D: ");
        double z0 = double.Parse(Console.ReadLine());

        Console.Write("Enter the coefficient a1 for MovingPoint3D: ");
        a1 = double.Parse(Console.ReadLine());

        Console.Write("Enter the coefficient a2 for MovingPoint3D: ");
        double a2 = double.Parse(Console.ReadLine());

        Console.Write("Enter the coefficient a3 for MovingPoint3D: ");
        double a3 = double.Parse(Console.ReadLine());

        MovingPoint3D pointXYZ = new MovingPoint3D(x0, y0, z0, a1, a2, a3);

        Console.Write("Enter the time (t) to calculate coordinates: ");
        double t = double.Parse(Console.ReadLine());

        Console.WriteLine("Coordinates for MovingPoint:");
        pointX.DisplayCoordinates(t);

        Console.WriteLine("Coordinates for MovingPoint3D:");
        pointXYZ.DisplayCoordinates(t);
    }
}