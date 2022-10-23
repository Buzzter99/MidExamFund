using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Phone_Shop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");
            List<string> phonesList = Console.ReadLine().Split(", ").ToList();
            string command = Console.ReadLine();

            while (command != "End")
            {
                string[] cmdArgs = command.Split(" - ");
                string commandArguments = cmdArgs[0];
                if (commandArguments == "Add")
                {
                    string phone = cmdArgs[1];
                    if (!phonesList.Contains(phone))
                    {
                        phonesList.Add(phone);
                    }
                } else if (commandArguments == "Remove")
                {
                    string phone = cmdArgs[1];
                    if (phone.Contains(phone))
                    {
                        phonesList.Remove(phone);
                    }
                } else if (commandArguments == "Bonus phone")
                {
                    string[] seccondSplit = cmdArgs[1].Split(":");
                    string oldPhone = seccondSplit[0];
                    string newPhone = seccondSplit[1];

                    if (phonesList.Contains(oldPhone))
                    {
                        int index = phonesList.IndexOf(oldPhone);
                        phonesList.Insert(index + 1,newPhone);
                    }


                } else if (commandArguments == "Last")
                {
                    string phone = cmdArgs[1];

                    if (phonesList.Contains(phone))
                    {
                        phonesList.Insert(phonesList.Count, phone);
                        phonesList.Remove(phone);
                        
                    }




                }




                command = Console.ReadLine();

            }

            Console.WriteLine(string.Join(", ",phonesList));




        }
    }
}
