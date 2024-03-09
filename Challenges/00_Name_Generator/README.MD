##How it Works
##Main Method
The Main method serves as the entry point for the program. It prompts the user to enter the desired length of the name and handles user input validation. If the input is valid, it generates a human-like name using the GenerateName method and displays it on the console.

static void Main(string[] args)
{
    // Prompt user to enter name length
    Console.WriteLine("\n<--------Human Name Generator--------->");
    Console.WriteLine("Enter name length:");
    string input = Console.ReadLine();

    // Validate user input
    if (int.TryParse(input, out int length))
    {
        // Generate and display the name
        Random random = new Random();
        string name = GenerateName(length, random);
        Console.WriteLine("Generated name: " + name);
    }
    else
    {
        Console.WriteLine("Invalid input. Please enter a valid number.");
    }
}
##GenerateName Method
The GenerateName method constructs the human-like name based on the specified length. It alternates between consonants and vowels to create a natural-sounding name. Additionally, it adds variations such as doubling consonants and capitalizes the first letter of the generated name for a polished appearance.

static string GenerateName(int length, Random random)
{
    // Define sets of vowels and consonants
    string vowels = "aeiou";
    string consonants = "bcdfghjklmnpqrstvwxyz";

    string name = "";

    // Generate name by alternating between consonants and vowels
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

    // Add variation by doubling consonants
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
##RandomChoice Method
The RandomChoice method randomly selects a character from a given string.

static char RandomChoice(string list, Random random)
{
    return list[random.Next(0, list.Length)];
}
##Contributing
Contributions are welcome! If you'd like to contribute to the project, please follow the steps outlined in the Contributing section of this README.

##License
This project is licensed under the MIT License - see the LICENSE file for details.