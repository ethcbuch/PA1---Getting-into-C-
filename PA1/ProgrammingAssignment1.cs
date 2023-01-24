using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PA1
{
    class ProgrammingAssignment1
    {
        abstract class Animal
        {
            protected string animalName;
            protected int animalAge;
            protected string animalNoise;
            protected int animalWeight;

            public Animal()
            {

            }

            public abstract void printInfo();
            public abstract void makeNoise();
            public abstract void ageUp();

            public void ageIncrement()
            {
                animalAge++;
            }
            public string getName()
            {
                return animalName;
            }

            public int getAge()
            {
                return animalAge;
            }
            public string getNoise()
            {
                return animalNoise;
            }
            public int getWeight()
            {
                return animalWeight;
            }

        }

        class Cat : Animal
        {
            public Cat (string animalName, int animalAge, string animalNoise, int animalWeight)
            { 
                this.animalAge = animalAge;
                this.animalName = animalName;
                this.animalNoise = animalNoise;
                this.animalWeight = animalWeight;
            }

            public override void printInfo()
            {
                Console.WriteLine(getName());
                Console.WriteLine(getAge());
                Console.WriteLine(getNoise());
                Console.WriteLine(getWeight());
            }
            public override void makeNoise()
            {
                Console.WriteLine(getNoise());
            }

            public override void ageUp()
            {
                ageIncrement();
            }
        }

        class Cassowary : Animal
        {

            public override void printInfo()
            {
                Console.WriteLine(getAge());
                Console.WriteLine(getNoise());
                Console.WriteLine(getName());
            }
            public override void makeNoise()
            {
                Console.WriteLine(getNoise());
            }

            public override void ageUp()
            {
                ageIncrement();
            }
        }

        static void Main(string[] args)
        {
            List<Animal> zoo = new List<Animal>();

            zoo.Add(new Cat("Bill", 12, "meow", 10));
            zoo[0].printInfo();
           Console.ReadKey();
        }
    }
}
