using System;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        PromptGenerator generator = new PromptGenerator();
        bool running = true;

        while (running)
        {
            Console.WriteLine("\nWelcome to the Journal Program!");
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1": //write
                    string prompt = generator.GetRandomPrompt();
                    Console.WriteLine($"\nPrompt: {prompt}");
                    string response = Console.ReadLine();
                    string date = DateTime.Now.ToShortDateString();

                    Entry entry = new Entry(date, prompt, response);
                    journal.AddEntry(entry);
                    break;

                case "2": //display
                    journal.DisplayAll();
                    break;

                case "3": //load
                    Console.Write("Enter filename to load: ");
                    string loadFile = Console.ReadLine();
                    journal.LoadFromFile(loadFile);
                    break;

                case "4": //save
                    Console.Write("What is the filename?");
                    string saveFile = Console.ReadLine();
                    journal.SaveToFile(saveFile);
                    break;

                case "5": //quit
                    running = false;
                    break;

                default:
                    Console.WriteLine("Invalid option, try again :)");
                    break;
            }

        }
    }
}
