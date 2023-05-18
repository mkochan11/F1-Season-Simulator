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
    partial class MainMenu : UserControl
    {

        Start Start;
        public MainMenu()
        {
            InitializeComponent();           
        }

        public void Initialize(Start start)
        {
            this.Start = start;
            this.labelRaceWeek.Text = "Race week " + Start.controller.Season.RaceWeek.ToString() + "/" + Start.controller.Season.NumberOfRaces.ToString();
        }

        // Menu Labels mouse interaction handling
        private void MyTeamLabel_MouseEnter(object sender,  EventArgs e) {
             myTeamLabel.ForeColor = Color.Firebrick;
        }
        private void MyTeamLabel_MouseLeave(object sender, EventArgs e) {
            myTeamLabel.ForeColor = Color.Black;
        }
        private void standingsLabel_MouseEnter(object sender, EventArgs e)
        {
            standingsLabel.ForeColor = Color.Firebrick;
        }
        private void standingsLabel_MouseLeave(object sender, EventArgs e)
        {
            standingsLabel.ForeColor = Color.Black;
        }
        private void calendarLabel_MouseEnter(object sender, EventArgs e)
        {
            calendarLabel.ForeColor = Color.Firebrick;
        }
        private void calendarLabel_MouseLeave(object sender, EventArgs e)
        {
            calendarLabel.ForeColor = Color.Black;
        }
        private void nextRaceLabel_MouseEnter(object sender, EventArgs e)
        {
            nextRaceLabel.ForeColor = Color.Firebrick;
        }
        private void nextRaceLabel_MouseLeave(object sender, EventArgs e)
        {
            nextRaceLabel.ForeColor = Color.Black;
        }

        private void labelMyTeam_Click(object sender, EventArgs e)
        {
            Start.MyTeamScreen_Load();
            this.Hide();
        }

        private void standingsLabel_Click(object sender, EventArgs e)
        {
            Start.StandingsScreen_Load();
            this.Hide();

        }

        private void calendarLabel_Click(object sender, EventArgs e)
        {
            Start.CalendarScreen_Load();
            this.Hide();
        }

        private void nextRaceLabel_Click(object sender, EventArgs e)
        {
            Start.NextRaceScreen_Load();
            this.Hide();
        }
    }
}
