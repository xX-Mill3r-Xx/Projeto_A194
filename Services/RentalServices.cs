using System;
using Projeto_A194.Entities;

namespace Projeto_A194.Services
{
    class RentalServices
    {
        public double PricePerHours { get; private set; }
        public double PricePerDay { get; private set; }

        private BrazilianTaxService _brazilianTaxService = new BrazilianTaxService();

        public RentalServices(double pricePerHours, double pricePerDay)
        {
            PricePerHours = pricePerHours;
            PricePerDay = pricePerDay;
        }

        public void ProcessInvoice(CarRental carRental)
        {
            TimeSpan duration = carRental.Finish.Subtract(carRental.Start);
            double basicPayment = 0.0;
            if(duration.TotalHours <= 12.0)
            {
                basicPayment = PricePerHours * Math.Ceiling(duration.TotalHours);
            }
            else
            {
                basicPayment = PricePerDay * Math.Ceiling(duration.TotalDays);
            }

            double tax = _brazilianTaxService.Tax(basicPayment);

            carRental.Invoice = new Involce(basicPayment, tax);
        }
    }
}
