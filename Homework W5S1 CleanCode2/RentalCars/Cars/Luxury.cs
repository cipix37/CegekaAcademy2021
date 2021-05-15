namespace RentalCars.Cars
{
    //alex: LucuryCar, MiniCar...etc
    public class Luxury : Car
    {
        public Luxury(string model) : base(model) { }

        public override double RentPrice(int days)
        {
            return 70 * days;
        }

        private static double totalSum = 0;

        public override double TotalSum
        {
            get { return totalSum; }
            set { totalSum = value; }
        }
    }
}
