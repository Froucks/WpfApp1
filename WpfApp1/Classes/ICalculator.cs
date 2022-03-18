﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Integrtals.Classes
{
    interface ICalculator
    {
        double Calculate(double splitCount, double upLim, double lowLim, Func<double, double> integral, out double time);

    }
}