using System;
using System.Threading.Tasks;

namespace MindfulnessApp
{
    class Program
    {
        static async Task Main(string[] args)
        {
            bool exit = false;
            while (!exit)
            {
                Console.Clear();
                Console.WriteLine("Menu Options:");
                Console.WriteLine("1. Breathing Activity");
                Console.WriteLine("2. Reflection Activity");
                Console.WriteLine("3. Listing Activity");
                Console.WriteLine("4. Quit");
                Console.Write("\nSelect a choice from the menu: ");

                string choice = Console.ReadLine();
                Activity activity = choice switch
                {
                    "1" => new BreathingActivity(),
                    "2" => new ReflectionActivity(),
                    "3" => new ListingActivity(),
                    "4" => null,
                    _ => null
                };

                if (activity == null)
                {
                    if (choice == "4") exit = true;
                    else
                    {
                        Console.WriteLine("Invalid option. Press Enter to continue.");
                        Console.ReadLine();
                    }
                    continue;
                }

                try
                {
                    await activity.RunAsync();
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"\nAn error occurred: {ex.Message}");
                    Console.WriteLine("Press Enter to return to the menu...");
                    Console.ReadLine();
                }
            }

            Console.WriteLine("\nGoodbye!");
        }
    }
}















