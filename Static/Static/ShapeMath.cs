using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Static
{
    class ShapeMath
    {

        public String shape;
        double length1; 
        double length2; 
        public  double GetArea()
        {
            if (shape.Equals("Rectangle"))
            {
                Console.WriteLine("Rectangle Method");
                return length1 * length2; 
            }

            if(String.Equals("Triangle", shape, StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("Triangle Method");
                return length1 * (length2 / 2);
            }

            else if(String.Equals("Circle",shape, StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("Circle Method");
                return (Math.PI) * Math.Pow(length1, 2); 
            }

            else
            {
                Console.WriteLine("No shape match was found");
                return -1;
            }
        }


        public ShapeMath(String shape, double length1, double length2) {
            this.shape = shape;
            this.length1 = length1;
            this.length2 = length2; 
        }

    }


   


}
