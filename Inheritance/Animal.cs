using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Animal
    {
        public String name;
        public String sound;

        public Animal(String name, String sound)
        {
            this.name = name;
            this.sound = sound;
        }


        AnimalInformation animalInfor = new AnimalInformation();

        public void SetAnimalInformation(String ownerName, int id)
        {
            animalInfor.ownerName = ownerName;
            animalInfor.id = id; 
        }

        public void GetAnimalInformation()
        {
            Console.WriteLine("Animal: " + name + "is owned by: " + animalInfor.ownerName);
        }

        public virtual void MakeSound()
        {
            Console.WriteLine("Name: " + name + " Sound: " + sound);
        }

        public class AnimalHealth
        {
            public bool HealthyWeight(double height, double weight)
            {
                double BMI = weight / Math.Pow(height, 2);

                if (BMI >= 18.5 && BMI <= 24.9)
                {
                    return true;
                }

                return false;
            }
        }
    }
}
