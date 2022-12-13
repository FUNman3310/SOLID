using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISP
{
    internal interface IFuel
    {
        double FuelCapacity { get; set; }
        double CurrentFuel { get; set; }

        void AddFuel(double fuel)
        {

        }
    }
}
