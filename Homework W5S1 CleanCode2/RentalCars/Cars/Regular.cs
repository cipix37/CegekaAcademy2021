namespace RentalCars.Cars
{
    public class Regular : Car
    {
        public Regular(string model) : base(model) { }

        public override double RentPrice(int days)
        {
            int dayThreshold = 2;
            if (days <= dayThreshold)
            {
                return days * 20;
            }
            return dayThreshold * 20 + 15 * (days - dayThreshold);
        }

        private static double totalSum = 0;

        public override double TotalSum 
        {
            get { return totalSum; }
            set { totalSum = value; }
        }
    }
}
