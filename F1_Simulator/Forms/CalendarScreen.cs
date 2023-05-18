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
    partial class CalendarScreen : UserControl
    {
        Start Start { get; set; }
        bool alreadyOpened = false;
        bool selectedRow = false;
        public CalendarScreen()
        {
            InitializeComponent();
        }

        public void Initialize(Start start)
        {
            this.Start = start;
            this.grandPrixsList.Size = new System.Drawing.Size(330, (Start.controller.Season.NumberOfRaces + 1) * 22);
            this.gpResultsLabel.Enabled = false;
            this.gpDetailsLabel.Enabled = false;
            this.selectedRow = false;

            if (!alreadyOpened)
            {
                for (int i = 0; i < Start.GetGrandPrixesList().Count; i++)
                {
                    ListViewItem listViewItem = new ListViewItem(Start.GetGrandPrixesList().ElementAt(i).RaceWeek.ToString());
                    listViewItem.SubItems.Add(Start.GetGrandPrixesList().ElementAt(i).Name);
                    this.grandPrixsList.Items.Add(listViewItem);
                }
                alreadyOpened = true;
            }
        }

        private void backLabel_Click(object sender, EventArgs e)
        {
            this.grandPrixsList.SelectedItems.Clear();
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
            int selectedGP = this.grandPrixsList.SelectedItems[0].Index;
            this.Start.GPDetailsScreen_Load(selectedGP, "calendar");
            this.Hide();
        }


        private void gpResultsLabel_MouseEnter(object sender, EventArgs e)
        {
            this.gpResultsLabel.ForeColor = Color.Firebrick;
        }
        private void gpResultsLabel_MouseLeave(object sender, EventArgs e)
        {
            this.gpResultsLabel.ForeColor = Color.Black;
        }
        private void gpResultsLabel_Click(object sender, EventArgs e)
        {
            int selectedGP = this.grandPrixsList.SelectedItems[0].Index;
            if (this.Start.GetGrandPrixesList().ElementAt(selectedGP).Results == null)
            {
                DialogResult result = MessageBox.Show("This Grand Prix has not yet taken place. No results to display.", "No Results", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void onItemSelectionChanged(object sender, EventArgs e)
        {
            if (!selectedRow)
            {
                this.gpDetailsLabel.Enabled = true;
                this.gpResultsLabel.Enabled = true;
            }
        }


    }
}
