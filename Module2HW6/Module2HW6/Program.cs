using TaxiPark.Core;

namespace TaxiPark
{
    /// <summary>
    /// Main Program.
    /// </summary>
    public sealed class Program
    {
        /// <summary>
        /// Starts the App.
        /// </summary>
        /// <param name="args">console call params.</param>
        private static void Main(string[] args)
        {
            Console.WriteLine("Taxi park");
            var engine = new Engine(power: 12);
            var peguot = new Pegout(engine, ConsoleColor.Magenta, 1000000, 220, mov: new MoveBySecondWheels());
            var peguot1 = new Pegout(engine, ConsoleColor.Blue, 1000000, 220, mov: new MoveBySecondWheels());
            var subaru = new Subaru(engine, ConsoleColor.Cyan, 2000000, 360, mov: new MoveBySecondWheels());
            var subaru1 = new Subaru(engine, ConsoleColor.DarkBlue, 2000000, 360, mov: new MoveBySecondWheels());
            var volvo = new Volvo(engine, ConsoleColor.Green, 1500000, 250, mov: new MoveByFirstWheels());
            var volvo1 = new Volvo(engine, ConsoleColor.Gray, 1500000, 250, mov: new MoveByFirstWheels());

            peguot.Move();
            peguot.MoveWithWheels();
            peguot = new (engine, ConsoleColor.Magenta, 100000, 220, mov: new MoveByFirstWheels());
            peguot.MoveWithWheels();

            var cars = new TaxiParkPool();
            cars.AddCar(peguot);
            cars.AddCar(volvo);
            cars.AddCar(subaru);
            cars.AddCar(peguot1);
            cars.AddCar(volvo1);
            cars.AddCar(subaru1);

            var sortedCar = cars.SortByFuel();
            decimal totalPrice = 0;

            Console.WriteLine("Sorted by price: ");

            foreach (var car in sortedCar)
            {
                car.WriteCar();
                totalPrice += car.Price;
            }

            Console.WriteLine($"Total price: {totalPrice} JPY");

            var soughtCar = cars.FindCarBySpeed(250);
            Console.WriteLine($"Sought car: {soughtCar.Name}");
        }
    }
}
