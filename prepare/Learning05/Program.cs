Square s1 = new Square("Rojo", 20);
s1.GetColor();
s1.GetArea();
Console.WriteLine($"{s1.GetColor()}");
Console.WriteLine($"{s1.GetArea()}");


Rectangle r1 = new Rectangle("Green", 20, 40);
r1.GetColor();
r1.GetArea();
Console.WriteLine($"{r1.GetColor()}");
Console.WriteLine($"{r1.GetArea()}");

Cicle c1 = new Cicle("Yellow", 20);
c1.GetColor();
c1.GetArea();
Console.WriteLine($"{c1.GetColor()}");
Console.WriteLine($"{c1.GetArea()}");

List<Shape> shapes = new List<Shape>();
shapes.Add(s1);
shapes.Add(r1);
shapes.Add(c1);

foreach (Shape item in shapes)
{
    Console.WriteLine($"Color: {item.GetColor()}");
    Console.WriteLine($"Area: {item.GetArea()}");
}


