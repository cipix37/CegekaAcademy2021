using System.Collections.Generic;

namespace CleanCodeLabs.Codelab01
{
    public class CarDatabase
    {
        private readonly List<Car> carDb = new List<Car>(new[]
        {
            new Car("1", "Golf III", "Volkswagen"),
            new Car("2", "Multipla", "Fiat"),
            new Car("3", "Megane", "Renault")
        });

        public IList<Car> GetCars
        {
            get
            {
                return carDb.AsReadOnly();
            }
        }

        public Car GetCarByID(string carId)
        {
            foreach (var car in carDb)
            {
                if (car.Id.Equals(carId))
                {
                    return car;
                }
            }
            return null;
        }
    }
}
