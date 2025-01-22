using System;

namespace HelloApp {
    class Program {
        static void Main( string[] arg ) {
            string? input = Console.ReadLine();
            string name = input ?? "Guest";


            Console.WriteLine("Hello, " + name);
        }
    }
}

// See https://aka.ms/new-console-template for more information
