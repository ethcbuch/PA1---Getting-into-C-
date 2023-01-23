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
            private string animalName;
            private int animalAge;
            private string animalNoise;
            private int animalWeight;

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

            public void setName()
            {
                animalName = Console.ReadLine();
            }
            public void setNoise()
            {
                animalNoise = Console.ReadLine();
            }

            public void setAge()
            {
                int a = Console.ReadLine();
                animalAge = Convert.ToInt32(a);

            }

            public void setWeight()
            {
                int b = Console.ReadLine();
                animalWeight = Convert.ToInt32(b);
            }
        }

        class Cat : Animal
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
            Animal bigWorld = new Animal();
            List<bigWorld> zoo = new List<bigWorld>();

            Cat newCat = new Cat()
            zoo.Add(newCat);
            newCat.setAge();
            newCat.setName();
            newCat.setNoise();
            newCat.setWeight();

            newCat.printInfo();

            Console.WriteLine(zoo[0]);
            Console.ReadKey();
        }
    }
}
