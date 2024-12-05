namespace Week8OOCSharp;
using System;

public class Multi
{

 
    interface IShape
    {
        double GetArea();
    }
     
    interface IColor
    {
        string GetColor();
    }
     
    class Rectangle : IShape, IColor
    {
        private double length;
        private double breadth;
        private string color;
     
        public Rectangle(double length, double breadth, string color)
        {
            this.length = length;
            this.breadth = breadth;
            this.color = color;
        }
     
        public double GetArea()
        {
            return length * breadth;
        }
     
        public string GetColor()
        {
            return color;
        }
    }
     
    class Program1
    {
        public static void Main1(string[] args)
        {
            Rectangle rect = new Rectangle(5, 10, "blue");
            Console.WriteLine("Area of rectangle: " + rect.GetArea());
            Console.WriteLine("Color of rectangle: " + rect.GetColor());
        }
    }
}