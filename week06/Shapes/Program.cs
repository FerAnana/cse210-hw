using System;
using System.Drawing;
using System.Formats.Asn1;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();

        Square shape1 = new Square("blue", 6);
        Rectangle shape2 = new Rectangle("orange", 4, 6);
        Circle shape3 = new Circle("skyblue", 5);

        shapes.Add(shape1);
        shapes.Add(shape2);
        shapes.Add(shape3);

        foreach (Shape shape in shapes)
        {
            double area = shape.GetArea();
            string color = shape.GetColor();
            Console.WriteLine(area);
            Console.WriteLine(color);
        }
    }
}