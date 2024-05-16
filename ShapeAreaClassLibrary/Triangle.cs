namespace ShapeAreaClassLibrary;

public class Triangle : IShape
{
    private readonly double _a;
    private readonly double _b;
    private readonly double _c;

    public Triangle(double a, double b, double c)
    {
        if (a <= 0 || b <= 0 || c <= 0)
        {
            throw new ArgumentException("The value must be greater than 0");
        }
        _a = a;
        _b = b;
        _c = c;
    }

    public double GetArea()
    {
        double halfPerimeter = (_a + _b + _c) / 2;
        double area = Math.Sqrt(halfPerimeter * (halfPerimeter - _a) * (halfPerimeter - _b) * (halfPerimeter - _c));
        return Math.Round(area, 2);
    }

    public bool IsRightТriangle()
    {
        if (Math.Pow(_a, 2) + Math.Pow(_b, 2) == Math.Pow(_c, 2) ||
            Math.Pow(_b, 2) + Math.Pow(_c, 2) == Math.Pow(_a, 2) ||
            Math.Pow(_a, 2) + Math.Pow(_c, 2) == Math.Pow(_b, 2))
        {
            return true;
        }
        
        return false;
    }
}