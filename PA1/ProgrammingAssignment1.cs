//Ethan Buchanan
//CSCI 352
//1/23/22
//PA1 - Getting in to C# Animal Classes

using System;
using System.Collections.Generic;

namespace PA1
{
    partial class ProgrammingAssignment1
    {
        public void menu()
        {
            List<Animal> world = new List<Animal>();
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
                                    //Sorry I know you dislike breaks but I couldn't get this to work without one.
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
                                world.Add(new Cat(tempName, Convert.ToInt32(tempAge), tempNoise, Convert.ToInt32(tempWeight)));
                            }

                            if (tempType == "Cassowary" || tempType == "cassowary")
                            {
                                world.Add(new Cassowary(tempName, Convert.ToInt32(tempAge), tempNoise, Convert.ToInt32(tempWeight)));
                            }

                            if (tempType == "Platypus" || tempType == "platypus")
                            {
                                world.Add(new Platypus(tempName, Convert.ToInt32(tempAge), tempNoise, Convert.ToInt32(tempWeight)));
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


                            world[listPosition].ASCIIanimal();
                            world[listPosition].printInfo();
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

                            world[listPosition].makeNoise();
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

                            world[listPosition].ageUp();
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
