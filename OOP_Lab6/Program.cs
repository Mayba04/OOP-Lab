using System;

interface IMovingObject
{
    void DisplayCoordinates(double t);
}

abstract class MovingObject : IMovingObject
{
    protected double x0;
    protected double a1;

    public MovingObject(double x0, double a1)
    {
        this.x0 = x0;
        this.a1 = a1;
    }

    public MovingObject()
    {
        this.x0 = 0;
        this.a1 = 0;
    }

    public void SetInitialPosition(double x0)
    {
        this.x0 = x0;
    }

    public void SetCoefficients(double a1)
    {
        this.a1 = a1;
    }

    public abstract void DisplayCoordinates(double t);

}

class MovingPoint : MovingObject
{
    public MovingPoint(double x0, double a1) : base(x0, a1) {}

    public override void DisplayCoordinates(double t)
    {
        double x = x0 + a1 * Math.Sin(t);
        double y = 0;
        double z = 0;
        Console.WriteLine($"Coordinates at time t={t}: x={x}, y={y}, z={z}");
    }
}

class MovingPoint3D : MovingObject
{
    private double y0;
    private double z0;
    private double a3;
    private double a2;

    public MovingPoint3D(double x0, double y0, double z0, double a1, double a2, double a3) : base(x0, a1)
    {
        this.y0 = y0;
        this.z0 = z0;
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
        IMovingObject movingObject = new MovingPoint(1.0, 2.0);
        movingObject.DisplayCoordinates(3.0);

        movingObject = new MovingPoint3D(1.0, 2.0, 3.0, 4.0, 5.0, 6.0);
        movingObject.DisplayCoordinates(3.0);
    }
}