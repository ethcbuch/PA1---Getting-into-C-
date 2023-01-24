//Ethan Buchanan
//CSCI 352
//1/23/22
//PA1 - Getting in to C# Animal Classes

using System;

namespace PA1
{
    partial class ProgrammingAssignment1
    {
        class Platypus : Animal
        {
            private string animalType = "Platypus";

            public Platypus(string animalName, int animalAge, string animalNoise, int animalWeight)
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
                Console.WriteLine("             _.- ~~^^^'~- _ __ .,.- ~ ~ ~  ~  -. _");
                Console.WriteLine("  ________, '       ::.                       _,-  ~ -.");
                Console.WriteLine("((~_/   -s -  ::                     , '          ;,");
                Console.WriteLine(" \\       <.._ .;;;`                     ;           }  `'");
                Console.WriteLine("  ``======='    _ _- _ (   }             `,          ,'(,  `,");
                Console.WriteLine("               ((/ _ _,i   ! _ ~ - -- - _ _'_-_,_,,,'    (,  ;");
                Console.WriteLine("                  ((((____/            (,(,(, ____>        (,'");
            }
        }
    }
}
