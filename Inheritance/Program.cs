using System;


public class Parent
{
    public double Circle(double radius)
    {
        return Math.PI * (radius * radius);
    }
}

public class Child : Parent
{
    public void Introduce()
    {
        Console.WriteLine(Circle(10));
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        Child child = new Child();


        child.Introduce();
    }
}