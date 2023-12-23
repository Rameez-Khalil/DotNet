using System;
using System.Security.Cryptography;
namespace App
{
    class Program
    {
        public static void Main(string[] args)
        {
            HelloWorld("rameez");
            HelloWorld("rameez", 2); 

        }


        static void HelloWorld(string s, int id) {
            Console.WriteLine(s + id);
        }
        static void HelloWorld(string s) { 
            Console.WriteLine(s);
        }
    }
}