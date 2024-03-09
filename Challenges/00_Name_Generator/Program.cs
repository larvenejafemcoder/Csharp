using System;
using System.Collections.Generic;

namespace name_generator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n<--------Human Name Generator--------->");
            Console.WriteLine("Enter name length:");
            string input = Console.ReadLine();

            if (int.TryParse(input, out int length))
            {
                Random random = new Random();
                string name = GenerateName(length, random);
                Console.WriteLine("Generated name: " + name);
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
            }
        }

        static string GenerateName(int length, Random random)
        {
            string vowels = "aeiou";
            string consonants = "bcdfghjklmnpqrstvwxyz";

            string name = "";

            for (int i = 0; i < length; i++)
            {
                if (i % 2 == 0)
                {
                    name += RandomChoice(consonants, random);
                }
                else
                {
                    name += RandomChoice(vowels, random);
                }
            }

            // Add a chance of doubling consonants
            for (int i = 0; i < length; i++)
            {
                if (random.Next(0, 4) == 0 && i > 0 && i < length - 1)
                {
                    name = name.Substring(0, i) + name[i] + name.Substring(i);
                    i++; // Skip the next character to avoid doubling again
                }
            }

            // Capitalize the first letter
            name = char.ToUpper(name[0]) + name.Substring(1);

            return name;
        }

        static char RandomChoice(string list, Random random)
        {
            return list[random.Next(0, list.Length)];
        }
    }
}
