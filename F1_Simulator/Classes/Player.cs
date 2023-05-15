using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace F1_Simulator.Classes
{
    internal class Player
    {   
        public string Name{ get; set; }
        public string CarName { get; set; }
        public List<string> Spendings { get; set; }
        public Team Team { get; set; }
        public Player(string Name, string TeamName, string carName) {
            this.Name = Name;
            this.CarName = carName;
            Car playersCar = new Car(carName, 70, 80, 750, 775, 60, 75, 810, 820);
            this.Team = new Team(TeamName, 5000000, System.Drawing.Color.Black, playersCar);
            this.Spendings = new List<string>();
        }
    }
}
