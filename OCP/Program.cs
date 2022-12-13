using OCP;
namespace OCP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AreaCalculator areaCalculator = new AreaCalculator();
            Console.WriteLine(areaCalculator.AreaCalcul(new Triangle { Height = 12, Width = 16 }));
            Console.WriteLine(areaCalculator.AreaCalcul(new Circle { Radius = 8}));
            Console.WriteLine(areaCalculator.AreaCalcul(new Rectangle {Width = 9, Height = 7 }));

        }
    }
}