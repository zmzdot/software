using System;
using System.Collections.Generic;
using System.Globalization;

//定义形状接口
interface IShape
{
    double Calculation();
    bool IsRight();
}
//抽象形状类
public abstract class AbsShape : IShape
{
    public virtual double Calculation()
    {
        return 0;
    }
    public virtual bool IsRight()
    {
        return false;
    }
}
//长方形类
class Rectangle : AbsShape
{
    double Width { get; set; }
    double Height { get; set; }
    public Rectangle(double width, double height)
    {
        Width = width;
        Height = height;
    }
    public override double Calculation()
    {
        return Width * Height;
    }
    public override bool IsRight()
    {
        return Height > 0&& Width > 0;
    }
}
//正方形类
class Square : AbsShape
{
    double Edge { get; set; }
    public Square(double edge)
    {
        Edge = edge;
    }
    public override double Calculation()
    {
        return Edge * Edge;
    }
    public override bool IsRight()
    {
        return Edge > 0;
    }
}
//三角形类
class Triangle : AbsShape
{
    double Edge1 { get; set; }
    double Edge2 { get; set; }
    double Edge3 { get; set; }
    public Triangle(double edge1, double edge2, double edge3)
    {
        Edge1 = edge1;
        Edge2 = edge2;
        Edge3 = edge3;
    }
    public override double Calculation()
    {
        double x = (Edge1 + Edge2 + Edge3) / 2;
        return Math.Sqrt(x*(x-Edge1)*(x-Edge2)*(x-Edge3));
    }
    public override bool IsRight()
    {
        return (Edge1 + Edge2) > Edge3 && (Edge2 + Edge3) > Edge1 && (Edge1 + Edge3) > Edge2;
    }
}

//形状工厂类
class Shape
{
    public static IShape CreatShape(string ShapeType,params double[] parameters)
    {
        switch (ShapeType.ToLower())
        {
            case "rectangle":
                if(parameters.Length ==2)
                {
                    return new Rectangle(parameters[0], parameters[1]);
                }
                break;
            case "square":
                if(parameters.Length ==1)
                {
                    return new Square(parameters[0]);
                }
                break;
            case "triangle":
                if(parameters.Length ==3) 
                {
                    return new Triangle(parameters[0], parameters[1], parameters[2]);
                }
                break;
        }
        return null;
    }
}
class Program
{
    static void Main()
    {
        List<IShape> list = new List<IShape>();
        Random rand = new Random();
        for(int i=0;i<10;i++)
        {
            int shapeChoice=rand.Next(3);
            switch (shapeChoice)
            {
                case 0:
                    list.Add(Shape.CreatShape("rectangle", rand.NextDouble() * 10, rand.NextDouble() * 10));
                    break;
                case 1:
                    list.Add(Shape.CreatShape("square", rand.NextDouble() * 10));
                    break;
                case 2:
                    list.Add(Shape.CreatShape("triangle", rand.NextDouble() * 10, rand.NextDouble() * 10, rand.NextDouble() * 10));
                    break;
            }
        }
        double totalArea = 0;
        foreach(var shape in list)
        {
            if(shape!=null&&shape.IsRight())
            {
                totalArea += shape.Calculation();
            }
        }
        Console.WriteLine($"这些形状的面积之和为：{totalArea}");
    }
}



