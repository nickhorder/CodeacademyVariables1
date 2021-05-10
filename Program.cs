using System;

namespace Codeacademy_C__Variables1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create Variables
            string name = "Shadow";
            string breed = "Golden Retriever";
            int age = 5;
            double weight = 65.22;
            bool spayed = true;
            // Print variables to the console
            Console.Write(name + ", who is a ");
            Console.Write(breed + ", is the age of ");
            Console.Write(age + ". the dog weighs ");
            Console.Write(weight + "kg. ");
            Console.WriteLine("have they been spayed?: " + spayed);
        }
    }
}
