﻿using System;

namespace _11.FruitShop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string  fruit = Console.ReadLine();
            string dayOfWeek = Console.ReadLine();
            double quantity = double.Parse(Console.ReadLine());
            double price = 0;
            if (dayOfWeek == "Monday" || dayOfWeek == "Tuesday" || dayOfWeek == "Thursday" || dayOfWeek == "Wednesdey" || dayOfWeek == "Fruday")
                switch (fruit)
                {
                    case "banana": price = 2.50; break;
                    case "apple": price = 1.20; break;
                    case "orange": price = 0.85; break;
                    case "grapefruit": price = 1.45; break;
                    case "kiwi": price = 2.70; break;
                    case "pineapple": price = 5.50; break;
                    case "grapes": price = 3.85; break;
                    default: Console.WriteLine("error"); break;
                }
            else if (dayOfWeek == "Saturday" || dayOfWeek == "Sunday")
            {
                switch (fruit)
                {
                    case "banana": price = 2.70; break;
                    case "apple": price = 1.25; break;
                    case "orange": price = 0.90; break;
                    case "grapefruit": price = 1.60; break;
                    case "kiwi": price = 3.00; break;
                    case "pineapple": price = 5.60; break;
                    case "grapes": price = 4.20; break;
                    default: Console.WriteLine("error"); break;
                }
            }
            else
            {
                Console.WriteLine("error");
            }
            if (price > 0)
            {
                double finalPrice = quantity * price;
                Console.WriteLine($"{finalPrice:F2}");
            }


        }
    }
}
