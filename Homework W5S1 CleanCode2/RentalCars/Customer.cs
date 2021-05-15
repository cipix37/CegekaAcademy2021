using System.Collections.Generic;
using RentalCars.Cars;

namespace RentalCars
{
    public class Customer
    {
        public Customer(string name)
        {
            Name = name;
        }

        public string Name { get; }

        public int FrequentRenterPoints { get; set; }

        public List<Rental> Rentals { get; } = new List<Rental>();

        public void AddRental(Rental rental)
        {
            Rentals.Add(rental);
        }
    }
}