namespace ShapeAreaClassLibrary;

public class Circle : IShape
{
    private readonly double _radius;
    public Circle(double r)
    {
        if (r <= 0)
        {
            throw new ArgumentException("The value must be greater than 0");
        }
        _radius = r;
    }

    public double GetArea()
    {
        double area = Math.PI * Math.Pow(_radius, 2);
        return Math.Round(area, 2);
    }
}