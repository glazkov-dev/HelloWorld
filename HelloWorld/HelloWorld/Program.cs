using System;
using System.Threading;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Thread.Sleep(1000);
            Console.WriteLine("Wake up, Neo...");
            Thread.Sleep(2000);
            Console.Clear();
            Console.WriteLine("The Matrix has you...");
            Thread.Sleep(2000);
            Console.Clear();
            Console.WriteLine("Follow the white rabbit.");
            Thread.Sleep(2000);
            Console.Clear();
            Console.WriteLine("Knock, knock, Neo.");
            Thread.Sleep(2000);
            Console.ReadKey();
        }
    }
}
