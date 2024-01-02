namespace Inheritance
{
    class Program
    {
        public static void Main(string[] args) { 
            Dog dog = new Dog("Edgar", "Bhao");
            dog.SetAnimalInformation("Ahsan Khawaja", 302);
            dog.GetAnimalInformation();
            dog.MakeSound();
           
        }
    }
}