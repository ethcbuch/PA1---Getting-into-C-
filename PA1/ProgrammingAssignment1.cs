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
            private string Name;
            private int Age;
            private string Noise;

            public abstract void printInfo();
            public abstract void makeNoise();
            public abstract void ageUp();

            public string getName()
            {
                return Name;
            }

            public int getAge()
            {
                return Age;
            }
            public string getNoise()
            {
                return Noise;
            }

            public void setName()
            {
                Name = Console.ReadLine();
            }
            public void setNoise()
            {
                Noise = Console.ReadLine();
            }

            public void setAge()
            {
                string a = Console.ReadLine();
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

            }

            public override void ageUp()
            {
            }
        }

        class Cassowary : Animal
        {
            public override void printInfo()
            {

            }
            public override void makeNoise()
            {

            }

            public override void ageUp()
            {
            }
        }
        static void Main(string[] args)
        {
        }
    }
}
