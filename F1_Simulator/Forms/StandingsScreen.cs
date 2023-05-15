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
    partial class StandingsScreen : UserControl
    {
        Start Start;
        bool alreadyOpened = false;
        public StandingsScreen()
        {
            InitializeComponent();
        }

        public void Initialize(Start start)
        {
            this.Start = start;
            this.Start.GetDriversList().Sort((x, y) => y.Points.CompareTo(x.Points));

            for(int i = 0; i < Start.GetDriversList().Count; i++) 
            {
                Start.GetDriversList()[i].Position = i + 1 + ".";
            }


            foreach (Team team in Start.GetTeamsList())
            {
                team.updatePoints();
            }
            this.Start.GetTeamsList().Sort((x, y) => y.Points.CompareTo(x.Points));
            for (int i = 0; i < Start.GetTeamsList().Count; i++)
            {
                Start.GetTeamsList()[i].Position = i + 1 + ".";
            }

            if (!alreadyOpened)
            {
                for (int i = 0; i < Start.GetDriversList().Count; i++)
                {
                    ListViewItem driversListViewItem = new ListViewItem(Start.GetDriversList().ElementAt(i).Position.ToString());
                    driversListViewItem.SubItems.Add(Start.GetDriversList().ElementAt(i).NameSurname);
                    driversListViewItem.SubItems.Add(Start.GetDriversList().ElementAt(i).Team);
                    driversListViewItem.SubItems.Add(Start.GetDriversList().ElementAt(i).Points.ToString());

                    this.driversStandingsList.Items.Add(driversListViewItem);
                }

                for(int j = 0; j < Start.GetTeamsList().Count; j++)
                {
                    ListViewItem teamsListViewItem = new ListViewItem(Start.GetTeamsList().ElementAt(j).Position.ToString());
                    teamsListViewItem.SubItems.Add(Start.GetTeamsList()[j].Name);
                    teamsListViewItem.SubItems.Add(Start.GetTeamsList()[j].Points.ToString());

                    this.teamsStandingsList.Items.Add(teamsListViewItem);
                }
                alreadyOpened = true;
            }


            this.teamsStandingsList.Visible = false;
            this.driversStandingsList.Visible = false;

        }

        private void driversLabel_Click(object sender, EventArgs e)
        {
            this.teamsStandingsList.Visible = false;
            this.driversStandingsList.Visible = true;
        }
        private void driversLabel_MouseEnter(object sender, EventArgs e)
        {
            this.driversLabel.ForeColor = Color.Firebrick;
        }
        private void driversLabel_MouseLeave(object sender, EventArgs e)
        {
            this.driversLabel.ForeColor = Color.Black;
        }


        private void teamsLabel_Click(object sender, EventArgs e)
        {
            this.teamsStandingsList.Visible = true;
            this.driversStandingsList.Visible = false;
        }
        private void teamsLabel_MouseEnter(object sender, EventArgs e)
        {
            this.teamsLabel.ForeColor = Color.Firebrick;
        }
        private void teamsLabel_MouseLeave(object sender, EventArgs e)
        {
            this.teamsLabel.ForeColor = Color.Black;
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

    }
}
