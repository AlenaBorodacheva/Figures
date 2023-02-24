using FigureLib.Abstracts.Interfaces;
using FigureLib.Figures;

IFigure circle = new Circle(5);
var circleArea = circle.GetArea();
Console.WriteLine(circleArea);

Triangle triangle = new Triangle(3, 4, 5);
var triangleArea = triangle.GetArea();
Console.WriteLine(triangleArea);
var isRight = triangle.IsRight();
Console.WriteLine(isRight);
