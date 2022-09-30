using TaxiPark.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxiPark.Core
{
    public abstract class LightCar : Car
    {
        protected LightCar(Engine engine) : base(engine)
        {
        }

        public abstract int Capacity { get; }
    }
}
