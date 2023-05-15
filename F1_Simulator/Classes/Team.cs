using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace F1_Simulator.Classes
{
    internal class Team
    {
        public Team(string Name, float Budget, Color color, Car car)
        {
            this.Name = Name;
            this.Budget = Budget;
            this.Points = 0;
            this.Driver1 = null; this.Driver2 = null;
            this.Color = color;
            this.Car = car;
            this.BudgetHistory = new BindingList<BudgetHistory>();
        }
        public string Name { get; set; }
        public float Budget { get; set; }
        public int Points { get; set; }
        public Color Color { get; set; }
        public Driver Driver1 { get; set; }
        public Driver Driver2 { get; set; }
        public Car Car { get; set; }
        public string Position { get; set; }
        public BindingList<BudgetHistory> BudgetHistory { get; set; }
        
        

        public void AssignDriver(Driver driver)
        {
            if(Driver1 == null)
            {
                Driver1 = driver;
                Driver1.Team = this.Name;
                Driver1.Color = this.Color;
            }
            else if(Driver2 == null)
            {
                Driver2 = driver;
                Driver2.Team = this.Name;
                Driver2.Color = this.Color;
            }
            else
            {
                throw new Exception();
            }
        }

        public void updatePoints()
        {
            this.Points = this.Driver1.Points + this.Driver2.Points;
        }

        public int GetFrontWingAeroPerformance()
        {
            return this.Car.FrontWing.GetAeroPerformance();
        }

        public float GetFrontWingCostOfImprovement()
        {
            return this.Car.FrontWing.GetCostOfImprovement();
        }
    }
}
