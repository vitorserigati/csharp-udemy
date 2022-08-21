﻿namespace VetoresF;

class Program
{
    static void Main(string[] args)
    {
        Student[] rooms = new Student[10];

        Console.Write("How many rooms will be rented? ");
        int rent = int.Parse(Console.ReadLine());

        for (int i = 0; i < rent; i++)
        {
            Console.WriteLine("\nRent #" + (i + 1));
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Email: ");
            string email = Console.ReadLine();
            Console.Write("Room: ");
            int room = int.Parse(Console.ReadLine());

            rooms[room] = new Student(name, email);
        }

        Console.WriteLine("Busy Rooms: ");
        for (int i = 0; i < rooms.Length; i++)
        {
            if (rooms[i] != null)
            {
                Console.WriteLine($"{i}: {rooms[i]}");
            }
        }
    }
}