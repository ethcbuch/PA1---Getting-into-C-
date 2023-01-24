//Ethan Buchanan
//CSCI 352
//1/23/22
//PA1 - Getting in to C# Animal Classes

using System;
using System.Collections.Generic;

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

        }

        class Cat : Animal
        {
            private string animalType = "Cat";

            public Cat(string animalName, int animalAge, string animalNoise, int animalWeight)
            {
                this.animalAge = animalAge;
                this.animalName = animalName;
                this.animalNoise = animalNoise;
                this.animalWeight = animalWeight;
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
                Console.WriteLine("The " + animalType + " is now " + getAge() + " years old!");
            }


            public override void ASCIIanimal()
            {
                Console.WriteLine("          __..--''``---....___   _..._    __");
                Console.WriteLine("/// //_.-'    .-/;  `        ``<._  ``.''_ `. / / |");
                Console.WriteLine("///_.-' _..--.'_   )                     `( ) ) // //");
                Console.WriteLine("/ (_..-' // (< _     ;_..__               ; `' / ///");
                Console.WriteLine("/ // // //  `-._,_)' // / ``--...____..-' /// / //");
            }
        }

        class Cassowary : Animal
        {
            private string animalType = "Cassowary";

            public Cassowary(string animalName, int animalAge, string animalNoise, int animalWeight)
            {
                this.animalAge = animalAge;
                this.animalName = animalName;
                this.animalNoise = animalNoise;
                this.animalWeight = animalWeight;
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
                Console.WriteLine("The " + animalType + " is now " + getAge() + " years old!");
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

        class Platypus : Animal
        {
            private string animalType = "Platypus";

            public Platypus(string animalName, int animalAge, string animalNoise, int animalWeight)
            {
                this.animalAge = animalAge;
                this.animalName = animalName;
                this.animalNoise = animalNoise;
                this.animalWeight = animalWeight;
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
                Console.WriteLine("The " + animalType + " is now " + getAge() + " years old!");
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

        public void menu()
        {
            List<Animal> zoo = new List<Animal>();
            char userInput = '0';
            string tempType;
            string tempName;
            string tempAge;
            string tempNoise;
            string tempWeight;
            int listPosition;

            int listLength = 0;

            do
            {
                Console.WriteLine("Welcome to the Getting into C# - Animal Classes program! Select one of the following options: ");
                Console.WriteLine("1) Add an animal to the list.");
                Console.WriteLine("2) Print out the information of an animal.");
                Console.WriteLine("3) Let the animal make a sound.");
                Console.WriteLine("4) Age up an animal.");
                Console.WriteLine("5) Quit.");
                Console.WriteLine("Enter a choice now:");
                userInput = Console.ReadKey().KeyChar;

                switch (userInput)
                {
                    case '1':
                        {
                            Console.WriteLine("\nWhat type of animal do you want to add the list: Cat, Cassowary, or Platypus?");
                            tempType = Console.ReadLine();
                            while (true)
                            {
                                if (tempType == "Cat" || tempType == "cat" || tempType == "Cassowary" || tempType == "cassowary" || tempType == "Platypus" || tempType == "platypus")
                                {
                                    //Sorry I know you dislike breaks but I couldn't get to work without one.
                                    break;
                                }
                                Console.WriteLine("Please enter a valid type of animal!");
                                tempType = Console.ReadLine();

                            }
                            Console.WriteLine("What is its name?");
                            tempName = Console.ReadLine();
                            Console.WriteLine("How old is it?");
                            tempAge = Console.ReadLine();
                            Console.WriteLine("What noise does it make?");
                            tempNoise = Console.ReadLine();
                            Console.WriteLine("How much does it way in pounds?");
                            tempWeight = Console.ReadLine();

                            if (tempType == "Cat" || tempType == "cat")
                            {
                                zoo.Add(new Cat(tempName, Convert.ToInt32(tempAge), tempNoise, Convert.ToInt32(tempWeight)));
                            }

                            if (tempType == "Cassowary" || tempType == "cassowary")
                            {
                                zoo.Add(new Cat(tempName, Convert.ToInt32(tempAge), tempNoise, Convert.ToInt32(tempWeight)));
                            }

                            if (tempType == "Platypus" || tempType == "platypus")
                            {
                                zoo.Add(new Cat(tempName, Convert.ToInt32(tempAge), tempNoise, Convert.ToInt32(tempWeight)));
                            }

                            listLength++;
                            Console.WriteLine("Successfully added animal!");
                            break;
                        }
                    case '2':
                        {
                            if (listLength == 0)
                            {
                                Console.WriteLine("\nAdd an animal to the list!");
                                break;
                            }
                            Console.WriteLine("\nThere is " + listLength + " animals in the list. Please select a positon in the list to print that animals information (Starting from 0): ");
                            string a = Console.ReadLine();
                            listPosition = Convert.ToInt32(a);

                            while (true)
                            {
                                if (listLength > listPosition)
                                    break;
                                Console.WriteLine("Please enter a valid position of the list!");
                                a = Console.ReadLine();
                                listPosition = Convert.ToInt32(a);
                            }


                            zoo[listPosition].ASCIIanimal();
                            zoo[listPosition].printInfo();
                            break;

                        }
                    case '3':
                        {
                            Console.WriteLine("\nThere is " + listLength + " animals in the list. Please select a positon in the list for that animal to make a noise. (Starting from 0): ");
                            string a = Console.ReadLine();
                            listPosition = Convert.ToInt32(a);

                            while (true)
                            {
                                if (listLength > listPosition)
                                    break;
                                Console.WriteLine("Please enter a valid position of the list!");
                                a = Console.ReadLine();
                                listPosition = Convert.ToInt32(a);
                            }

                            zoo[listPosition].makeNoise();
                            break;
                        }
                    case '4':
                        {
                            if (listLength == 0)
                            {
                                Console.WriteLine("\nAdd an animal to the list!");
                                break;
                            }
                            Console.WriteLine("\nThere is " + listLength + " animals in the list. Please select a positon in the list to age up (Starting from 0): ");
                            string a = Console.ReadLine();
                            listPosition = Convert.ToInt32(a);

                            while (true)
                            {
                                if (listLength > listPosition)
                                    break;
                                Console.WriteLine("Please enter a valid position of the list!");
                                a = Console.ReadLine();
                                listPosition = Convert.ToInt32(a);
                            }

                            zoo[listPosition].ageUp();
                            break;
                        }
                    case '5':
                        {
                            Console.WriteLine("Thank you for using the program. Bye!");
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Enter a valid key!");
                            userInput = Console.ReadKey().KeyChar;

                            break;
                        }
                }

            } while (userInput != '5');
        }

        static void Main(string[] args)
        {
            ProgrammingAssignment1 a = new ProgrammingAssignment1();

            a.menu();

        }
    }
}
