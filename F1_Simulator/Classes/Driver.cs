using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace F1_Simulator.Classes
{
    internal class Driver
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string NameSurname {  get; set; }
        public string Abbreviation { get; set; }
        public int Number { get; set; }
        public int Points { get; set; }
        public int Skill { get; set; }
        public double RaceSalary { get; set; }
        public string Team { get; set; }
        public string Position { get; set; }
        public Color Color { get; set; }

        public Driver(string name, string surname, int number, int skill, double salary, int points)
        {
            this.Name = name;
            this.Surname = surname;
            this.NameSurname = name + " " + surname;
            this.Number = number;
            this.Skill = skill;
            Abbreviation = surname.Substring(0, 3);
            this.Points = points;
            this.RaceSalary = salary;
        }
    }
}
