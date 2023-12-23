using System; 
namespace Functions
{
    class Program
    {
        static void Main(string[] args)
        {


            int number1 = 20; 
            int number2 = 30;
            int result = AddNumbers(number1, number2);
            Console.WriteLine(result);


        }

        //private static void helloWorld(String name)
        //{
        //    Console.WriteLine("Hello World: " + name); 
        //}

        private static int AddNumbers(int number, int number2) {
               return number + number2;
        }
    }
}