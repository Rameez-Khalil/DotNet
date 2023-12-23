using System; 
namespace ClassesAndObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal dog1 = new Animal("Edgar", "Warf");
            Animal dog2 = new Animal("Edgar", "Warf");
            
            Console.WriteLine(Animal.AnimalCount());  


        }
    }

    class Animal
    {
        //fields are methods and names.
        public String name;
        public String sound;
        static int count = 0;

       public Animal(String name, String sound)
        {
            this.name = name;
            this.sound = sound;
            count++;
        }

        Animal()
        {
            name = "no name";
            sound = "no sound"; 
            count++;
        }

        public void MakeSound()
        {
            Console.WriteLine(this.name + " " + this.sound);
        }

        public static int AnimalCount()
        {
            return count; 
        }

    }
}