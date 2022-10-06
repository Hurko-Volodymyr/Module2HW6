using System;
using TaxiPark.Core;

namespace TaxiPark.Core
{
    public abstract class Car
    {
        public abstract ConsoleColor Color { get; set; }
        public abstract string Name { get; }
        public abstract int Speed { get; }
        public abstract decimal Price { get; }
        public abstract int FuelConsumption { get; }
        public Engine Engine { get; set; }

        protected Car(Engine engine)
        {
            Engine = engine ?? throw new ArgumentNullException(nameof(engine));
        }

        public abstract void Move();
    }
}
