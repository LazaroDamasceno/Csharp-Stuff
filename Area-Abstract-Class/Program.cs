using AreaAbstractClass;

Rectangle rectangle = new(12.0, 13.0);
Console.WriteLine(rectangle.DisplayArea());

Square square = new(14.0);
Console.WriteLine(square.DisplayArea());

Trapezium trapezium = new(15.0, 16.0, 17.0);
Console.WriteLine(trapezium.DisplayArea());

Triangle triangle = new(18.0, 19.0);
Console.WriteLine(triangle.DisplayArea());