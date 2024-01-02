using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{

    //This class can never be instantiated.
    //This is just a roadmap for a class.
    /*
     * Non abstract methods are applicable.
     * Concrete methods are also allowed.
     */
    abstract class Shape
    {
        public String name { get; set; }
       
        //This is an informative method for this class.
        public void GetInformation()
        {
            Console.WriteLine(name + " This is the only information");
        }

        public abstract double GetArea(double width, double height); 
        


    }

    class Triangle : Shape
    {

        public override double GetArea(double width, double height)
        {
            return (width*height)/2;
        }

    }
}
