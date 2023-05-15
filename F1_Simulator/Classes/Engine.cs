using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace F1_Simulator.Classes
{
    internal class Engine
    {
        float Power;
        float CostOfPowerImprovement;
        float CostOfReliabilityImprovement;
        float Reliability; // in %
        public Engine(float power, float costOfPowerImprovement, float costOfReliabilityImprovement, float reliabilty)
        {
            this.Power = power;
            this.CostOfPowerImprovement = (float)Math.Round(costOfPowerImprovement / 1000) * 1000;
            this.CostOfReliabilityImprovement = (float)Math.Round(costOfReliabilityImprovement / 1000) * 1000;
            this.Reliability = reliabilty;
        }

        public float GetPower()
        {
            return this.Power;
        }

        public float GetReliability()
        {
            return this.Reliability;
        }

        public float GetCostOfPowerImprovement()
        {
            return this.CostOfPowerImprovement;
        }

        public float GetCostOfReliabilityImprovement()
        {
            return this.CostOfReliabilityImprovement;
        }

        public void UpgradePower(float additionalPower)
        {
            this.Power += additionalPower;
        }

        public void ReducePower(float minusPower)
        {
            this.Power -= minusPower;
        }

        public void UpgradeReliability(float additionalReliability)
        {
            this.Reliability += additionalReliability;
        }

        public void ReduceReliability(float minusReliability)
        {
            this.Reliability -= minusReliability;
        }
    }
}
