//Ethan Buchanan
//CSCI 352
//1/23/22
//PA1 - Getting in to C# Animal Classes

namespace PA1
{
    partial class ProgrammingAssignment1
    {
        abstract class Animal
        {
            private string animalName;
            private int animalAge;
            private string animalNoise;
            private int animalWeight;

            public Animal()
            {

            }

            public abstract void printInfo();
            public abstract void makeNoise();
            public abstract void ageUp();

            public abstract void ASCIIanimal();

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

            public void setName(string name)
            {
                animalName = name;
            }

            public void setAge(int age)
            {
                animalAge = age;
            }

            public void setNoise(string noise)
            {
                animalNoise = noise;
            }

            public void setWeight(int weight)
            {
                animalWeight = weight;
            }

        }
    }
}
