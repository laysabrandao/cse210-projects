using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading.Tasks;

namespace MindfulnessApp
{
    class ReflectionActivity : Activity
    {
        private readonly List<string> _prompts = new()
        {
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something truly selfless."
        };

        private readonly List<string> _questions = new()
        {
            "Why was this experience meaningful to you?",
            "Have you ever done anything like this before?",
            "How did you get started?",
            "How did you feel when it was complete?",
            "What made this time different than other times when you were not as successful?",
            "What is your favorite thing about this experience?",
            "What could you learn from this experience that applies to other situations?",
            "What did you learn about yourself through this experience?",
            "How can you keep this experience in mind in the future?"
        };

        private readonly Random _rnd = new();

        public ReflectionActivity() : base(
            "Reflection Activity",
            "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.")
        { }

        public override Task RunAsync()
        {
            ShowStartingMessage();
            if (!int.TryParse(Console.ReadLine(), out int seconds) || seconds <= 0)
            {
                Console.WriteLine("Invalid duration. Press Enter to return to menu.");
                Console.ReadLine();
                return Task.CompletedTask;
            }
            SetDuration(seconds);

            Console.WriteLine("Prepare to begin...");
            ShowDots(3);

            string prompt = _prompts[_rnd.Next(_prompts.Count)];
            Console.WriteLine($"\nPrompt:\n--- {prompt} ---\n");
            Console.WriteLine("When you have something in mind, press Enter to continue.");
            Console.ReadLine();

            var sw = Stopwatch.StartNew();
            while (sw.ElapsedMilliseconds < DurationSeconds * 1000)
            {
                string question = _questions[_rnd.Next(_questions.Count)];
                Console.WriteLine($"\n{question}");
                int remaining = (int)((DurationSeconds * 1000 - sw.ElapsedMilliseconds) / 1000);
                int spinTime = Math.Min(7, Math.Max(1, remaining));
                ShowSpinner(spinTime);
            }

            ShowEndingMessage();
            return Task.CompletedTask;
        }
    }
}












