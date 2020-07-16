using System;

namespace OOP2
{
    class Program
    {
        static void TestTask01()
        {
            Animal cow = new Animal("cow");
            Console.WriteLine(cow.Sound());

            Dog dog = new Dog("dog");
            Console.WriteLine(dog.Sound());

            var lady = new LadyWithAnAnimal(dog);
            Console.WriteLine(lady.Sound());

            Animal[] zoo = {cow, dog};
            foreach (var animal in zoo)
            {
                Console.WriteLine("animal in zoo says " + animal.Sound());
            }
        }
        static void Main(string[] args)
        {
            TestTask01();
        }
    }
}
