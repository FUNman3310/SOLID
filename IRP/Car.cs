using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISP
{
    internal class Car : IVehicl, IFuel
    {
        public double FuelCapacity { get ; set; }
        public double CurrentFuel { get; set; }
        public string Brand { get;set; }
        public string Model { get; set; }

        public void AddFuel(double fuel)
        {
            Console.WriteLine("fuel added");
        }

        public void Drive()
        {
            Console.WriteLine("drived");
        }
    }
}
