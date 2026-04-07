using System;

namespace ConsoleApp1
{
    internal class ShapeCalculator
    {
        // =======================
        // 2D SHAPES (AREA)
        // =======================

        public double Triangle(double b, double h) => 0.5 * (b * h);              //1
        public double Square(double a) => a * a;                                  //2
        public double Rectangle(double w, double h) => w * h;                     //3
        public double Parallelogram(double b, double h) => b * h;                 //4
        public double Trapezoid(double a, double b, double h) => 0.5 * (a + b) * h; //5
        public double Circle(double r) => Math.PI * Math.Pow(r, 2);              //6
        public double Ellipse(double a, double b) => Math.PI * (a * b);           //7

        // =======================
        // 3D SHAPES (VOLUME)
        // =======================

        public double Cube(double a) => a * a * a;                                 //8
        public double RectangularPrism(double l, double w, double h) => l * w * h; //9
        public double Cylinder(double r, double h) => Math.PI * r * r * h;         //10
        public double Cone(double r, double h) => (1.0 / 3) * Math.PI * r * r * h; //11
        public double Sphere(double r) => (4.0 / 3) * Math.PI * r * r * r;         //12
        public double Hemisphere(double r) => (2.0 / 3) * Math.PI * r * r * r;     //13
    }

    class Program
    {
        static void Main(string[] args)
        {
            ShapeCalculator shape = new ShapeCalculator();

            // =======================
            // OUTPUT: 2D SHAPES
            // =======================

            Console.WriteLine($"Triangle -> {shape.Triangle(5, 10)}");        //1
            Console.WriteLine($"Square -> {shape.Square(4)}");                //2
            Console.WriteLine($"Rectangle -> {shape.Rectangle(6, 8)}");       //3
            Console.WriteLine($"Parallelogram -> {shape.Parallelogram(7, 3)}"); //4
            Console.WriteLine($"Trapezoid -> {shape.Trapezoid(5, 3, 4)}");    //5
            Console.WriteLine($"Circle -> {shape.Circle(5)}");                //6
            Console.WriteLine($"Ellipse -> {shape.Ellipse(4, 2)}");           //7

            // =======================
            // OUTPUT: 3D SHAPES
            // =======================

            Console.WriteLine($"Cube -> {shape.Cube(3)}");                    //8
            Console.WriteLine($"Rectangular Prism -> {shape.RectangularPrism(10, 20, 25)}"); //9
            Console.WriteLine($"Cylinder -> {shape.Cylinder(3, 6)}");         //10
            Console.WriteLine($"Cone -> {shape.Cone(2, 4)}");                 //11
            Console.WriteLine($"Sphere -> {shape.Sphere(3)}");                //12
            Console.WriteLine($"Hemisphere -> {shape.Hemisphere(2)}");        //13

            Console.ReadKey();
        }
    }
}
