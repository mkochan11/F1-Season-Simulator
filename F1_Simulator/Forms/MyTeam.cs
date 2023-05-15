using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace F1_Simulator.Forms
{
    partial class MyTeam : UserControl
    {
        Start Start;

        public MyTeam()
        {
            InitializeComponent();
        }

        public void Initialize(Start start)
        {
            this.Start = start;
            this.titleLabel.Text = Start.GetPlayerTeam().Name + " Details";
            this.clickBudgetLabel.Visible = false;
            this.clickUpgradeLabel.Visible = false;
            this.clickBudetLabel1.Visible = false;
            //this.HideCarDropDownLabels();
            //this.budgetHistoryLabel.Hide();

            this.driver1panel.Visible = false;
            this.driver1NameSurnameLabel.Text = Start.GetPlayerTeam().Driver1.Name + " " + Start.GetPlayerTeam().Driver1.Surname;
            this.driver1NumberLabel.Text = "- Number: " + Start.GetPlayerTeam().Driver1.Number;
            this.driver1SkillLabel.Text = "- Skill: " + Start.GetPlayerTeam().Driver1.Skill;
            this.driver1SalaryLabel.Text = "- Race Salary: " + Start.GetPlayerTeam().Driver1.RaceSalary + "$";
            this.driver1PointsLabel.Text = "- Points: " + Start.GetPlayerTeam().Driver1.Points;

            this.driver2panel.Visible = false;
            this.driver2NameSurnameLabel.Text = Start.GetPlayerTeam().Driver2.Name + " " + Start.GetPlayerTeam().Driver2.Surname;
            this.driver2NumberLabel.Text = "- Number: " + Start.GetPlayerTeam().Driver2.Number;
            this.driver2SkillLabel.Text = "- Skill: " + Start.GetPlayerTeam().Driver2.Skill;
            this.driver2SalaryLabel.Text = "- Race Salary: " + Start.GetPlayerTeam().Driver2.RaceSalary + "$";
            this.driver2PointsLabel.Text = "- Points: " + Start.GetPlayerTeam().Driver2.Points;

            this.teamPanel.Visible = false;
            this.teamBudgetLabel.Text = "- Budget: " + Start.GetPlayerTeam().Budget + "$";
            this.teamNameLabel.Text = "- Name: " + Start.GetPlayerTeam().Name;
            this.teamColorBox.BackColor = Start.GetPlayerTeam().Color;
            this.teamPointsLabel.Text = "- Points: " + Start.GetPlayerTeam().Points;

            this.carPanel.Visible = false;
            this.carNameLabel.Text = "- Name: " + Start.GetPlayerTeam().Car.Name;
            this.carWeightLabel.Text = "- Weight: " + Start.GetPlayerTeam().Car.Weight + "kgs";
            this.carWeightReductionCostLabel.Text = "- Weight reduction cost: " + Start.GetPlayerTeam().Car.WeightReductionCost + "$ / 1kg";

            this.frontWingPanel.Visible = false;
            this.fwAeroLabel.Text = "- Aerodynamic Performance: " + Start.GetPlayerTeam().GetFrontWingAeroPerformance() + " pts";
            this.fwCostLabel.Text = "- Cost of improvement: " + Start.GetPlayerTeam().GetFrontWingCostOfImprovement() + "$ /1pt";

            this.rearWingPanel.Visible = false;
            this.rwAeroLabel.Text = "- Aerodynamic Performance: " + Start.GetPlayerTeam().Car.RearWing.GetAeroPerformance() + " pts";
            this.rwCostLabel.Text = "- Cost of improvement: " + Start.GetPlayerTeam().Car.RearWing.GetCostOfImprovement() + "$ /1pt";

            this.chassisPanel.Visible = false;
            this.chassisAeroLabel.Text = "- Aerodynamic Performance: " + Start.GetPlayerTeam().Car.Chassis.GetAeroPerformance() + " pts";
            this.chassisCostLabel.Text = "- Cost of improvement: " + Start.GetPlayerTeam().Car.Chassis.GetCostOfImprovement() + "$ /1pt";

            this.enginePanel.Visible = false;
            this.enginePowerLabel.Text = "- Power: " + Start.GetPlayerTeam().Car.Engine.GetPower() + " hp";
            this.engineReliabilityLabel.Text = "- Reliability: " + Start.GetPlayerTeam().Car.Engine.GetReliability() + "%";
            this.engineCostPowerLabel.Text = "- Cost of power improvement: " + Start.GetPlayerTeam().Car.Engine.GetCostOfPowerImprovement() + "$ /1hp";
            this.engineCostReliabilityLabel.Text = "- Cost of reliability improvement: " + Start.GetPlayerTeam().Car.Engine.GetCostOfReliabilityImprovement() + "$ /1%";

        }

        /*
        private void ShowCarDropDownLabels()
        {
            this.frontWingLabel.Show();
            this.rearWingLabel.Show();
            this.chassisLabel.Show();
            this.engineLabel.Show();
            this.upgradeCarLabel.Show();

        }
        private void HideCarDropDownLabels()
        {
            this.frontWingLabel.Hide();
            this.rearWingLabel.Hide();
            this.chassisLabel.Hide();
            this.engineLabel.Hide();
            this.upgradeCarLabel.Hide();

        }

        private void LowerDropDownLabels()
        {
            
            int frontWingLabelNewY = frontWingLabel.Location.Y + 30;
            int rearWingLabelNewY = rearWingLabel.Location.Y + 30;
            int chassisLabelNewY = chassisLabel.Location.Y + 30;
            int engineLabelNewY = engineLabel.Location.Y + 30;
            int upgradeCarLabelNewY = upgradeCarLabel.Location.Y + 30;
            this.frontWingLabel.Location = new Point(frontWingLabel.Location.X, frontWingLabelNewY);
            this.rearWingLabel.Location = new Point(rearWingLabel.Location.X, rearWingLabelNewY);
            this.chassisLabel.Location = new Point(chassisLabel.Location.X, chassisLabelNewY);
            this.engineLabel.Location = new Point(engineLabel.Location.X, engineLabelNewY);
            this.upgradeCarLabel.Location = new Point(upgradeCarLabel.Location.X, upgradeCarLabelNewY);
        }
        private void HigherDropDownLabels()
        {

            int frontWingLabelNewY = frontWingLabel.Location.Y - 30;
            int rearWingLabelNewY = rearWingLabel.Location.Y - 30;
            int chassisLabelNewY = chassisLabel.Location.Y - 30;
            int engineLabelNewY = engineLabel.Location.Y - 30;
            int upgradeCarLabelNewY = upgradeCarLabel.Location.Y - 30;
            this.frontWingLabel.Location = new Point(frontWingLabel.Location.X, frontWingLabelNewY);
            this.rearWingLabel.Location = new Point(rearWingLabel.Location.X, rearWingLabelNewY);
            this.chassisLabel.Location = new Point(chassisLabel.Location.X, chassisLabelNewY);
            this.engineLabel.Location = new Point(engineLabel.Location.X, engineLabelNewY);
            this.upgradeCarLabel.Location = new Point(upgradeCarLabel.Location.X, upgradeCarLabelNewY);
        }
        */

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

        // Handling Team Label - mouse interaction
        private void teamLabel_MouseEnter(object sender, EventArgs e)
        {
            this.teamLabel.ForeColor = Color.Firebrick;
            this.teamPanel.Visible = true;
            /*
            int driver1LabelNewY = driver1Label.Location.Y + 30;
            int driver2LabelNewY = driver2Label.Location.Y + 30;
            int carLabelNewY = carLabel.Location.Y + 30;
            this.driver1Label.Location = new Point(0, driver1LabelNewY);
            this.driver2Label.Location = new Point(0, driver2LabelNewY);
            this.carLabel.Location = new Point(0, carLabelNewY);
            LowerDropDownLabels();
            this.budgetHistoryLabel.Show();
            */

        }
        private void teamLabel_MouseLeave(object sender, EventArgs e)
        {
            this.teamLabel.ForeColor = Color.Black;
            this.teamPanel.Visible = false;
            /*
            this.budgetHistoryLabel.Hide();
            int driver1LabelNewY = driver1Label.Location.Y - 30;
            int driver2LabelNewY = driver2Label.Location.Y - 30;
            int carLabelNewY = carLabel.Location.Y - 30;
            this.driver1Label.Location = new Point(0, driver1LabelNewY);
            this.driver2Label.Location = new Point(0, driver2LabelNewY);
            this.carLabel.Location = new Point(0, carLabelNewY);
            HigherDropDownLabels();
            */
        }

        /*
        private void teamLabel_Click(object sender, EventArgs e)
        {
            if (!teamLabelClicked)
            {
                this.teamLabel.MouseLeave -= new System.EventHandler(this.teamLabel_MouseLeave);
                this.teamLabel.MouseEnter -= new System.EventHandler(this.teamLabel_MouseEnter);
                this.teamLabelClicked = true;
                this.teamLabel.ForeColor = Color.Black;
                this.teamPanel.Visible = false;
            }
            else
            {
                this.teamLabel.MouseLeave += new System.EventHandler(this.teamLabel_MouseLeave);
                this.teamLabel.MouseEnter += new System.EventHandler(this.teamLabel_MouseEnter);
                this.teamLabelClicked = false;
                this.teamPanel.Visible = true;
            }
        }
        */


        //Handling Budget History Label - mouse interaction
        private void budgetHistoryLabel_MouseEnter(object sender, EventArgs e)
        {
            this.budgetHistoryLabel.ForeColor = Color.Firebrick;
            this.clickBudgetLabel.Visible = true;
            this.clickBudetLabel1.Show();
        }
        private void budgetHistoryLabel_MouseLeave(object sender, EventArgs e)
        {
            this.budgetHistoryLabel.ForeColor = Color.Black;
            this.clickBudgetLabel.Visible = false;
            this.clickBudetLabel1.Hide();
        }
        private void budgetHistoryLabel_Click(object sender, EventArgs e)
        {
            //this.teamLabel.MouseLeave += new System.EventHandler(this.teamLabel_MouseLeave);
            //this.teamLabel.MouseEnter += new System.EventHandler(this.teamLabel_MouseEnter);
            //this.teamLabelClicked = false;
            this.Start.BudgetHistoryScreen_Load();
            this.Hide();
            /*
            int driver1LabelNewY = driver1Label.Location.Y - 30;
            int driver2LabelNewY = driver2Label.Location.Y - 30;
            int carLabelNewY = carLabel.Location.Y - 30;
            this.driver1Label.Location = new Point(0, driver1LabelNewY);
            this.driver2Label.Location = new Point(0, driver2LabelNewY);
            this.carLabel.Location = new Point(0, carLabelNewY);
            this.Hide();
            if (carLabelClicked)
            {
                HigherDropDownLabels();
                carLabelClicked = false;
                this.carLabel.MouseLeave += new System.EventHandler(this.carLabel_MouseLeave);
                this.carLabel.MouseEnter += new System.EventHandler(this.carLabel_MouseEnter);
            }
            */
        }


        //Handling Driver1 label - mouse interaction
        private void driver1Label_MouseEnter(object sender, EventArgs e)
        {
            this.driver1Label.ForeColor = Color.Firebrick;
            this.driver1panel.Visible = true;
        }
        private void driver1Label_MouseLeave(object sender, EventArgs e)
        {
            this.driver1Label.ForeColor = Color.Black;
            this.driver1panel.Visible = false;
        }

        //Handling Driver2 label - mouse interaction
        private void driver2Label_MouseEnter(object sender, EventArgs e)
        {
            this.driver2Label.ForeColor = Color.Firebrick;
            this.driver2panel.Visible = true;
        }
        private void driver2Label_MouseLeave(object sender, EventArgs e)
        {
            this.driver2Label.ForeColor = Color.Black;
            this.driver2panel.Visible = false;
        }

        //Handling Car label - mouse interaction
        private void carLabel_MouseEnter(object sender, EventArgs e)
        {
            this.carLabel.ForeColor = Color.Firebrick;
            this.carPanel.Visible = true;
            //this.ShowCarDropDownLabels();
        }
        private void carLabel_MouseLeave(object sender, EventArgs e)
        {
            this.carLabel.ForeColor = Color.Black;
            this.carPanel.Visible = false;
            //this.HideCarDropDownLabels();
        }
        /*
        private void carLabel_Click(object sender, EventArgs e)
        {
            if (!carLabelClicked)
            {
                this.carLabel.MouseLeave -= new System.EventHandler(this.carLabel_MouseLeave);
                this.carLabel.MouseEnter -= new System.EventHandler(this.carLabel_MouseEnter);
                this.carLabelClicked = true;
                this.carLabel.ForeColor = Color.Black;
                this.carPanel.Visible = false;
            }
            else
            {
                this.carLabel.MouseLeave += new System.EventHandler(this.carLabel_MouseLeave);
                this.carLabel.MouseEnter += new System.EventHandler(this.carLabel_MouseEnter);
                this.carLabelClicked = false;
                this.carPanel.Visible = true;
            }

        }
        */

        //Handling Front Wing label - mouse interaction
        private void frontWingLabel_MouseEnter(Object sender, EventArgs e)
        {
            this.frontWingLabel.ForeColor = Color.Firebrick;
            this.frontWingPanel.Visible = true;
        }

        private void frontWingLabel_MouseLeave(Object sender, EventArgs e)
        {
            this.frontWingLabel.ForeColor = Color.Black;
            this.frontWingPanel.Visible = false;
        }

        //Handling Rear Wing label - mouse interaction
        private void rearWingLabel_MouseEnter(Object sender, EventArgs e)
        {
            this.rearWingLabel.ForeColor = Color.Firebrick;
            this.rearWingPanel.Visible = true;
        }

        private void rearWingLabel_MouseLeave(Object sender, EventArgs e)
        {
            this.rearWingLabel.ForeColor = Color.Black;
            this.rearWingPanel.Visible = false;
        }

        //Handling Chassis label - mouse interaction
        private void chassisLabel_MouseLeave(object sender, EventArgs e)
        {
            this.chassisLabel.ForeColor = Color.Black;
            this.chassisPanel.Visible = false;
        }

        private void chassisLabel_MouseEnter(object sender, EventArgs e)
        {
            this.chassisLabel.ForeColor = Color.Firebrick;
            this.chassisPanel.Visible = true;
        }

        //Handling Engine label - mouse interaction
        private void engineLabel_MouseLeave(object sender, EventArgs e)
        {
            this.engineLabel.ForeColor = Color.Black;
            this.enginePanel.Visible = false;
        }

        private void engineLabel_MouseEnter(object sender, EventArgs e)
        {
            this.engineLabel.ForeColor = Color.Firebrick;
            this.enginePanel.Visible = true;
        }

        //Handling Upgrade Car label - mouse interaction
        private void upgradeCarLabel_Click(object sender, EventArgs e)
        {
            this.Start.UpgradeScreen_Load();
            //this.carLabel.MouseLeave += new System.EventHandler(this.carLabel_MouseLeave);
            //this.carLabel.MouseEnter += new System.EventHandler(this.carLabel_MouseEnter);
            //this.carLabelClicked = false;
            //this.carPanel.Visible = true;
            this.Hide();
        }

        private void upgradeCarLabel_MouseEnter(object sender, EventArgs e)
        {
            this.upgradeCarLabel.ForeColor = Color.Firebrick;
            this.clickUpgradeLabel.Visible = true;
        }
        private void upgradeCarLabel_MouseLeave(object sender, EventArgs e)
        {
            this.upgradeCarLabel.ForeColor = Color.Black;
            this.clickUpgradeLabel.Visible = false;
        }


    }
}
