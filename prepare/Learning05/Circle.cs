public class Cicle: Shape
{
    private double _radius;

    public Cicle(string color, double radius): base (color)
    {
        SetColor(color);
        _radius = radius;
    }

    public override double GetArea()
    {
        double area = Math.PI *_radius * _radius;
        return area;
    }

    

}