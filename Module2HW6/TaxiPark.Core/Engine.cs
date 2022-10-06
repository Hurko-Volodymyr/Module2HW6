using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxiPark.Core
{
    public class Engine
    {
        public int Power { get; private set; }
        public DateTime CreationDate { get; }

        public Engine(int power)
        {
            Power = power;
            CreationDate = DateTime.UtcNow;
        }
        public static void Roar()
        {
#pragma warning disable CA1416 // Проверка совместимости платформы
            Console.Beep(2000, 500);
#pragma warning restore CA1416 // Проверка совместимости платформы
        }
    }
}
