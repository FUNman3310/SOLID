﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISP
{
    internal interface IVehicl
    {
        string Brand { get; set; }
        string Model { get; set; }

        void Drive();
    }
}
