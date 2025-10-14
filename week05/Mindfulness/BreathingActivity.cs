using System;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;

namespace MindfulnessApp
{
    class BreathingActivity : Activity
    {
        public BreathingActivity() : base(
            "Breathing Activity",
            "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.")
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

            var sw = Stopwatch.StartNew();
            while (sw.ElapsedMilliseconds < DurationSeconds * 1000)
            {
                Console.WriteLine();
                Console.Write("Breathe in...");
                ShowCountdown(4);
                Console.WriteLine();
                Console.Write("Breathe out...");
                ShowCountdown(6);
            }

            ShowEndingMessage();
            return Task.CompletedTask;
        }
    }
}

















