using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace F1_Simulator.Classes
{
    internal class Circuit
    {
        public string Name { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string Type { get; set; }
        public float Length { get; set; } // in kilometeres
        public float AeroPerformanceImportance { get; set; } // in range 0-1, where 1 most important
        public float EnginePowerImportance { get; set; } // in range 0-1, where 1 most important
        public float TyreStress { get; set; } // in range 0-1, where 1 is biggest tyre stress
        public Image Layout { get; set; }
        public Circuit(string name, string country, string city, string type, float lenght, float aeroPerformanceImportance, float enginePowerImportance, float tyreStress, Image image) { 
            this.Name = name;
            this.Country = country;
            this.City = city;
            this.Type = type;
            this.Length = lenght;
            this.AeroPerformanceImportance = aeroPerformanceImportance;
            this.EnginePowerImportance = enginePowerImportance;
            this.TyreStress = tyreStress;
            this.Layout = image;
        }

    }
}
