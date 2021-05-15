namespace RentalCars.Cars
{
    public class Premium : Car
    {
        public Premium(string model) : base(model) { }

        public override double RentPrice(int days)
        {
            return 30 * days;
        }

        private static double totalSum = 0;

        public override double TotalSum
        {
            get { return totalSum; }
            set { totalSum = value; }
        }
    }
}
