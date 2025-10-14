using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading.Tasks;

namespace MindfulnessApp

{
    class ListingActivity : Activity
    {
        private readonly List<string> _prompts = new()
        {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?"
        };

        private readonly Random _rnd = new();

        public ListingActivity() : base(
            "Listing Activity",
            "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.")
        { }

        public override async Task RunAsync()
        {
            ShowStartingMessage();
            if (!int.TryParse(Console.ReadLine(), out int seconds) || seconds <= 0)
            {
                Console.WriteLine("Invalid duration. Press Enter to return to menu.");
                Console.ReadLine();
                return;
            }
            SetDuration(seconds);

            Console.WriteLine("Prepare to begin...");
            ShowDots(3);

            string prompt = _prompts[_rnd.Next(_prompts.Count)];
            Console.WriteLine($"\nList Prompt:\n--- {prompt} ---\n");
            Console.WriteLine("You will have a few seconds to think...");
            ShowCountdown(5);
            Console.WriteLine($"\nStart listing items! Press Enter after each item. You have {DurationSeconds} seconds.\n");

            List<string> items = new();
            Stopwatch sw = Stopwatch.StartNew();

            while (sw.ElapsedMilliseconds < DurationSeconds * 1000)
            {
                int msRemaining = (int)(DurationSeconds * 1000 - sw.ElapsedMilliseconds);
                Task<string> readTask = Task.Run(() => Console.ReadLine());
                Task completed = await Task.WhenAny(readTask, Task.Delay(msRemaining));

                if (completed == readTask)
                {
                    string input = readTask.Result;
                    if (!string.IsNullOrWhiteSpace(input))
                        items.Add(input.Trim());
                }
                else break;
            }

            Console.WriteLine($"\nYou listed {items.Count} items:");
            foreach (var item in items)
                Console.WriteLine($" - {item}");

            ShowEndingMessage();
        }
    }
}




