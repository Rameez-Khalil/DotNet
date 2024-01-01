using Static;
using System;
namespace StaticKeyWord
{
    class Animal
    {
        public String name; 
        public int id;
        public static int objectCount = 0; 
        public Animal(String name, int id)
        {
            this.name = name;
            this.id = id;
            objectCount++;

        }

    }


    /*
     *  Static belongs to the class.
     *  Every single object of type Animal, will have access to this value.
     *  This will remain constant. 
     *  'this' refers to the object's name.
     */

    class Program
    {
        public static void Main(String[] args) {
            //Animal animal = new Animal("Dog", 20);
            //Console.WriteLine(animal.id + " " + animal.name);
            //Console.WriteLine(Animal.objectCount);

            //2ND LECTURE OF STATIC.
            //ShapeMath shape1 = new ShapeMath("Rectangle", 10, 20);
            //ShapeMath shape2 = new ShapeMath("Triangle", 10, 20);
            //ShapeMath shape3 = new ShapeMath("Circle", 10, 20);


            //shape1.GetArea();
            //shape2.GetArea();
            //shape3.GetArea();

            //NULLABLE.
            NullableTypes.CheckNull();


        }
    }
}