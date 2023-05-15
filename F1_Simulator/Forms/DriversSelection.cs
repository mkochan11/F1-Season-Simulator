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
    partial class DriversSelection : UserControl
    {

        Start Start;
        public DriversSelection()
        {
            InitializeComponent();
        }

        public void Initialize(Start start)
        {
            this.Start = start;
            BindingSource driversBindingSource = new BindingSource();
            driversBindingSource.DataSource = Start.controller.Season.Drivers;
            this.dataGridView1.DataSource = driversBindingSource;
            this.dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Columns["Abbreviation"].Visible = false;
            this.dataGridView1.Columns["Points"].Visible = false;
            this.dataGridView1.Columns["Team"].Visible = false;
            this.dataGridView1.Columns["NameSurname"].Visible = false;
            this.dataGridView1.Columns["Position"].Visible = false;
            this.dataGridView1.Columns["Color"].Visible = false;
            this.okLabel.Enabled = false;
            
        }

       

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int checkedBoxes = 0;
            dataGridView1.EndEdit();
            foreach(DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells[0].Value is true)
                {
                    checkedBoxes++;
                }
            }
            if (checkedBoxes >= 3) {
                dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = false;
                
                foreach(DataGridViewRow row in dataGridView1.Rows)
                {
                    if (row.Cells[0].Value is false) {
                        row.Cells[0].ReadOnly = true;
                    }
                }
            }
            else if(checkedBoxes == 2)
            {
                this.okLabel.Enabled = true;
            }

            else
            {
                this.okLabel.Enabled = false;
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    row.Cells[0].ReadOnly = false;
                }
            }
        }

        private void okLabel_Click(object sender, EventArgs e)
        {
            List<Driver> driversCopy = new List<Driver>();
            foreach(Driver driver in Start.controller.Season.Drivers)
            {
                driversCopy.Add(driver);
            }
            Driver driver1 = null;
            Driver driver2 = null;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells[0].Value is true)
                {
                    string name = row.Cells[1].Value.ToString();
                    foreach (Driver driver in driversCopy)
                    {
                        if (driver.Name == name)
                        {
                            if (driver1 == null)
                            {
                                driver1 = driver;
                            }
                            else
                            {
                                driver2 = driver;
                            }

                            Start.controller.Player.Team.AssignDriver(driver);
                        }
                    }
                }
            }

            driversCopy.Remove(driver1);
            driversCopy.Remove(driver2);

            Start.controller.Season.GenerateTeams(driversCopy);
            Start.MainMenuScreen_Load();
            this.Hide();
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
