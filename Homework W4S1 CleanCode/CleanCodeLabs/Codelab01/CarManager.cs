using System.Text;

namespace CleanCodeLabs.Codelab01
{
    public class CarManager
    {
        private readonly CarDatabase carDatabase;

        public CarManager(CarDatabase carDb)
        {
            carDatabase = carDb;
        }

        public string GetCarsNames()
        {
            var sb = new StringBuilder();
            foreach (var car in carDatabase.GetCars)
            {
                sb.Append(car.Brand);
                sb.Append(" ");
                sb.Append(car.Model);
                sb.Append(", ");
            }

            var carNames = sb.ToString();
            return carNames.Substring(0, carNames.Length - 2);
        }

        public Car GetBestCar()
        {
            Car bestCar = null;
            foreach (var car in carDatabase.GetCars)
            {
                if (bestCar == null || car.Model.CompareTo(bestCar.Model) > 0)
                {
                    bestCar = car;
                }
            }

            return bestCar;
        }
    }
}