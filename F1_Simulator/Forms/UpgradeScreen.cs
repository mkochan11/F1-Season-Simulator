using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace F1_Simulator.Forms
{
    partial class UpgradeScreen : UserControl
    {
        Start Start { get; set; }
        public UpgradeScreen()
        {
            InitializeComponent();
        }

        public void Initialize(Start start)
        {
            this.Start = start;
            this.budgetLabel.Text = "Budget: " + Start.controller.Player.Team.Budget.ToString() + "$";
            this.titleLabel.Text = "Upgrade " + Start.controller.Player.Team.Car.Name;
            this.frontWingPanel.Visible = false;
            this.rearWingPanel.Visible = false;
            this.chassisPanel.Visible = false;
            this.enginePanel.Visible = false;
            this.weightPanel.Visible = false;
            this.UpdateChassisPanel();
            this.UpdateEnginePanel();
            this.UpdateFrontWingPanel();
            this.UpdateRearWingPanel();
            this.UpdateWeightPanel();
        }

        // Disabling / enabling menu Labels
        void DisableLabels()
        {
            this.frontWingLabel.Enabled = false;
            this.rearWingLabel.Enabled = false;
            this.chassisLabel.Enabled = false;
            this.engineLabel.Enabled = false;
            this.backLabel.Enabled = false;
            this.weightLabel.Enabled = false;
        }

        void EnableLabels()
        {
            this.frontWingLabel.Enabled = true;
            this.rearWingLabel.Enabled = true;
            this.chassisLabel.Enabled = true;
            this.engineLabel.Enabled = true;
            this.backLabel.Enabled = true;
            this.weightLabel.Enabled = true;
        }

        // Updating Budget Label
        void UpdateBudget()
        {
            this.budgetLabel.Text = "Budget: " + Start.controller.Player.Team.Budget.ToString() + "$";
        }

        // Updating Panels
        void UpdateFrontWingPanel()
        {
            this.FWcostTextBox.Text = "0";
            this.FWcurrentAeroPerformanceLabel.Text = "Current Aero Performance: " + Start.controller.Player.Team.Car.FrontWing.GetAeroPerformance().ToString() + "pts";
            this.FWupgradePointsNumeric.Value = 0;
            this.FWCostExceedingLabel.Hide();
        }
        void UpdateRearWingPanel() 
        {
            this.RWcostTextBox.Text = "0";
            this.RWcurrentAeroPerformanceLabel.Text = "Current Aero Performance: " + Start.controller.Player.Team.Car.RearWing.GetAeroPerformance().ToString() + "pts";
            this.RWupgradePointsNumeric.Value = 0;
        }
        void UpdateChassisPanel()
        {
            this.chassisCostTextBox.Text = "0";
            this.chassisCurrentAeroPerformanceLabel.Text = "Current Aero Performance: " + Start.controller.Player.Team.Car.Chassis.GetAeroPerformance().ToString() + "pts";
            this.chassisUpgradePointsNumeric.Value = 0;
        }
        void UpdateEnginePanel()
        {
            this.engineCostTextBox.Text = "0";
            this.engineCurrentPowerLabel.Text = "Current Power: " + Start.controller.Player.Team.Car.Engine.GetPower().ToString() + "HP";
            this.engineCurrentReliabilityLabel.Text = "Current Reliability: " + Start.controller.Player.Team.Car.Engine.GetReliability().ToString() + "%";
            this.engineReliabilityUpgradePointsNumeric.Value = 0;
            this.enginePowerUpgradePointsNumeric.Value = 0;
        }
        void UpdateWeightPanel()
        {
            this.weightCostTextBox.Text = "0";
            this.weightCurrentWeightLabel.Text = "Current Weight: " + Start.controller.Player.Team.Car.Weight.ToString() + "kgs";
            this.weightReduceNumeric.Value = 0;
        }

        // Handling Front Wing Label - mouse interaction
        void frontWingLabel_MouseEnter(object sender, EventArgs e)
        {
            this.frontWingLabel.ForeColor = Color.Firebrick;
        }
        void frontWingLabel_MouseLeave(object sender, EventArgs e)
        {
            this.frontWingLabel.ForeColor = Color.Black;
        }
        void frontWingLabel_Click(object sender, EventArgs e)
        {
            this.frontWingPanel.Show();
            this.FWCostExceedingLabel.Hide();
            DisableLabels();            
        }

        // Handling Rear Wing Label - mouse interaction
        void rearWingLabel_MouseEnter(object sender, EventArgs e)
        {
            this.rearWingLabel.ForeColor = Color.Firebrick;
        }
        void rearWingLabel_MouseLeave(object sender, EventArgs e)
        {
            this.rearWingLabel.ForeColor = Color.Black;
        }
        void rearWingLabel_Click(object sender, EventArgs e)
        {
            this.rearWingPanel.Show();
            this.RWCostExceedingLabel.Hide();
            DisableLabels();
        }

        // Handling Chassis Label - mouse interaction
        void chassisLabel_MouseEnter(object sender, EventArgs e)
        {
            this.chassisLabel.ForeColor = Color.Firebrick;
        }
        void chassisLabel_MouseLeave(object sender, EventArgs e)
        {
            this.chassisLabel.ForeColor = Color.Black;
        }
        void chassisLabel_Click(object sender, EventArgs e)
        {
            this.chassisPanel.Show();
            this.chassisCostExceedingLabel.Hide();
            DisableLabels();
        }

        // Handling Engine Label - mouse interaction
        void engineLabel_MouseEnter(object sender, EventArgs e)
        {
            this.engineLabel.ForeColor = Color.Firebrick;
        }
        void engineLabel_MouseLeave(object sender, EventArgs e)
        {
            this.engineLabel.ForeColor = Color.Black;
        }
        void engineLabel_Click(object sender, EventArgs e)
        {
            this.enginePanel.Show();
            this.engineCostExceedingLabel.Hide();
            DisableLabels();
        }

        //Handling Weight Label - mouse interaction
        void weightLabel_MouseEnter(object sender, EventArgs e)
        {
            this.weightLabel.ForeColor = Color.Firebrick;
        }
        void weightLabel_MouseLeave(object sender, EventArgs e)
        {
            this.weightLabel.ForeColor = Color.Black;
        }
        void weightLabel_Click(object sender, EventArgs e)
        {
            this.weightPanel.Show();
            this.weightCostExceedingLabel.Hide();
            DisableLabels();
        }

        // Handling Back Label - mouse interaction
        void backLabel_MouseEnter(object sender, EventArgs e)
        {
            this.backLabel.ForeColor = Color.Firebrick;
        }
        void backLabel_MouseLeave(object sender, EventArgs e)
        {
            this.backLabel.ForeColor = Color.Black;
        }
        void backLabel_Click(object sender, EventArgs e)
        {
            Start.MyTeamScreen_Load();
            //Start.BudgetHistoryScreen_Refresh();
            this.Hide();
        }

        // Handling Front Wing OK Label - mouse interaction
        void FWOkLabel_Click(object sender, EventArgs e)
        {

            // checking if Player wants to upgrade Part
            if (FWcostTextBox.Text != "0")
            {
                float cost = float.Parse(this.FWcostTextBox.Text, CultureInfo.InvariantCulture.NumberFormat);
                //checking if upgrade cost is higher than Players Budget
                if (cost > Start.GetPlayerTeamBudget())
                {
                    this.FWCostExceedingLabel.Show();
                }
                else
                {
                    this.Start.controller.SpendPlayersMoney(cost);
                    UpdateBudget();
                    this.Start.controller.Player.Team.BudgetHistory.Add(new Classes.BudgetHistory("- " + cost.ToString(), "Front Wing upgrade (" + this.FWupgradePointsNumeric.Value + "pts)", this.Start.controller.Season.RaceWeek));
                    this.Start.controller.Player.Team.Car.FrontWing.UpgradeAeroPerformance((int)FWupgradePointsNumeric.Value);
                    this.UpdateFrontWingPanel();
                    this.frontWingPanel.Hide();
                    EnableLabels();
                }
            }
            else
            {
                this.frontWingPanel.Hide();
                EnableLabels();
            }
        }
        void FWOkLabel_MouseEnter(object sender, EventArgs e)
        {
            this.FWOkLabel.ForeColor = Color.Firebrick;
        }
        void FWOkLabel_MouseLeave(object sender, EventArgs e)
        {
            this.FWOkLabel.ForeColor = Color.Black;
        }

        // Handling Rear Wing OK Label - mouse interaction
        void RWOkLabel_Click(object sender, EventArgs e)
        {
            // checking if Player wants to upgrade Part
            if (RWcostTextBox.Text != "0")
            {
                float cost = float.Parse(this.RWcostTextBox.Text, CultureInfo.InvariantCulture.NumberFormat);
                //checking if upgrade cost is higher than Players Budget
                if (cost > Start.GetPlayerTeamBudget())
                {
                    this.RWCostExceedingLabel.Show();
                }
                else
                {
                    this.Start.controller.SpendPlayersMoney(cost);
                    UpdateBudget();
                    this.Start.controller.Player.Team.BudgetHistory.Add(new Classes.BudgetHistory("- " + cost.ToString(), "Rear Wing upgrade (" + this.RWupgradePointsNumeric.Value + "pts)", this.Start.controller.Season.RaceWeek));
                    this.Start.controller.Player.Team.Car.RearWing.UpgradeAeroPerformance((int)RWupgradePointsNumeric.Value);
                    this.UpdateRearWingPanel();
                    this.rearWingPanel.Hide();
                    EnableLabels();
                }
            }
            else
            {
                this.rearWingPanel.Hide();
                EnableLabels();
            }
        }
        void RWOkLabel_MouseEnter(object sender, EventArgs e)
        {
            this.RWOkLabel.ForeColor = Color.Firebrick;
        }
        void RWOkLabel_MouseLeave(object sender, EventArgs e)
        {
            this.RWOkLabel.ForeColor = Color.Black;
        }

        // Handling Chassis OK Label - mouse interaction
        void ChassisOkLabel_Click(object sender, EventArgs e)
        {
            
            // checking if Player wants to upgrade Part
            if (chassisCostTextBox.Text != "0")
            {
                float cost = float.Parse(this.chassisCostTextBox.Text, CultureInfo.InvariantCulture.NumberFormat);
                //checking if upgrade cost is higher than Players Budget
                if (cost > Start.GetPlayerTeamBudget())
                {
                    this.chassisCostExceedingLabel.Show();
                }
                else
                {
                    this.Start.controller.SpendPlayersMoney(cost);
                    UpdateBudget();
                    this.Start.controller.Player.Team.BudgetHistory.Add(new Classes.BudgetHistory("- " + cost.ToString(), "Chassis upgrade (" + this.chassisUpgradePointsNumeric.Value + "pts)", this.Start.controller.Season.RaceWeek));
                    this.Start.controller.Player.Team.Car.Chassis.UpgradeAeroPerformance((int)chassisUpgradePointsNumeric.Value);
                    this.UpdateChassisPanel();
                    this.chassisPanel.Hide();
                    EnableLabels();
                }
            }
            else
            {
                this.chassisPanel.Hide();
                EnableLabels();
            }
        }
        void ChassisOkLabel_MouseEnter(object sender, EventArgs e)
        {
            this.chassisOkLabel.ForeColor = Color.Firebrick;
        }
        void ChassisOkLabel_MouseLeave(object sender, EventArgs e)
        {
            this.chassisOkLabel.ForeColor = Color.Black;
        }

        // Handling Engine OK Label - mouse interaction
        void EngineOkLabel_Click(object sender, EventArgs e)
        {
            // checking if Player wants to upgrade Part
            if (engineCostTextBox.Text != "0")
            {
                float cost = float.Parse(this.engineCostTextBox.Text, CultureInfo.InvariantCulture.NumberFormat);
                float powerCost = this.Start.controller.Player.Team.Car.Engine.GetCostOfPowerImprovement() * (float)this.enginePowerUpgradePointsNumeric.Value;
                float reliabilityCost = this.Start.controller.Player.Team.Car.Engine.GetCostOfReliabilityImprovement() * (float)this.engineReliabilityUpgradePointsNumeric.Value;

                //checking if upgrade cost is higher than Players Budget
                if (cost > Start.GetPlayerTeamBudget())
                {
                    this.engineCostExceedingLabel.Show();
                }
                else
                {

                    this.Start.controller.SpendPlayersMoney(cost);
                    UpdateBudget();

                    if (this.enginePowerUpgradePointsNumeric.Value > 0) 
                    {
                        this.Start.controller.Player.Team.BudgetHistory.Add(new Classes.BudgetHistory("- " + powerCost.ToString(), "Engine Power upgrade (" + this.enginePowerUpgradePointsNumeric.Value + " HP)", this.Start.controller.Season.RaceWeek));
                        this.Start.controller.Player.Team.Car.Engine.UpgradePower((int)enginePowerUpgradePointsNumeric.Value);
                    }
                    if(this.engineReliabilityUpgradePointsNumeric.Value > 0)
                    {
                        this.Start.controller.Player.Team.BudgetHistory.Add(new Classes.BudgetHistory("- " + reliabilityCost.ToString(), "Engine Reliability upgrade (" + this.engineReliabilityUpgradePointsNumeric.Value + "%)", this.Start.controller.Season.RaceWeek));
                        this.Start.controller.Player.Team.Car.Engine.UpgradeReliability((int)engineReliabilityUpgradePointsNumeric.Value);
                    }
                    
                    this.UpdateEnginePanel();
                    this.enginePanel.Hide();
                    EnableLabels();
                }
            }
            else
            {
                this.enginePanel.Hide();
                EnableLabels();
            }
        }
        void EngineOkLabel_MouseEnter(object sender, EventArgs e)
        {
            this.engineOkLabel.ForeColor = Color.Firebrick;
        }
        void EngineOkLabel_MouseLeave(object sender, EventArgs e)
        {
            this.engineOkLabel.ForeColor = Color.Black;
        }

        // Handling Weight OK Label - mouse interaction
        void WeightOkLabel_Click(object sender, EventArgs e)
        {

            // checking if Player wants to upgrade Part
            if (weightCostTextBox.Text != "0")
            {
                float cost = float.Parse(this.weightCostTextBox.Text, CultureInfo.InvariantCulture.NumberFormat);
                //checking if upgrade cost is higher than Players Budget
                if (cost > Start.GetPlayerTeamBudget())
                {
                    this.weightCostExceedingLabel.Show();
                }
                else
                {
                    this.Start.controller.SpendPlayersMoney(cost);
                    UpdateBudget();
                    this.Start.controller.Player.Team.BudgetHistory.Add(new Classes.BudgetHistory("- " + cost.ToString(), "Weight Reduce (" + this.weightReduceNumeric.Value + "kgs)", this.Start.controller.Season.RaceWeek));
                    this.Start.controller.Player.Team.Car.ReduceWeight((float)weightReduceNumeric.Value);
                    this.UpdateWeightPanel();
                    this.weightPanel.Hide();
                    EnableLabels();
                }
            }
            else
            {
                this.weightPanel.Hide();
                EnableLabels();
            }
        }
        void WeightOkLabel_MouseEnter(object sender, EventArgs e)
        {
            this.weightOkLabel.ForeColor = Color.Firebrick;
        }
        void WeightOkLabel_MouseLeave(object sender, EventArgs e)
        {
            this.weightOkLabel.ForeColor = Color.Black;
        }

        // Handling Front Wing NumericUpDown Value change
        private void FWupgradePointsNumeric_ValueChanged(object sender, EventArgs e)
        {
            this.FWcostTextBox.Text = ((float)FWupgradePointsNumeric.Value * Start.controller.Player.Team.Car.FrontWing.GetCostOfImprovement()).ToString();
        }

        // Handling Rear Wing NumericUpDown Value change
        private void RWupgradePointsNumeric_ValueChanged(object sender, EventArgs e)
        {
            this.RWcostTextBox.Text = ((float)RWupgradePointsNumeric.Value * Start.controller.Player.Team.Car.RearWing.GetCostOfImprovement()).ToString();
        }

        // Handling Chassis NumericUpDown Value change
        private void ChassisUpgradePointsNumeric_ValueChanged(object sender, EventArgs e)
        {
            this.chassisCostTextBox.Text = ((float)chassisUpgradePointsNumeric.Value * Start.controller.Player.Team.Car.Chassis.GetCostOfImprovement()).ToString();
        }

        // Handling Engine NumericUpDown Value change
        private void EngineUpgradePointsNumeric_ValueChanged(object sender, EventArgs e)
        {
            this.engineCostTextBox.Text = (((float)enginePowerUpgradePointsNumeric.Value * Start.controller.Player.Team.Car.Engine.GetCostOfPowerImprovement()) + ((float)engineReliabilityUpgradePointsNumeric.Value * Start.controller.Player.Team.Car.Engine.GetCostOfReliabilityImprovement())).ToString();
        }

        // Handling Weight NumericUpDown Value change
        private void WeightReduceNumeric_ValueChanged(object sender, EventArgs e)
        {
            this.weightCostTextBox.Text = ((float)weightReduceNumeric.Value * Start.controller.Player.Team.Car.WeightReductionCost).ToString();
        }

    }
}
