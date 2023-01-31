using ExemploOO14_Service.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploOO14_Service.Services
{
    internal class RentalService
    {
        public double PricePerHour { get; private set; }
        public double PricePerDay { get; private set; }

        private ITaxService _TaxService;
        public RentalService(double pricePerHour, double pricePerDay, ITaxService taxService)
        {
            PricePerHour = pricePerHour;
            PricePerDay = pricePerDay;
            _TaxService= taxService;
        }
        public void ProcessInvoice(CarRental carRental)
        {
            TimeSpan duration = carRental.Finish.Subtract(carRental.Start);
            double BasicPayment = 0;
            if(duration.TotalHours <= 12.0)
            {
                BasicPayment = PricePerHour * Math.Ceiling(duration.TotalHours);
            }  
            else
            {
                BasicPayment = PricePerDay * Math.Ceiling(duration.TotalDays);
            }
            double Tax = _TaxService.Tax(BasicPayment);
            
            carRental.Invoice = new Invoice(BasicPayment, Tax);
        }
    }
}
