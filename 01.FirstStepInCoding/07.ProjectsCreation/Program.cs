﻿using System;
using System.Net.Http.Headers;

namespace _07.ProjectsCreation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int count = int.Parse(Console.ReadLine());
            int hours = count * 3;

            Console.WriteLine($"The architect {name} will need {hours} hours to complete {count} project/s.");
        }
    }
}
