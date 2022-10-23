using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem_2___Coffee
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");
            List<string> coffeeList = Console.ReadLine().Split().ToList();
            int numberOfCommands = int.Parse(Console.ReadLine());

            for (int i = 1; i <= numberOfCommands; i++)
            {
                string command = Console.ReadLine();
                string[] cmdStrings = command.Split();
                string firstCommand = cmdStrings[0];

                if (firstCommand == "Include")
                {
                    string item = cmdStrings[1];
                    coffeeList.Add(item);
                } else if (firstCommand == "Remove")
                {
                    string firstOrLast = cmdStrings[1];
                    int numberCoffees = int.Parse(cmdStrings[2]);
                    if (coffeeList.Count > numberCoffees)
                    {
                        if (firstOrLast == "first")
                        {
                            coffeeList.RemoveRange(0,numberCoffees);
                        } else if (firstOrLast == "last")
                        {
                            int counter = 0;
                            // for (int j = coffeeList.Count - 1; j >= 0; j--)
                            // {
                            //     coffeeList.RemoveAt(i);
                            //     counter++;
                            //     if (counter == numberCoffees)
                            //     {
                            //         break;
                            //     }
                            //     
                            // }
                            int count = coffeeList.Count - numberCoffees;
                            coffeeList.RemoveRange(coffeeList.Count - numberCoffees,numberCoffees);
                        }
                    }


                } else if (firstCommand == "Prefer")
                {
                    int firstIndex = int.Parse(cmdStrings[1]);
                    int secondIndex = int.Parse(cmdStrings[2]);
                    if (firstIndex >= 0 && firstIndex <= coffeeList.Count - 1 && secondIndex >= 0 && secondIndex <= coffeeList.Count - 1)
                    {
                        string oldItem = coffeeList[firstIndex];
                        string newItem = coffeeList[secondIndex];

                        coffeeList.RemoveAt(firstIndex);
                        coffeeList.Insert(firstIndex,newItem);
                        coffeeList.RemoveAt(secondIndex);
                        coffeeList.Insert(secondIndex,oldItem);



                    }

                } else if (firstCommand == "Reverse")
                {
                    coffeeList.Reverse();
                }

                





            }

            Console.WriteLine("Coffees: ");
            Console.WriteLine(string.Join(" ",coffeeList));


        }
    }
}
