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
    partial class EnterNamesScreen : UserControl
    {
        Start Start { get; set; }
        public EnterNamesScreen()
        {
            InitializeComponent();
        }

        public void Initialize(Start start)
        {
            this.labelEmptyName.Hide();
            this.Start = start;
        }

        private void okLabel_Click(object sender, EventArgs e)
        {
            if (textBoxPlayerName.Text == "" || textBoxTeamName.Text == "" || carNameTextBox.Text == "")
            {
                labelEmptyName.Visible = true;
            }
            else
            {
                this.Start.controller.CreatePlayer(this.textBoxPlayerName.Text, this.textBoxTeamName.Text, this.carNameTextBox.Text);
                Start.ConfigScreen_Load(textBoxPlayerName.Text);
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
