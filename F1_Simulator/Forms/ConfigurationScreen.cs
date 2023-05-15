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
    partial class ConfigurationScreen : UserControl
    {
        public Start Start;
        bool colorChosen = false;
        public ConfigurationScreen()
        {
            InitializeComponent();

        }

        public void Initialize(Start start)
        {
            this.Start = start;
            labelColorNotChosen.Hide();
            this.labelWelcome.Text = "Hi " + Start.controller.Player.Name + "!\nChoose your preferences:";
        }

        private void buttonChooseColour_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            colorChosen = true;            
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            if(colorChosen == false)
            {
                labelColorNotChosen.Show();
            }
            else
            {
                this.Start.controller.updatePlayersTeamColor(colorDialog1.Color);
                this.Start.controller.Season = new Season(this.Start.controller.Date.Year, (int)numericNoRaces.Value);
                this.Start.DriversSelectionScreen_Load();
                this.Hide();
            }
        }

        private void okLabel_Click(object sender, EventArgs e)
        {
            if (colorChosen == false)
            {
                labelColorNotChosen.Show();
            }
            else
            {
                this.Start.controller.updatePlayersTeamColor(colorDialog1.Color);
                this.Start.controller.Season = new Season(this.Start.controller.Date.Year, (int)numericNoRaces.Value);
                this.Start.controller.Season.Teams.Add(this.Start.controller.Player.Team);
                this.Start.controller.Season.GenerateGrandPrixs();
                this.Start.DriversSelectionScreen_Load();
                this.Hide();
            }
        }

        private void okLabel_MouseLeave(object sender, EventArgs e)
        {
            this.okLabel.ForeColor = Color.Black;
        }

        private void okLabel_MouseEnter(object sender, EventArgs e)
        {
            this.okLabel.ForeColor = Color.Firebrick;
        }
    }
}
