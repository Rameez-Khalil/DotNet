namespace AbstractClass
{
    class Program
    {
        public static void Main(string[] args) { 
            Triangle triangle = new Triangle();
            triangle.name = "Triangle";
            triangle.GetInformation();
            double results = triangle.GetArea(10.00,10.00);
            Console.WriteLine(results);

        }

    }
}