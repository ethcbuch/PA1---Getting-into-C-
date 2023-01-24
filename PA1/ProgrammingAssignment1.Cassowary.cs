//Ethan Buchanan
//CSCI 352
//1/23/22
//PA1 - Getting in to C# Animal Classes

using System;

namespace PA1
{
    partial class ProgrammingAssignment1
    {
        class Cassowary : Animal
        {
            private string animalType = "Cassowary";

            public Cassowary(string animalName, int animalAge, string animalNoise, int animalWeight)
            {
                setName(animalName);
                setAge(animalAge);
                setNoise(animalNoise);
                setWeight(animalWeight);
            }

            public override void printInfo()
            {
                Console.WriteLine("Name: " + getName());
                Console.WriteLine("Age: " + getAge());
                Console.WriteLine("Weight: " + getWeight());
            }
            public override void makeNoise()
            {
                Console.WriteLine("The " + animalType + " makes this noise: " + animalNoise + "!!!!!!");
            }

            public override void ageUp()
            {
                ageIncrement();
                Console.WriteLine("The " + GetType() + " " + getName() + " is now " + getAge() + " years old!");
            }


            public override void ASCIIanimal()
            {
                Console.WriteLine("           _");
                Console.WriteLine("          /_\\");
                Console.WriteLine("       <=(' )");
                Console.WriteLine("         (;;");
                Console.WriteLine("         (//");
                Console.WriteLine("        (//");
                Console.WriteLine("         : '.------.");
                Console.WriteLine("         |    ---_-_)");
                Console.WriteLine("         `.________,'");
                Console.WriteLine("         __\\  \\");
                Console.WriteLine("        (|      \\");
                Console.WriteLine("                /|");
            }
        }
    }
}
