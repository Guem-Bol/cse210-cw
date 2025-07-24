using System;

class Program
{
    static void Main(string[] args)
    {
        {
        // 1. Create a Reference
        Reference john3_16 = new Reference("John", 3, 16);

        // 2. Define the scripture text
        string scriptureText = "For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life.";

        // 3. Create a Scripture object
        Scripture scripture = new Scripture(john3_16, scriptureText);

        Console.Clear(); // Clear console for clean display

        // Initial display
        Console.WriteLine(scripture.GetDisplayText());
        Console.WriteLine("\nPress Enter to hide words or type 'quit' to exit.");

        while (true)
        {
            string input = Console.ReadLine();
            if (input.ToLower() == "quit")
            {
                break;
            }

            Console.Clear();

            // Hide 3 words at a time
            scripture.HideRandomWords(3);

            Console.WriteLine(scripture.GetDisplayText());

            if (scripture.IsCompletelyHidden())
            {
                Console.WriteLine("\nAll words are hidden! Great job!");
                break;
            }

            Console.WriteLine("\nPress Enter to hide more words or type 'quit' to exit.");
        }

        Console.WriteLine("Exiting program. Goodbye!");
    }
}
    
}