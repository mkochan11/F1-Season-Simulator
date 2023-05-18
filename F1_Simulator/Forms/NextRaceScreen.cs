using F1_Simulator.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace F1_Simulator.Forms
{
     partial class NextRaceScreen : UserControl
    {
        public NextRaceScreen()
        {
            InitializeComponent();
        }
        Start Start;
        int Index;
        GrandPrix grandPrix;
        public void Initialize(Start start)
        {
            this.Start = start;
            this.Index = Start.controller.Season.RaceWeek - 1;
            this.grandPrix = Start.GetGrandPrixesList()[Index];

            this.gpLabel.Text = grandPrix.Name;
            this.flagImage.Image = grandPrix.Flag;
            this.circuitLayoutImage.Image = grandPrix.Circuit.Layout;
        }

        private void backLabel_Click(object sender, EventArgs e)
        {
            this.Start.MainMenuScreen_Load();
            this.Hide();
        }
        private void backLabel_MouseEnter(object sender, EventArgs e)
        {
            this.backLabel.ForeColor = Color.Firebrick;
        }
        private void backLabel_MouseLeave(object sender, EventArgs e)
        {
            this.backLabel.ForeColor = Color.Black;
        }

        private void simulateLabel_MouseEnter(object sender, EventArgs e)
        {
            this.simulateLabel.ForeColor = Color.Firebrick;
        }
        private void simulateLabel_MouseLeave(object sender, EventArgs e)
        {
            this.simulateLabel.ForeColor = Color.Black;
        }

        private void gpDetailsLabel_MouseEnter(object sender, EventArgs e)
        {
            this.gpDetailsLabel.ForeColor = Color.Firebrick;
        }
        private void gpDetailsLabel_MouseLeave(object sender, EventArgs e)
        {
            this.gpDetailsLabel.ForeColor = Color.Black;
        }
        private void gpDetailsLabel_Click(object sender, EventArgs e)
        {
            Start.GPDetailsScreen_Load(this.Index, "nextRace");
            this.Hide();
        }
    }
}
