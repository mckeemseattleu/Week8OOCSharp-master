namespace ShapeFactory;

// Abstract Class since it has a virtual method
// Cannot instantiate

public class Shape
{
    public virtual void Draw()
    {
        Console.WriteLine("Drawing a shape");
    }
}

public class Circle : Shape
{
    public override void Draw()
    {
        Console.WriteLine("Drawing a circle");
    }
}

public class Rectangle : Shape
{
    public override void Draw()
    {
        Console.WriteLine("Drawing a rectangle");
    }
}

public class Triangle : Shape
{
    public override void Draw()
    {
        Console.WriteLine("Drawing a triangle");
    }
}

static class ShapeFactory
{
    // Data
    private static int m_type = 0;
    // Methods
    public static void setType(int type)
    {
        m_type = type;
    }
    
    public  static Shape CreateShape()
    {
        switch (m_type)
        {
            case 0:
                return new Triangle();
                break;
            case 1:
                return new Rectangle();
                break;
            case 2:
                return new Circle();
                break;
            case 3:
                return new Shape();
                break;
        }
        return new Shape();
    }

}

public class Program1 {
    public static void Main_poly () {

        Shape shape1 = new Shape();
        Shape shape2 = new Circle();
        Shape shape3 = new Rectangle();
        Shape shape4 = new Triangle();
        
        Console.WriteLine("This is a shape factory");
        ShapeFactory.setType(2);
        Shape shape5 = ShapeFactory.CreateShape();
        

        shape1.Draw(); // Outputs "Drawing a shape"
        shape2.Draw(); // Outputs "Drawing a circle"
        shape3.Draw(); // Outputs "Drawing a rectangle"
        shape4.Draw(); // Outputs "Drawing a triangle"     
        shape5.Draw();
    }
}