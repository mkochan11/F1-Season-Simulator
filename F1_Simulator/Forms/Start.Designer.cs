using System;

namespace F1_Simulator.Forms
{
    partial class Start
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Start));
            this.startLabel = new System.Windows.Forms.Label();
            this.myTeam1 = new F1_Simulator.Forms.MyTeam();
            this.driversSelection1 = new F1_Simulator.Forms.DriversSelection();
            this.mainMenu1 = new F1_Simulator.Forms.MainMenu();
            this.configurationScreen1 = new F1_Simulator.Forms.ConfigurationScreen();
            this.enterNamesScreen1 = new F1_Simulator.Forms.EnterNamesScreen();
            this.standingsScreen1 = new F1_Simulator.Forms.StandingsScreen();
            this.upgradeScreen1 = new F1_Simulator.Forms.UpgradeScreen();
            this.budgetHistoryScreen1 = new F1_Simulator.Forms.BudgetHistoryScreen();
            this.calendarScreen1 = new F1_Simulator.Forms.CalendarScreen();
            this.gpDetailsScreen1 = new F1_Simulator.Forms.GPDetailsScreen();
            this.nextRaceScreen1 = new F1_Simulator.Forms.NextRaceScreen();
            this.SuspendLayout();
            // 
            // startLabel
            // 
            this.startLabel.AutoSize = true;
            this.startLabel.BackColor = System.Drawing.Color.Transparent;
            this.startLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.startLabel.Font = new System.Drawing.Font("PenultimateLightItal", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startLabel.ForeColor = System.Drawing.Color.Black;
            this.startLabel.Location = new System.Drawing.Point(398, 255);
            this.startLabel.Name = "startLabel";
            this.startLabel.Size = new System.Drawing.Size(91, 41);
            this.startLabel.TabIndex = 16;
            this.startLabel.Text = "Start";
            this.startLabel.Click += new System.EventHandler(this.startLabel_Click);
            this.startLabel.MouseEnter += new System.EventHandler(this.startLabel_MouseEnter);
            this.startLabel.MouseLeave += new System.EventHandler(this.startLabel_MouseLeave);
            // 
            // myTeam1
            // 
            this.myTeam1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("myTeam1.BackgroundImage")));
            this.myTeam1.Location = new System.Drawing.Point(0, 0);
            this.myTeam1.Margin = new System.Windows.Forms.Padding(4);
            this.myTeam1.Name = "myTeam1";
            this.myTeam1.Size = new System.Drawing.Size(888, 559);
            this.myTeam1.TabIndex = 14;
            // 
            // driversSelection1
            // 
            this.driversSelection1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("driversSelection1.BackgroundImage")));
            this.driversSelection1.Location = new System.Drawing.Point(0, 0);
            this.driversSelection1.Margin = new System.Windows.Forms.Padding(4);
            this.driversSelection1.Name = "driversSelection1";
            this.driversSelection1.Size = new System.Drawing.Size(888, 559);
            this.driversSelection1.TabIndex = 11;
            // 
            // mainMenu1
            // 
            this.mainMenu1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("mainMenu1.BackgroundImage")));
            this.mainMenu1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.mainMenu1.Location = new System.Drawing.Point(0, 0);
            this.mainMenu1.Margin = new System.Windows.Forms.Padding(4);
            this.mainMenu1.Name = "mainMenu1";
            this.mainMenu1.Size = new System.Drawing.Size(888, 559);
            this.mainMenu1.TabIndex = 10;
            // 
            // configurationScreen1
            // 
            this.configurationScreen1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("configurationScreen1.BackgroundImage")));
            this.configurationScreen1.Location = new System.Drawing.Point(0, 0);
            this.configurationScreen1.Margin = new System.Windows.Forms.Padding(4);
            this.configurationScreen1.Name = "configurationScreen1";
            this.configurationScreen1.Size = new System.Drawing.Size(888, 559);
            this.configurationScreen1.TabIndex = 9;
            // 
            // enterNamesScreen1
            // 
            this.enterNamesScreen1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("enterNamesScreen1.BackgroundImage")));
            this.enterNamesScreen1.Location = new System.Drawing.Point(0, 0);
            this.enterNamesScreen1.Margin = new System.Windows.Forms.Padding(4);
            this.enterNamesScreen1.Name = "enterNamesScreen1";
            this.enterNamesScreen1.Size = new System.Drawing.Size(888, 559);
            this.enterNamesScreen1.TabIndex = 15;
            // 
            // standingsScreen1
            // 
            this.standingsScreen1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("standingsScreen1.BackgroundImage")));
            this.standingsScreen1.Location = new System.Drawing.Point(0, 0);
            this.standingsScreen1.Margin = new System.Windows.Forms.Padding(4);
            this.standingsScreen1.Name = "standingsScreen1";
            this.standingsScreen1.Size = new System.Drawing.Size(888, 570);
            this.standingsScreen1.TabIndex = 17;
            // 
            // upgradeScreen1
            // 
            this.upgradeScreen1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("upgradeScreen1.BackgroundImage")));
            this.upgradeScreen1.Location = new System.Drawing.Point(0, 0);
            this.upgradeScreen1.Margin = new System.Windows.Forms.Padding(4);
            this.upgradeScreen1.Name = "upgradeScreen1";
            this.upgradeScreen1.Size = new System.Drawing.Size(888, 570);
            this.upgradeScreen1.TabIndex = 18;
            // 
            // budgetHistoryScreen1
            // 
            this.budgetHistoryScreen1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("budgetHistoryScreen1.BackgroundImage")));
            this.budgetHistoryScreen1.Location = new System.Drawing.Point(0, 0);
            this.budgetHistoryScreen1.Margin = new System.Windows.Forms.Padding(4);
            this.budgetHistoryScreen1.Name = "budgetHistoryScreen1";
            this.budgetHistoryScreen1.Size = new System.Drawing.Size(888, 559);
            this.budgetHistoryScreen1.TabIndex = 19;
            // 
            // calendarScreen1
            // 
            this.calendarScreen1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("calendarScreen1.BackgroundImage")));
            this.calendarScreen1.Location = new System.Drawing.Point(0, 0);
            this.calendarScreen1.Margin = new System.Windows.Forms.Padding(4);
            this.calendarScreen1.Name = "calendarScreen1";
            this.calendarScreen1.Size = new System.Drawing.Size(888, 559);
            this.calendarScreen1.TabIndex = 20;
            // 
            // gpDetailsScreen1
            // 
            this.gpDetailsScreen1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("gpDetailsScreen1.BackgroundImage")));
            this.gpDetailsScreen1.Location = new System.Drawing.Point(0, 0);
            this.gpDetailsScreen1.Margin = new System.Windows.Forms.Padding(4);
            this.gpDetailsScreen1.Name = "gpDetailsScreen1";
            this.gpDetailsScreen1.Size = new System.Drawing.Size(888, 570);
            this.gpDetailsScreen1.TabIndex = 21;
            // 
            // nextRaceScreen1
            // 
            this.nextRaceScreen1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("nextRaceScreen1.BackgroundImage")));
            this.nextRaceScreen1.Location = new System.Drawing.Point(0, 0);
            this.nextRaceScreen1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nextRaceScreen1.Name = "nextRaceScreen1";
            this.nextRaceScreen1.Size = new System.Drawing.Size(888, 570);
            this.nextRaceScreen1.TabIndex = 22;
            // 
            // Start
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::F1_Simulator.Properties.Resources.bg;
            this.ClientSize = new System.Drawing.Size(884, 571);
            this.Controls.Add(this.nextRaceScreen1);
            this.Controls.Add(this.gpDetailsScreen1);
            this.Controls.Add(this.calendarScreen1);
            this.Controls.Add(this.budgetHistoryScreen1);
            this.Controls.Add(this.upgradeScreen1);
            this.Controls.Add(this.standingsScreen1);
            this.Controls.Add(this.startLabel);
            this.Controls.Add(this.myTeam1);
            this.Controls.Add(this.driversSelection1);
            this.Controls.Add(this.mainMenu1);
            this.Controls.Add(this.configurationScreen1);
            this.Controls.Add(this.enterNamesScreen1);
            this.Font = new System.Drawing.Font("PenultimateLightItal", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Start";
            this.Text = "F1 Season Simulator";
            this.Load += new System.EventHandler(this.Start_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }



        #endregion
        private ConfigurationScreen configurationScreen1;
        private MainMenu mainMenu1;
        private DriversSelection driversSelection1;
        private MyTeam myTeam1;
        private EnterNamesScreen enterNamesScreen1;
        private System.Windows.Forms.Label startLabel;
        private StandingsScreen standingsScreen1;
        private UpgradeScreen upgradeScreen1;
        private BudgetHistoryScreen budgetHistoryScreen1;
        private CalendarScreen calendarScreen1;
        private GPDetailsScreen gpDetailsScreen1;
        private NextRaceScreen nextRaceScreen1;
    }
}