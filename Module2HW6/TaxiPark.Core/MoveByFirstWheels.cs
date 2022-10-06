using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxiPark.Core
{
    public class MoveByFirstWheels : IMovableWithDifferentWheels
    {
        public void MoveWithDifferentWheels()
        {
            Console.WriteLine("Move by first wheels");
        }


    }
}