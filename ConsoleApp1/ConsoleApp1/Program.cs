using System;
using System.Numerics;

namespace ConsoleApp1
{

    public class Program
        
    {
        //No need to create object.
        static void Main(string[] args)
        {

            int number1 = 5;
            int number2 = 0;
            try
            {
                Console.WriteLine("Calling Do Division: ");
                doDivision(number1, number2);
            }
            catch (DivideByZeroException e)
            {
                //Console.WriteLine("You cannot divide by Zero");
                Console.WriteLine(e.Message);
            }


        }

        static void doDivision(int number1, int number2)
        {
            if (number2 == 0)
            {
                throw new DivideByZeroException(); 
            }
            Console.WriteLine(number2/number1);
        }

    }
}