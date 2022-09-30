using TaxiPark.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxiPark.Core
{
    public class TaxiParkPool
    {
        private readonly List<Car> _cars = new();

        public void AddCar(Car car) => _cars.Add(car);

        public Car FindCarBySpeed(int speed)
        {
            return _cars.FirstOrDefault(car => car.Speed == speed);
        }

        public List<Car> SortByFuel()
        {
            return _cars.OrderBy(car => car.FuelConsumption).ToList();
        }
    }
}
