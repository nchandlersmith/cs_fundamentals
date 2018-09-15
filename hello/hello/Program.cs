using System;

namespace hello
{
    class Program
    {
        static void Main(string[] args)
        {
            string message;

            message = "Hello, " + args[0] + "!";
            Console.WriteLine(message);
        }
    }
}
