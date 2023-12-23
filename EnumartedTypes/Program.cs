using System;
namespace EnumeratedTypes
{
    class Program
    {
        public static void Main(string[] args) {
            CarColor carColor = CarColor.Green;
            PaintCar(carColor);
        
        }

        enum CarColor: byte
        {
            Orange = 1, 
            Blue, 
            Green, 
            Red, 
            Yellow
        }

        static void PaintCar(CarColor color)
        {
            Console.WriteLine("Car has been painted with: " + (int) color);
        }
    }
}