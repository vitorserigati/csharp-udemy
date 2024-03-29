﻿namespace NoInterfaceDemo;
using NoInterfaceDemo.Entities;
using NoInterfaceDemo.Services;
using System.Globalization;
class Program
{

    static void Main(string[] args)
    {
        Console.WriteLine("Enter rental data: ");
        Console.Write("Car Model: ");
        string model = Console.ReadLine();
        Console.Write("Pickup (dd/MM/yyyy hh:mm): ");
        DateTime start = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);
        Console.Write("Return (dd/MM/yyyy hh:mm): ");
        DateTime finish = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);


        Console.WriteLine("Enter price per hour: ");
        double hour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        Console.WriteLine("Enter price per day: ");
        double day = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        CarRental carRental = new(start, finish, new Vehicle(model));

        RentalService rentalService = new RentalService(hour, day);
        rentalService.ProcessInvoice(carRental);

        Console.WriteLine("Invoice: ");
        Console.WriteLine(carRental.Invoice);
    }
}

