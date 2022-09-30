using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxiPark.Core
{
    public class Pegout : LightCar
    {
        private Pegout(Engine engine) : base(engine)
        {
        }

        public Pegout(Engine engine, ConsoleColor color, decimal price, int speed, IMovableWithDifferentWheels mov) : this(engine)
        {
            Color = color;
            Name = "Peguet";
            Price = price;
            Speed = speed;
            Movable = mov;
        }

        public override int Capacity { get => 4; }
        public override ConsoleColor Color { get; set; }
        public override string Name { get; }
        public override int Speed { get; }
        public override decimal Price { get; }
        public override int FuelConsumption { get => 10; }
        public IMovableWithDifferentWheels Movable { get; set; }
        public void MoveWithWheels()
        {
            Movable.MoveWithDifferentWheels();
        }


        public override void Move()
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = Color;
            Engine.Roar();
            Console.WriteLine($"{Color} {Name} is moving with speed {Speed} and consuming {FuelConsumption} l/100 km.");
            Console.WriteLine($"Engine power is {Engine.Power}");
        }

    }
}
