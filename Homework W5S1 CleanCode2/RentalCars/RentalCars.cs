using System;
using System.Collections.Generic;
using System.Linq;
using RentalCars.Cars;

namespace RentalCars
{
    public class RentalCars
    {
        private readonly List<Rental> _rentals = new List<Rental>();

        public RentalCars(string name)
        {
            Name = name;
        }

        public string Name { get; }

        public void AddRental(Rental rental)
        {
            _rentals.Add(rental);
            rental.Customer.AddRental(rental);
        }

        public string Statement()
        {
            double totalAmount = 0;

            string output = "Rental Record for " + Name + "\n";
            output += "------------------------------\n";

            foreach (Rental rental in _rentals)
            {
                double thisAmount = rental.RentPrice();
                //alex: ce se intampla daca generezi statement-ul de mai multe ori?
                rental.AddFrequentRenterPoints();

                output += rental.Customer.Name + "\t" + rental.Car.Model + "\t" + rental.DaysRented + "d \t" + thisAmount + " EUR\n";
                totalAmount += thisAmount;
            }
            output += "------------------------------\n";
            output += "Total revenue " + totalAmount + " EUR\n";

            //statement version 2
            output+= "\nCategory   Total Income\n";

            //alex: F bine ca ai folosit groupBy. Puteai sa pui metode separate pt fiecare statement
            var result = _rentals
                .GroupBy(item => item.Car.GetType())
                .Select(group => new { group.Key, sum = group.Sum(item => item.RentPrice()) })
            .ToList();

            foreach(var a in result)
            {
                output += a.Key.ToString() + "   " + a.sum.ToString() + "\n";
            }

            return output;
        }
    }
}