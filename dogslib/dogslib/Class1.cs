using System;

namespace dogs
{
    
    
        public abstract class Animal
        {
            
            public abstract string bark();
        }

        public class Dog : Animal
        {


            private string name;

            public  string getname()
            {
                return this.name;
            }
            public Dog() { }

            public Dog(string nm)
            {
                this.name = nm;
            }

            public override string bark()
            {
                return ("bow-wow");
            }


         
        }
        public class SheepDog : Dog
        {
            private int age;
             
            public SheepDog () {}
            public SheepDog(string nm, int age) : base(nm)
            {
                this.age = age;
            
            }
            
            

            public override string bark()
            {
                Random random = new Random();
                int min = 1;
                int max = 10;
                string barking = "";
                int number = random.Next(min, max);
                for (int i = 0; i < number; i++)
                {
                    barking += "bow-wow ";
                }
                return ("barking");
            }
        }
        
        public int getage()
        {
           return this.getage;
        }
    
}

