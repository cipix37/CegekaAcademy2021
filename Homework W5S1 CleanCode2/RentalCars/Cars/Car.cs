namespace RentalCars.Cars
{
    public abstract class Car
    {
        public Car(string model)
        {
            Model = model;
        }

        //alex: asta pare a fi nefolosita
        public abstract double TotalSum { get; set; }

        public string Model { get; }

        public abstract double RentPrice(int days);
    }
}