﻿using System;

namespace _06.Building
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int countOfFloar = int.Parse(Console.ReadLine());
            int countOfRooms = int.Parse(Console.ReadLine());

            for (int floor = countOfFloar; floor >= 1; floor--)
            {
                for (int room = 0; room < countOfRooms; room++)
                {
                    if (countOfRooms == floor)
                    {
                        Console.Write($"L{floor}{room} ");
                    }
                    else if (floor % 2 == 0)
                    {
                        Console.Write($"O{floor}{room} ");
                    }
                    else if (floor % 2 != 0)
                    {
                        Console.Write($"A{floor}{room} ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
