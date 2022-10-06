using TaxiPark.Core;

namespace TaxiPark
{
    public static class Extentions
    {
        public static string GetPriceAsString(this Car car)
        {
            return car.Price.ToString();
        }

        public static bool IsThisVolvo(this string name)
        {
            return name == "Volvo";
        }

        public static void WriteCar(this Car car)
        {
            Console.WriteLine($"Name: {car.Name}, price: {car.Price} JPY, fuel consumption: {car.FuelConsumption} L/100 km.");
        }
    }
}
