namespace GeometriskeFigurer_Nedarvning
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Shape> shapes = new List<Shape>
            {
                new Circle(3),
                new Rectangle(4, 5),
                new Circle(2.5),
                new Rectangle(6, 2)
            };

            double totalArea = 0;

            foreach (var shape in shapes)
            {
                Console.WriteLine($"Shape: {shape.GetType().Name}");
                Console.WriteLine($"Area: {shape.GetArea:F2}");
                Console.WriteLine($"Perimeter: {shape.GetPerimeter:F2}\n");

                totalArea += shape.GetArea;
            }

            Console.WriteLine($"Total area of all shapes: {totalArea:F2}");
        }
    }
}
