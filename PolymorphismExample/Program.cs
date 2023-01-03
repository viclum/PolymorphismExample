using System;
using System.Collections.Generic;
using PolymorphismExample;

void DisplayArea(Shape s)
{
    Console.WriteLine(s.FindArea());
}

void InitShapeList(List<Shape> shapeList)
{
    Shape s1 = new Circle { Type = "Circle", Color = "Red", Radius = 20.0 };
    Shape s2 = new Square { Type = "Square", Color = "Red", Length = 10.0 };
    shapeList.Add(s1);
    shapeList.Add(s2);}

List<Shape> shapeList = new();

InitShapeList(shapeList);
foreach (var s in shapeList)
{
    Console.WriteLine(s.FindArea());
}
foreach (var s in shapeList)
{
    if (s is Circle)
    {
        Circle c = (Circle)s;
        c.Radius += 5.0;
    }
    else if (s is Square)
    {
        Square sq = (Square)s;
        sq.Length += 5.0;
    }
}
foreach (var s in shapeList)
{
    Console.WriteLine(s.FindArea());
}

