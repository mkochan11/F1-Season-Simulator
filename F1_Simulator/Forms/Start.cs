using F1_Simulator.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace F1_Simulator.Forms
{
    partial class Start : Form
    {
        public Controller controller;
        public Start()
        {
            InitializeComponent();
            
            startLabel.Visible = true;
            configurationScreen1.Visible = false;
            mainMenu1.Visible = false;
            driversSelection1.Visible = false;
            myTeam1.Visible = false;
            enterNamesScreen1.Visible = false;
            standingsScreen1.Visible = false;
            upgradeScreen1.Visible = false;
            budgetHistoryScreen1.Visible = false;
            calendarScreen1.Visible = false;
            gpDetailsScreen1.Visible = false;

            controller = new Controller();
           
        }

        private void Start_Load(object sender, EventArgs e)
        {

        }

        public void MainMenuScreen_Load()
        {
            mainMenu1.Initialize(this);
            mainMenu1.Show();
        }

        public void DriversSelectionScreen_Load()
        {
            driversSelection1.Initialize(this);
            driversSelection1.Show();
        }

        private void PlayerNameScreen_Load()
        {
            enterNamesScreen1.Initialize(this);
            enterNamesScreen1.Show();

        }

        public void ConfigScreen_Load(string PlayerName)
        {
            configurationScreen1.Initialize(this);
            configurationScreen1.Show();
            
        }

        public void MyTeamScreen_Load()
        {
            myTeam1.Initialize(this);
            myTeam1.Show();
        }

        public void StandingsScreen_Load()
        {
            standingsScreen1.Initialize(this);
            standingsScreen1.Show();
        }

        public void UpgradeScreen_Load()
        {
            upgradeScreen1.Initialize(this);
            upgradeScreen1.Show();
        }

        public void BudgetHistoryScreen_Load()
        {
            budgetHistoryScreen1.Initialize(this);
            budgetHistoryScreen1.Show();
        }

        public void CalendarScreen_Load()
        {
            calendarScreen1.Initialize(this);
            calendarScreen1.Show();
        }

        public void GPDetailsScreen_Load(int index)
        {
            gpDetailsScreen1.Initialize(this, index);
            gpDetailsScreen1.Show();
        }

        private void startLabel_MouseLeave(object sender, EventArgs e)
        {
            this.startLabel.ForeColor = Color.Black;
        }

        private void startLabel_MouseEnter(object sender, EventArgs e)
        {
            this.startLabel.ForeColor = Color.Firebrick;
        }

        private void startLabel_Click(object sender, EventArgs e)
        {
            PlayerNameScreen_Load();
            startLabel.Hide();
        }

        public float GetPlayerTeamBudget()
        {
            return this.controller.Player.Team.Budget;
        }
        
        public List<GrandPrix> GetGrandPrixesList()
        {
            return this.controller.Season.GrandPrixs;
        }

        public List<Driver> GetDriversList()
        {
            return this.controller.Season.Drivers;
        }

        public List<Team> GetTeamsList()
        {
            return this.controller.Season.Teams;
        }

        public Team GetPlayerTeam()
        {
            return this.controller.Player.Team;
        }
    }
    }

