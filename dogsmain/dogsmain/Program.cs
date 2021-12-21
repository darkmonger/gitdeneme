using System;
using dogs;

namespace dogsmain
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog dog1 = new Dog();
            Console.WriteLine(dog1.bark());
            Console.ReadLine();


            SheepDog dog2 = new SheepDog("rufus");
            Console.WriteLine(dog2.bark());

            SheepDog dog3 = new SheepDog();
            Console.WriteLine(dog2.bark()); 

            SheepDog dog4 = new SheepDog();
            Console.WriteLine(dog2.bark());

            SheepDog dog5 = new SheepDog();
            Console.WriteLine(dog2.bark());

            
        }
    }
}
