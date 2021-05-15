namespace RentalCars.Cars
{
    public class Mini : Car
    {
        public Mini(string model) : base(model) { }

        public override double RentPrice(int days)
        {
            int dayThreshold = 3;
            if (days <= dayThreshold)
            {
                return days * 15;
            }
            return dayThreshold * 15 + 10 * (days - dayThreshold);
        }

        private static double totalSum = 0;

        public override double TotalSum
        {
            get { return totalSum; }
            set { totalSum = value; }
        }
    }
}
