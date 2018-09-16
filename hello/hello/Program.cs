using System;

namespace hello
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your name: ");
            string name = Console.ReadLine();
            string greeting = "Hello, " + name + "!";

            Console.WriteLine("How many whole hours of sleep did you get last night?");
            int hoursOfSleep = int.Parse(Console.ReadLine());
            string sleepMessage;
            if (hoursOfSleep >= 8)
            {
                sleepMessage = "You are well rested.";
            } else
            {
                sleepMessage = "You are sleepy.";
            }
            
            Console.WriteLine(greeting);
            Console.WriteLine(sleepMessage);
        }
    }
}
