using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace F1_Simulator.Classes
{
    internal class GrandPrix
    {
        public string Name { get; set; }
        public int RaceWeek { get; set; }
        public int Laps { get; set; }
        public GPResults Results { get; set; }
        public Circuit Circuit { get; set; }
        public Image Flag { get; set; }

        public GrandPrix(int raceWeek, string name, int laps, Circuit circuit, Image flag) { 
            this.RaceWeek = raceWeek;
            this.Name = name;
            this.Circuit = circuit;
            this.Laps = laps;
            this.Results = null;
            this.Flag = flag;
        }
    }
}
