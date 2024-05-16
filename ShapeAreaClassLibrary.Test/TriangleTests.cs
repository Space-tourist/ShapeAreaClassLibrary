namespace ShapeAreaClassLibrary.Test;

public class TriangleTests
{
    [Fact]
    public void TrianglesSidesIsNotNull()
    {
        var triangle = new Triangle(3,4,5);

        var trueArea = 6;
        
        Assert.Equal( trueArea, triangle.GetArea());
    }

    [Fact]
    public void TrianglesSideIsNull()
    {
        var result = Assert.Throws<ArgumentException>(() => new Triangle(0,4,5));
        Assert.Equal("The value must be greater than 0", result.Message);
    }

    [Fact]
    public void IsRightТriangle()
    {
        var triangle = new Triangle(3,4,5);
        Assert.True(triangle.IsRightТriangle());
    }
}