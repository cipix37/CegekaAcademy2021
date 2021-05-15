using RentalCars.Cars;

namespace RentalCars
{

    public class Rental
    {
        public Rental(Customer customer, Car car, int daysRented, Office rentingOffice)
        {
            if (car is Luxury && customer.FrequentRenterPoints < 3)
            {
                throw new System.Exception("Luxury cars can only be rented to loyal customers.");
            }

            Customer = customer;
            Car = car;
            DaysRented = daysRented;
            RentingOffice = rentingOffice;
        }

        public Customer Customer { get; }
        public Car Car { get; }
        public int DaysRented { get; }
        public Office RentingOffice { get; }

        //alex: GetRentPrice
        public double RentPrice()
        {
            double val = Car.RentPrice(DaysRented);
            if (Customer.FrequentRenterPoints >= 5 && !(Car is Luxury))
            {
                val *= 0.95;
            }
            //alex: nu e chiar ok sa calculam asa
            if (RentingOffice == Office.Bucharest) val *= 3 / 2; 
            return val;
        }

        public void AddFrequentRenterPoints()
        {
            //for more complex rules, extract this logic into the car subclasses
            Customer.FrequentRenterPoints += 1;
            if (Car is Premium && DaysRented >= 2)
            {
                Customer.FrequentRenterPoints += 1;
            }
        }
    }
}