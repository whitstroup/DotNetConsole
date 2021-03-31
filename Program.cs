using System;

namespace dotNetConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, what is your name?");

            var name = Console.ReadLine();


            Console.WriteLine("Hello "+ name + "!");
        }
    }
}
