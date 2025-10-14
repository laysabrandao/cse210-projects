using System;
using System.Diagnostics;
using System.Threading;

namespace MindfulnessApp
{
    abstract class Activity
    {
        private string _name;
        private string _description;
        private int _durationSeconds;

        protected Activity(string name, string description)
        {
            _name = name;
            _description = description;
        }

        public string Name => _name;
        public string Description => _description;
        public int DurationSeconds => _durationSeconds;

        public void SetDuration(int seconds)
        {
            if (seconds <= 0) throw new ArgumentException("Duration must be positive.");
            _durationSeconds = seconds;
        }

        protected void ShowStartingMessage()
        {
            Console.Clear();
            Console.WriteLine($"*** {Name} ***\n");
            Console.WriteLine(Description);
            Console.WriteLine();
            Console.Write("Enter duration in seconds: ");
        }

        protected void ShowEndingMessage()
        {
            Console.WriteLine();
            Console.WriteLine("Well done!");
            ShowSpinner(3);
            Console.WriteLine();
            Console.WriteLine($"You have completed the {Name} for {DurationSeconds} seconds.");
            ShowSpinner(3);
            Console.WriteLine("\nPress enter to return to menu");
            Console.ReadLine();
        }

        protected void ShowSpinner(int seconds)
        {
            char[] spinner = { '|', '/', '-', '\\' };
            var sw = Stopwatch.StartNew();
            int i = 0;
            while (sw.ElapsedMilliseconds < seconds * 1000)
            {
                Console.Write(spinner[i % spinner.Length]);
                Thread.Sleep(250);
                Console.Write('\b');
                i++;
            }
        }

        protected void ShowCountdown(int seconds)
        {
            for (int i = seconds; i > 0; i--)
            {
                Console.Write(i);
                Thread.Sleep(1000);
                Console.Write("\b \b");
            }
        }

        protected void ShowDots(int seconds)
        {
            var sw = Stopwatch.StartNew();
            while (sw.ElapsedMilliseconds < seconds * 1000)
            {
                for (int i = 0; i < 3 && sw.ElapsedMilliseconds < seconds * 1000; i++)
                {
                    Console.Write('.');
                    Thread.Sleep(500);
                }
                Console.Write("\b\b\b   \b\b\b");
            }
        }

        public abstract System.Threading.Tasks.Task RunAsync();
    }
}








