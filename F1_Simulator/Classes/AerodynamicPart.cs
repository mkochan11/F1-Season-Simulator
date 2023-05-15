using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace F1_Simulator.Classes
{
    internal class AerodynamicPart
    {
        protected int AeroPerformance; //0-100, where 100 best Performance
        protected float CostOfImprovement; //$ per 1 AeroPerformance point

        public void UpgradeAeroPerformance(int improvementPoints)
        {
            this.AeroPerformance += improvementPoints;
        }

        public void ReduceAeroPerformance(int worsenPoints)
        {
            this.AeroPerformance -= worsenPoints;
        }

        public int GetAeroPerformance()
        {
            return this.AeroPerformance;
        }

        public float GetCostOfImprovement()
        {
            return this.CostOfImprovement;
        }
    }
}
