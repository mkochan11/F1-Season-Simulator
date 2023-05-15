using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace F1_Simulator.Classes
{
    internal class Car
    {
        public FrontWing FrontWing { get; set; }
        public RearWing RearWing { get; set; }
        public Engine Engine { get; set; }
        public Chassis Chassis { get; set; }
        public string Name { get; set; }
        public float Weight { get; set; }
        public float WeightReductionCost { get; set; }
        Random random { get; set; }
        public Car(string name, int minAeroPerformance, int maxAeroPerformance, int minPower, int maxPower, int minReliabality, int maxReliability, int minWeight, int maxWeight) { 
            random = new Random();
            Name = name;
            Weight = random.Next(minWeight, maxWeight + 1);
            FrontWing = new FrontWing(random.Next(minAeroPerformance, maxAeroPerformance + 1), random.Next(350000, 500001));
            RearWing = new RearWing(random.Next(minAeroPerformance, maxAeroPerformance + 1), random.Next(350000, 500001));
            Chassis = new Chassis(random.Next(minAeroPerformance, maxAeroPerformance + 1), random.Next(350000, 500001));
            Engine = new Engine(random.Next(minPower, maxPower + 1), random.Next(500000, 1000000), random.Next(400000, 500001), random.Next(minReliabality, maxReliability + 1));
            WeightReductionCost = (float)Math.Round((float)random.Next(400000, 500001)/1000)*1000;
        }

        public void ReduceWeight(float weight)
        {
            Weight -= weight;
        }
    }
}
