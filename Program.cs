﻿using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
            string Username;
            Username = Console.ReadLine();

            Console.WriteLine("Hello, " + Username);

            Console.Read();
        }
    }
}
