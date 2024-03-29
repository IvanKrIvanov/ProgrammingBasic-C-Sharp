﻿using System;
using System.Drawing;
using System.Xml.Serialization;

namespace _07.AreaOfFigures
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string figure = Console.ReadLine();
            if (figure == "square")
            {
                double side = double.Parse(Console.ReadLine());
                double area = side * side;
                Console.WriteLine($"{area:F3}");
            }
            else if (figure == "rectangle")
            {
                double sideA = double.Parse(Console.ReadLine());
                double sideB = double.Parse(Console.ReadLine());

                double area = sideA * sideB;
                Console.WriteLine($"{area:F3}");

            }
            else if (figure == "circle")
            {
                double radius = double.Parse(Console.ReadLine());
                double area = Math.PI * Math.Pow(radius, 2);
                Console.WriteLine($"{area:F3}");
            }
            else if (figure == "triangle")
            {
                double side = double.Parse(Console.ReadLine());
                double hight = double.Parse(Console.ReadLine());

                double area = side * hight / 2;
                Console.WriteLine($"{area:F3}");
            }
        }
    }
}
