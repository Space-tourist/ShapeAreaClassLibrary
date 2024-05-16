namespace ShapeAreaClassLibrary.Test;

public class CircleTests
{
    [Fact]
    public void RadiusIsNotNull()
    {
        var circle = new Circle(5);
        
        var trueArea = 78.54;
        
        Assert.Equal(trueArea, circle.GetArea());
    }

    [Fact]
    public void RadiusIsNull()
    {
        var result = Assert.Throws<ArgumentException>(() => new Circle(0).GetArea());
        Assert.Equal("The value must be greater than 0", result.Message);
    }
}