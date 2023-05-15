﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace F1_Simulator.Classes
{
    internal class FrontWing : AerodynamicPart
    {
        public FrontWing(int aeroPerformance, float costOfImprovement)
        {
            this.AeroPerformance = aeroPerformance;
            this.CostOfImprovement = (float)Math.Round(costOfImprovement/1000)*1000;
        }
    }
}
