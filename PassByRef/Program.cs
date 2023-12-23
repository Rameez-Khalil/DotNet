using System; 
namespace PassByRef
{

    class Program
        {
        static void Main(string[] args)
            {
            int number1 = 10; 
            int number2 = 20;
            SwapNumbers(ref number1, ref number2);

            Console.WriteLine(number1);
            Console.WriteLine(number2);

            }


        static void SwapNumbers(ref int number1, ref int number2)
            {
            int temp = number1;
            number1 = number2;
            number2 = temp;

            }
        }
}