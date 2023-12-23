using System;
using System.Text;
namespace StringBuilder1 
{
    class Program
    {
        public static void Main(string[] args)
        {
            //Default size is 16 characters.
            StringBuilder sb1 = new StringBuilder("Value1");
            StringBuilder sb2 = new StringBuilder("Value2");
            Console.WriteLine("Capacity: {0}, Capacity:{1}: ", sb1.Capacity, sb2.Capacity );
             
            sb1.Append("I am appended sb1");
            sb2.Append("I am appended under sb2");

            Console.WriteLine(sb1.ToString());
            Console.WriteLine(sb2.ToString());
        }

    }
   
}
