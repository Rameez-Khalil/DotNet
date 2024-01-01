using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static
{
    class NullableTypes
    {

        /*
         *  Nullables can be helpful when it comes to working with databases.
         *  We can simply add the question mark right next to our datatype to make it store the null
         *  <Data Type>? <variableName> = null; 
         */

        static int? nullableNumber = null;

        public static void CheckNull()
        {
            /*
             * There are two ways to check for a container that is holding null.
             *  variablename==null.
             *  !variablename.hasValue()
             */

            if (!nullableNumber.HasValue)
            {
                Console.WriteLine("Han nahi hai mere pas kuch bhi");
            }
        }

    }


}
