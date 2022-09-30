using TaxiPark.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxiPark.Core
{
    public abstract class CargoCar : Car
    {
        protected CargoCar(Engine engine) : base(engine)
        {
        }

        public int LiftingCapacity { get; set; }
    }
}
