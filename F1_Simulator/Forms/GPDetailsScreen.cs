using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace F1_Simulator.Forms
{
    partial class GPDetailsScreen : UserControl
    {
        Start Start { get; set; }
        int Index;
        public GPDetailsScreen()
        {
            InitializeComponent();
        }

        public void Initialize(Start start, int index)
        {
            this.Index = index;
            this.Start = start;
            this.circuitLayoutImage.Image = Start.GetGrandPrixesList()[Index].Circuit.Layout;
            this.titleLabel.Text = Start.GetGrandPrixesList()[Index].Name + " Details";
            this.flagImage.Image = Start.GetGrandPrixesList()[Index].Flag;
            this.circuitName.Text = Start.GetGrandPrixesList()[Index].Circuit.Name;
            this.circuitType.Text = Start.GetGrandPrixesList()[Index].Circuit.Type;
            this.circuitLength.Text = Start.GetGrandPrixesList()[Index].Circuit.Length.ToString() + "km";
            this.circuitDownforce.Text = (Start.GetGrandPrixesList()[Index].Circuit.AeroPerformanceImportance * 100).ToString() + "%";
            this.circuitFullThrottle.Text = (Start.GetGrandPrixesList()[Index].Circuit.EnginePowerImportance * 100).ToString() + "%";
            this.circuitTyreStress.Text = (Start.GetGrandPrixesList()[Index].Circuit.TyreStress * 100).ToString() + "%";
            this.GPCountry.Text = Start.GetGrandPrixesList()[Index].Circuit.Country;
            this.GPCity.Text = Start.GetGrandPrixesList()[Index].Circuit.City;
            this.GPRaceWeek.Text = Start.GetGrandPrixesList()[Index].RaceWeek.ToString();
            this.GPLaps.Text = Start.GetGrandPrixesList()[Index].Laps.ToString();


            if (Start.GetGrandPrixesList()[Index].Name == "Gran Premio de la Ciudad de Mexico")
            {
                this.titleLabel.Location = new Point(this.titleLabel.Location.X - 100, this.Location.Y);
            }
            if (Start.GetGrandPrixesList()[Index].Name == "Grande Premio de Sao Paulo" || Start.GetGrandPrixesList()[Index].Name == "Grosses Preis von Osterreich")
            {
                this.titleLabel.Location = new Point(this.titleLabel.Location.X - 75, this.Location.Y);
            }
            if (Start.GetGrandPrixesList()[Index].Name == "Gran Premio Emilia-Romagna") 
            {
                this.titleLabel.Location = new Point(this.titleLabel.Location.X - 50, this.Location.Y);
            }
            if (Start.GetGrandPrixesList()[Index].Name == "Saudi Arabian Grand Prix")
            {
                this.titleLabel.Location = new Point(this.titleLabel.Location.X - 25, this.Location.Y);
            }

        }

        private void backLabel_Click(object sender, EventArgs e)
        {
            this.Start.CalendarScreen_Load();
            this.Hide();
            if (Start.GetGrandPrixesList()[Index].Name == "Gran Premio de la Ciudad de Mexico")
            {
                this.titleLabel.Location = new Point(this.titleLabel.Location.X + 100, this.Location.Y);
            }
            if (Start.GetGrandPrixesList()[Index].Name == "Grande Premio de Sao Paulo" || Start.GetGrandPrixesList()[Index].Name == "Grosses Preis von Osterreich")
            {
                this.titleLabel.Location = new Point(this.titleLabel.Location.X + 75, this.Location.Y);
            }
            if (Start.GetGrandPrixesList()[Index].Name == "Gran Premio Emilia-Romagna")
            {
                this.titleLabel.Location = new Point(this.titleLabel.Location.X + 50, this.Location.Y);
            }
            if (Start.GetGrandPrixesList()[Index].Name == "Saudi Arabian Grand Prix")
            {
                this.titleLabel.Location = new Point(this.titleLabel.Location.X + 25, this.Location.Y);
            }
        }
        private void backLabel_MouseEnter(object sender, EventArgs e)
        {
            this.backLabel.ForeColor = Color.Firebrick;
        }
        private void backLabel_MouseLeave(object sender, EventArgs e)
        {
            this.backLabel.ForeColor = Color.Black;
        }
    }
}
