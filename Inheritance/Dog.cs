using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
     class Dog : Animal
    {
        public Dog(string name, string sound) : base(name, sound)
        {
        }

        public string sound2 { get; set; } = "Grr!";
        public override void MakeSound()
        {
            Console.WriteLine("I am dog, I will bark");
        }

       

    }

    
}
