// Пример использования:
using ShapeAreaClassLibrary;

 
var circle = new Circle(10);
PrintArea(circle);
        
var triangle = new Triangle(6,7,8);
PrintArea(triangle);

void PrintArea(IShape shape)
{
    Console.WriteLine(shape.GetArea());
}