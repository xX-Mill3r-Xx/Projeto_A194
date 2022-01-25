using System;
using System.Globalization;
using Projeto_A194.Entities;
using Projeto_A194.Services;

namespace Projeto_A194
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Exercicio da aula 194 do curso
             Aplicação criada sem o uso de uma Interface*/ 
            Console.WriteLine("Enter Rental Data:");
            Console.Write("Car Model: ");
            string model = Console.ReadLine();
            Console.Write("PickUp: (dd/MM/yyyy HH:mm): ");
            DateTime start = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);
            Console.Write("Return: (dd/MM/yyyy HH:mm): ");
            DateTime finish = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);

            Console.Write("Enter Price per Hour: ");
            double hour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Enter Price per Day: ");
            double day = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            CarRental carRental = new CarRental(start, finish, new Vehicle(model));

            RentalServices rentalServices = new RentalServices(hour, day);
            rentalServices.ProcessInvoice(carRental);

            Console.WriteLine($"Invoice:");
            Console.WriteLine(carRental.Invoice);

            Console.ReadLine();
        }
    }
}
