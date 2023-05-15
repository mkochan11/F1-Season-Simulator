using System;

namespace F1_Simulator.Forms
{
    partial class MyTeam
    {
        /// <summary> 
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod wygenerowany przez Projektanta składników

        /// <summary> 
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować 
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.titleLabel = new System.Windows.Forms.Label();
            this.driver1Label = new System.Windows.Forms.Label();
            this.driver2Label = new System.Windows.Forms.Label();
            this.carLabel = new System.Windows.Forms.Label();
            this.backLabel = new System.Windows.Forms.Label();
            this.driver1panel = new System.Windows.Forms.Panel();
            this.driver1PointsLabel = new System.Windows.Forms.Label();
            this.driver1SalaryLabel = new System.Windows.Forms.Label();
            this.driver1SkillLabel = new System.Windows.Forms.Label();
            this.driver1NumberLabel = new System.Windows.Forms.Label();
            this.driver1NameSurnameLabel = new System.Windows.Forms.Label();
            this.frontWingLabel = new System.Windows.Forms.Label();
            this.engineLabel = new System.Windows.Forms.Label();
            this.chassisLabel = new System.Windows.Forms.Label();
            this.rearWingLabel = new System.Windows.Forms.Label();
            this.driver2panel = new System.Windows.Forms.Panel();
            this.driver2PointsLabel = new System.Windows.Forms.Label();
            this.driver2SalaryLabel = new System.Windows.Forms.Label();
            this.driver2SkillLabel = new System.Windows.Forms.Label();
            this.driver2NumberLabel = new System.Windows.Forms.Label();
            this.driver2NameSurnameLabel = new System.Windows.Forms.Label();
            this.teamLabel = new System.Windows.Forms.Label();
            this.teamPanel = new System.Windows.Forms.Panel();
            this.teamColorBox = new System.Windows.Forms.PictureBox();
            this.teamPointsLabel = new System.Windows.Forms.Label();
            this.teamColorLabel = new System.Windows.Forms.Label();
            this.teamBudgetLabel = new System.Windows.Forms.Label();
            this.teamNameLabel = new System.Windows.Forms.Label();
            this.carPanel = new System.Windows.Forms.Panel();
            this.carWeightReductionCostLabel = new System.Windows.Forms.Label();
            this.carWeightLabel = new System.Windows.Forms.Label();
            this.carNameLabel = new System.Windows.Forms.Label();
            this.frontWingPanel = new System.Windows.Forms.Panel();
            this.frontWingImage = new System.Windows.Forms.PictureBox();
            this.fwCostLabel = new System.Windows.Forms.Label();
            this.fwAeroLabel = new System.Windows.Forms.Label();
            this.rearWingPanel = new System.Windows.Forms.Panel();
            this.rwCostLabel = new System.Windows.Forms.Label();
            this.rwAeroLabel = new System.Windows.Forms.Label();
            this.chassisPanel = new System.Windows.Forms.Panel();
            this.chassisCostLabel = new System.Windows.Forms.Label();
            this.chassisAeroLabel = new System.Windows.Forms.Label();
            this.enginePanel = new System.Windows.Forms.Panel();
            this.engineCostReliabilityLabel = new System.Windows.Forms.Label();
            this.engineCostPowerLabel = new System.Windows.Forms.Label();
            this.engineReliabilityLabel = new System.Windows.Forms.Label();
            this.enginePowerLabel = new System.Windows.Forms.Label();
            this.upgradeCarLabel = new System.Windows.Forms.Label();
            this.budgetHistoryLabel = new System.Windows.Forms.Label();
            this.clickBudgetLabel = new System.Windows.Forms.Label();
            this.clickUpgradeLabel = new System.Windows.Forms.Label();
            this.clickBudetLabel1 = new System.Windows.Forms.Label();
            this.driver1panel.SuspendLayout();
            this.driver2panel.SuspendLayout();
            this.teamPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.teamColorBox)).BeginInit();
            this.carPanel.SuspendLayout();
            this.frontWingPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.frontWingImage)).BeginInit();
            this.rearWingPanel.SuspendLayout();
            this.chassisPanel.SuspendLayout();
            this.enginePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.BackColor = System.Drawing.Color.Transparent;
            this.titleLabel.Font = new System.Drawing.Font("PenultimateLightItal", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(248, 21);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(191, 31);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "My Team Details";
            // 
            // driver1Label
            // 
            this.driver1Label.AutoSize = true;
            this.driver1Label.BackColor = System.Drawing.Color.Transparent;
            this.driver1Label.Cursor = System.Windows.Forms.Cursors.Hand;
            this.driver1Label.Font = new System.Drawing.Font("PenultimateLightItal", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.driver1Label.ForeColor = System.Drawing.Color.Black;
            this.driver1Label.Location = new System.Drawing.Point(0, 120);
            this.driver1Label.Name = "driver1Label";
            this.driver1Label.Size = new System.Drawing.Size(107, 25);
            this.driver1Label.TabIndex = 1;
            this.driver1Label.Text = "> Driver 1";
            this.driver1Label.MouseEnter += new System.EventHandler(this.driver1Label_MouseEnter);
            this.driver1Label.MouseLeave += new System.EventHandler(this.driver1Label_MouseLeave);
            // 
            // driver2Label
            // 
            this.driver2Label.AutoSize = true;
            this.driver2Label.BackColor = System.Drawing.Color.Transparent;
            this.driver2Label.Cursor = System.Windows.Forms.Cursors.Hand;
            this.driver2Label.Font = new System.Drawing.Font("PenultimateLightItal", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.driver2Label.ForeColor = System.Drawing.Color.Black;
            this.driver2Label.Location = new System.Drawing.Point(0, 150);
            this.driver2Label.Name = "driver2Label";
            this.driver2Label.Size = new System.Drawing.Size(107, 25);
            this.driver2Label.TabIndex = 4;
            this.driver2Label.Text = "> Driver 2";
            this.driver2Label.MouseEnter += new System.EventHandler(this.driver2Label_MouseEnter);
            this.driver2Label.MouseLeave += new System.EventHandler(this.driver2Label_MouseLeave);
            // 
            // carLabel
            // 
            this.carLabel.AutoSize = true;
            this.carLabel.BackColor = System.Drawing.Color.Transparent;
            this.carLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.carLabel.Font = new System.Drawing.Font("PenultimateLightItal", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.carLabel.ForeColor = System.Drawing.Color.Black;
            this.carLabel.Location = new System.Drawing.Point(0, 180);
            this.carLabel.Name = "carLabel";
            this.carLabel.Size = new System.Drawing.Size(64, 25);
            this.carLabel.TabIndex = 6;
            this.carLabel.Text = "> Car";
            this.carLabel.MouseEnter += new System.EventHandler(this.carLabel_MouseEnter);
            this.carLabel.MouseLeave += new System.EventHandler(this.carLabel_MouseLeave);
            // 
            // backLabel
            // 
            this.backLabel.AutoSize = true;
            this.backLabel.BackColor = System.Drawing.Color.Transparent;
            this.backLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.backLabel.Font = new System.Drawing.Font("PenultimateLightItal", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backLabel.ForeColor = System.Drawing.Color.Black;
            this.backLabel.Location = new System.Drawing.Point(0, 400);
            this.backLabel.Name = "backLabel";
            this.backLabel.Size = new System.Drawing.Size(203, 25);
            this.backLabel.TabIndex = 10;
            this.backLabel.Text = "< Back to Main Menu";
            this.backLabel.Click += new System.EventHandler(this.backLabel_Click);
            this.backLabel.MouseEnter += new System.EventHandler(this.backLabel_MouseEnter);
            this.backLabel.MouseLeave += new System.EventHandler(this.backLabel_MouseLeave);
            // 
            // driver1panel
            // 
            this.driver1panel.BackColor = System.Drawing.Color.Transparent;
            this.driver1panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.driver1panel.Controls.Add(this.driver1PointsLabel);
            this.driver1panel.Controls.Add(this.driver1SalaryLabel);
            this.driver1panel.Controls.Add(this.driver1SkillLabel);
            this.driver1panel.Controls.Add(this.driver1NumberLabel);
            this.driver1panel.Controls.Add(this.driver1NameSurnameLabel);
            this.driver1panel.Location = new System.Drawing.Point(131, 63);
            this.driver1panel.Name = "driver1panel";
            this.driver1panel.Size = new System.Drawing.Size(452, 199);
            this.driver1panel.TabIndex = 11;
            // 
            // driver1PointsLabel
            // 
            this.driver1PointsLabel.AutoSize = true;
            this.driver1PointsLabel.BackColor = System.Drawing.Color.Transparent;
            this.driver1PointsLabel.Font = new System.Drawing.Font("PenultimateLightItal", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.driver1PointsLabel.Location = new System.Drawing.Point(3, 132);
            this.driver1PointsLabel.Name = "driver1PointsLabel";
            this.driver1PointsLabel.Size = new System.Drawing.Size(85, 25);
            this.driver1PointsLabel.TabIndex = 5;
            this.driver1PointsLabel.Text = "- Points:";
            // 
            // driver1SalaryLabel
            // 
            this.driver1SalaryLabel.AutoSize = true;
            this.driver1SalaryLabel.BackColor = System.Drawing.Color.Transparent;
            this.driver1SalaryLabel.Font = new System.Drawing.Font("PenultimateLightItal", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.driver1SalaryLabel.Location = new System.Drawing.Point(3, 102);
            this.driver1SalaryLabel.Name = "driver1SalaryLabel";
            this.driver1SalaryLabel.Size = new System.Drawing.Size(130, 25);
            this.driver1SalaryLabel.TabIndex = 4;
            this.driver1SalaryLabel.Text = "- Race salary:";
            // 
            // driver1SkillLabel
            // 
            this.driver1SkillLabel.AutoSize = true;
            this.driver1SkillLabel.BackColor = System.Drawing.Color.Transparent;
            this.driver1SkillLabel.Font = new System.Drawing.Font("PenultimateLightItal", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.driver1SkillLabel.Location = new System.Drawing.Point(3, 72);
            this.driver1SkillLabel.Name = "driver1SkillLabel";
            this.driver1SkillLabel.Size = new System.Drawing.Size(67, 25);
            this.driver1SkillLabel.TabIndex = 3;
            this.driver1SkillLabel.Text = "- Skill:";
            // 
            // driver1NumberLabel
            // 
            this.driver1NumberLabel.AutoSize = true;
            this.driver1NumberLabel.BackColor = System.Drawing.Color.Transparent;
            this.driver1NumberLabel.Font = new System.Drawing.Font("PenultimateLightItal", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.driver1NumberLabel.Location = new System.Drawing.Point(3, 42);
            this.driver1NumberLabel.Name = "driver1NumberLabel";
            this.driver1NumberLabel.Size = new System.Drawing.Size(101, 25);
            this.driver1NumberLabel.TabIndex = 2;
            this.driver1NumberLabel.Text = "- Number:";
            // 
            // driver1NameSurnameLabel
            // 
            this.driver1NameSurnameLabel.AutoSize = true;
            this.driver1NameSurnameLabel.BackColor = System.Drawing.Color.Transparent;
            this.driver1NameSurnameLabel.Font = new System.Drawing.Font("PenultimateLightItal", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.driver1NameSurnameLabel.Location = new System.Drawing.Point(145, 9);
            this.driver1NameSurnameLabel.Name = "driver1NameSurnameLabel";
            this.driver1NameSurnameLabel.Size = new System.Drawing.Size(247, 28);
            this.driver1NameSurnameLabel.TabIndex = 1;
            this.driver1NameSurnameLabel.Text = "Driver1 Name Surname";
            // 
            // frontWingLabel
            // 
            this.frontWingLabel.AutoSize = true;
            this.frontWingLabel.BackColor = System.Drawing.Color.Transparent;
            this.frontWingLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.frontWingLabel.Font = new System.Drawing.Font("PenultimateLightItal", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.frontWingLabel.ForeColor = System.Drawing.Color.Black;
            this.frontWingLabel.Location = new System.Drawing.Point(15, 205);
            this.frontWingLabel.Name = "frontWingLabel";
            this.frontWingLabel.Size = new System.Drawing.Size(117, 22);
            this.frontWingLabel.TabIndex = 12;
            this.frontWingLabel.Text = "> Front Wing";
            this.frontWingLabel.MouseEnter += new System.EventHandler(this.frontWingLabel_MouseEnter);
            this.frontWingLabel.MouseLeave += new System.EventHandler(this.frontWingLabel_MouseLeave);
            // 
            // engineLabel
            // 
            this.engineLabel.AutoSize = true;
            this.engineLabel.BackColor = System.Drawing.Color.Transparent;
            this.engineLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.engineLabel.Font = new System.Drawing.Font("PenultimateLightItal", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.engineLabel.ForeColor = System.Drawing.Color.Black;
            this.engineLabel.Location = new System.Drawing.Point(15, 280);
            this.engineLabel.Name = "engineLabel";
            this.engineLabel.Size = new System.Drawing.Size(78, 22);
            this.engineLabel.TabIndex = 13;
            this.engineLabel.Text = "> Engine";
            this.engineLabel.MouseEnter += new System.EventHandler(this.engineLabel_MouseEnter);
            this.engineLabel.MouseLeave += new System.EventHandler(this.engineLabel_MouseLeave);
            // 
            // chassisLabel
            // 
            this.chassisLabel.AutoSize = true;
            this.chassisLabel.BackColor = System.Drawing.Color.Transparent;
            this.chassisLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chassisLabel.Font = new System.Drawing.Font("PenultimateLightItal", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chassisLabel.ForeColor = System.Drawing.Color.Black;
            this.chassisLabel.Location = new System.Drawing.Point(15, 255);
            this.chassisLabel.Name = "chassisLabel";
            this.chassisLabel.Size = new System.Drawing.Size(85, 22);
            this.chassisLabel.TabIndex = 14;
            this.chassisLabel.Text = "> Chassis";
            this.chassisLabel.MouseEnter += new System.EventHandler(this.chassisLabel_MouseEnter);
            this.chassisLabel.MouseLeave += new System.EventHandler(this.chassisLabel_MouseLeave);
            // 
            // rearWingLabel
            // 
            this.rearWingLabel.AutoSize = true;
            this.rearWingLabel.BackColor = System.Drawing.Color.Transparent;
            this.rearWingLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rearWingLabel.Font = new System.Drawing.Font("PenultimateLightItal", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rearWingLabel.ForeColor = System.Drawing.Color.Black;
            this.rearWingLabel.Location = new System.Drawing.Point(15, 230);
            this.rearWingLabel.Name = "rearWingLabel";
            this.rearWingLabel.Size = new System.Drawing.Size(107, 22);
            this.rearWingLabel.TabIndex = 15;
            this.rearWingLabel.Text = "> Rear Wing";
            this.rearWingLabel.MouseEnter += new System.EventHandler(this.rearWingLabel_MouseEnter);
            this.rearWingLabel.MouseLeave += new System.EventHandler(this.rearWingLabel_MouseLeave);
            // 
            // driver2panel
            // 
            this.driver2panel.BackColor = System.Drawing.Color.Transparent;
            this.driver2panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.driver2panel.Controls.Add(this.driver2PointsLabel);
            this.driver2panel.Controls.Add(this.driver2SalaryLabel);
            this.driver2panel.Controls.Add(this.driver2SkillLabel);
            this.driver2panel.Controls.Add(this.driver2NumberLabel);
            this.driver2panel.Controls.Add(this.driver2NameSurnameLabel);
            this.driver2panel.Location = new System.Drawing.Point(131, 63);
            this.driver2panel.Name = "driver2panel";
            this.driver2panel.Size = new System.Drawing.Size(452, 199);
            this.driver2panel.TabIndex = 16;
            // 
            // driver2PointsLabel
            // 
            this.driver2PointsLabel.AutoSize = true;
            this.driver2PointsLabel.BackColor = System.Drawing.Color.Transparent;
            this.driver2PointsLabel.Font = new System.Drawing.Font("PenultimateLightItal", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.driver2PointsLabel.Location = new System.Drawing.Point(3, 132);
            this.driver2PointsLabel.Name = "driver2PointsLabel";
            this.driver2PointsLabel.Size = new System.Drawing.Size(85, 25);
            this.driver2PointsLabel.TabIndex = 5;
            this.driver2PointsLabel.Text = "- Points:";
            // 
            // driver2SalaryLabel
            // 
            this.driver2SalaryLabel.AutoSize = true;
            this.driver2SalaryLabel.BackColor = System.Drawing.Color.Transparent;
            this.driver2SalaryLabel.Font = new System.Drawing.Font("PenultimateLightItal", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.driver2SalaryLabel.Location = new System.Drawing.Point(3, 102);
            this.driver2SalaryLabel.Name = "driver2SalaryLabel";
            this.driver2SalaryLabel.Size = new System.Drawing.Size(130, 25);
            this.driver2SalaryLabel.TabIndex = 4;
            this.driver2SalaryLabel.Text = "- Race salary:";
            // 
            // driver2SkillLabel
            // 
            this.driver2SkillLabel.AutoSize = true;
            this.driver2SkillLabel.BackColor = System.Drawing.Color.Transparent;
            this.driver2SkillLabel.Font = new System.Drawing.Font("PenultimateLightItal", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.driver2SkillLabel.Location = new System.Drawing.Point(3, 72);
            this.driver2SkillLabel.Name = "driver2SkillLabel";
            this.driver2SkillLabel.Size = new System.Drawing.Size(67, 25);
            this.driver2SkillLabel.TabIndex = 3;
            this.driver2SkillLabel.Text = "- Skill:";
            // 
            // driver2NumberLabel
            // 
            this.driver2NumberLabel.AutoSize = true;
            this.driver2NumberLabel.BackColor = System.Drawing.Color.Transparent;
            this.driver2NumberLabel.Font = new System.Drawing.Font("PenultimateLightItal", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.driver2NumberLabel.Location = new System.Drawing.Point(3, 42);
            this.driver2NumberLabel.Name = "driver2NumberLabel";
            this.driver2NumberLabel.Size = new System.Drawing.Size(101, 25);
            this.driver2NumberLabel.TabIndex = 2;
            this.driver2NumberLabel.Text = "- Number:";
            // 
            // driver2NameSurnameLabel
            // 
            this.driver2NameSurnameLabel.AutoSize = true;
            this.driver2NameSurnameLabel.BackColor = System.Drawing.Color.Transparent;
            this.driver2NameSurnameLabel.Font = new System.Drawing.Font("PenultimateLightItal", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.driver2NameSurnameLabel.Location = new System.Drawing.Point(145, 9);
            this.driver2NameSurnameLabel.Name = "driver2NameSurnameLabel";
            this.driver2NameSurnameLabel.Size = new System.Drawing.Size(247, 28);
            this.driver2NameSurnameLabel.TabIndex = 1;
            this.driver2NameSurnameLabel.Text = "Driver2 Name Surname";
            // 
            // teamLabel
            // 
            this.teamLabel.AutoSize = true;
            this.teamLabel.BackColor = System.Drawing.Color.Transparent;
            this.teamLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.teamLabel.Font = new System.Drawing.Font("PenultimateLightItal", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teamLabel.ForeColor = System.Drawing.Color.Black;
            this.teamLabel.Location = new System.Drawing.Point(0, 60);
            this.teamLabel.Name = "teamLabel";
            this.teamLabel.Size = new System.Drawing.Size(70, 25);
            this.teamLabel.TabIndex = 17;
            this.teamLabel.Text = "> Team";
            this.teamLabel.MouseEnter += new System.EventHandler(this.teamLabel_MouseEnter);
            this.teamLabel.MouseLeave += new System.EventHandler(this.teamLabel_MouseLeave);
            // 
            // teamPanel
            // 
            this.teamPanel.BackColor = System.Drawing.Color.Transparent;
            this.teamPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.teamPanel.Controls.Add(this.teamColorBox);
            this.teamPanel.Controls.Add(this.teamPointsLabel);
            this.teamPanel.Controls.Add(this.teamColorLabel);
            this.teamPanel.Controls.Add(this.teamBudgetLabel);
            this.teamPanel.Controls.Add(this.teamNameLabel);
            this.teamPanel.Location = new System.Drawing.Point(131, 63);
            this.teamPanel.Name = "teamPanel";
            this.teamPanel.Size = new System.Drawing.Size(452, 199);
            this.teamPanel.TabIndex = 18;
            // 
            // teamColorBox
            // 
            this.teamColorBox.Location = new System.Drawing.Point(80, 68);
            this.teamColorBox.Name = "teamColorBox";
            this.teamColorBox.Size = new System.Drawing.Size(20, 20);
            this.teamColorBox.TabIndex = 6;
            this.teamColorBox.TabStop = false;
            // 
            // teamPointsLabel
            // 
            this.teamPointsLabel.AutoSize = true;
            this.teamPointsLabel.BackColor = System.Drawing.Color.Transparent;
            this.teamPointsLabel.Font = new System.Drawing.Font("PenultimateLightItal", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teamPointsLabel.Location = new System.Drawing.Point(3, 96);
            this.teamPointsLabel.Name = "teamPointsLabel";
            this.teamPointsLabel.Size = new System.Drawing.Size(85, 25);
            this.teamPointsLabel.TabIndex = 5;
            this.teamPointsLabel.Text = "- Points:";
            // 
            // teamColorLabel
            // 
            this.teamColorLabel.AutoSize = true;
            this.teamColorLabel.BackColor = System.Drawing.Color.Transparent;
            this.teamColorLabel.Font = new System.Drawing.Font("PenultimateLightItal", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teamColorLabel.Location = new System.Drawing.Point(3, 66);
            this.teamColorLabel.Name = "teamColorLabel";
            this.teamColorLabel.Size = new System.Drawing.Size(86, 25);
            this.teamColorLabel.TabIndex = 4;
            this.teamColorLabel.Text = "- Color:";
            // 
            // teamBudgetLabel
            // 
            this.teamBudgetLabel.AutoSize = true;
            this.teamBudgetLabel.BackColor = System.Drawing.Color.Transparent;
            this.teamBudgetLabel.Font = new System.Drawing.Font("PenultimateLightItal", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teamBudgetLabel.Location = new System.Drawing.Point(3, 36);
            this.teamBudgetLabel.Name = "teamBudgetLabel";
            this.teamBudgetLabel.Size = new System.Drawing.Size(96, 25);
            this.teamBudgetLabel.TabIndex = 3;
            this.teamBudgetLabel.Text = "- Budget:";
            // 
            // teamNameLabel
            // 
            this.teamNameLabel.AutoSize = true;
            this.teamNameLabel.BackColor = System.Drawing.Color.Transparent;
            this.teamNameLabel.Font = new System.Drawing.Font("PenultimateLightItal", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teamNameLabel.Location = new System.Drawing.Point(3, 6);
            this.teamNameLabel.Name = "teamNameLabel";
            this.teamNameLabel.Size = new System.Drawing.Size(76, 25);
            this.teamNameLabel.TabIndex = 2;
            this.teamNameLabel.Text = "- Name:";
            // 
            // carPanel
            // 
            this.carPanel.BackColor = System.Drawing.Color.Transparent;
            this.carPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.carPanel.Controls.Add(this.carWeightReductionCostLabel);
            this.carPanel.Controls.Add(this.carWeightLabel);
            this.carPanel.Controls.Add(this.carNameLabel);
            this.carPanel.Location = new System.Drawing.Point(131, 63);
            this.carPanel.Name = "carPanel";
            this.carPanel.Size = new System.Drawing.Size(452, 199);
            this.carPanel.TabIndex = 19;
            // 
            // carWeightReductionCostLabel
            // 
            this.carWeightReductionCostLabel.AutoSize = true;
            this.carWeightReductionCostLabel.BackColor = System.Drawing.Color.Transparent;
            this.carWeightReductionCostLabel.Font = new System.Drawing.Font("PenultimateLightItal", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.carWeightReductionCostLabel.Location = new System.Drawing.Point(3, 66);
            this.carWeightReductionCostLabel.Name = "carWeightReductionCostLabel";
            this.carWeightReductionCostLabel.Size = new System.Drawing.Size(233, 25);
            this.carWeightReductionCostLabel.TabIndex = 4;
            this.carWeightReductionCostLabel.Text = "- Weight reduction cost:";
            // 
            // carWeightLabel
            // 
            this.carWeightLabel.AutoSize = true;
            this.carWeightLabel.BackColor = System.Drawing.Color.Transparent;
            this.carWeightLabel.Font = new System.Drawing.Font("PenultimateLightItal", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.carWeightLabel.Location = new System.Drawing.Point(3, 36);
            this.carWeightLabel.Name = "carWeightLabel";
            this.carWeightLabel.Size = new System.Drawing.Size(91, 25);
            this.carWeightLabel.TabIndex = 3;
            this.carWeightLabel.Text = "- Weight:";
            // 
            // carNameLabel
            // 
            this.carNameLabel.AutoSize = true;
            this.carNameLabel.BackColor = System.Drawing.Color.Transparent;
            this.carNameLabel.Font = new System.Drawing.Font("PenultimateLightItal", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.carNameLabel.Location = new System.Drawing.Point(3, 6);
            this.carNameLabel.Name = "carNameLabel";
            this.carNameLabel.Size = new System.Drawing.Size(76, 25);
            this.carNameLabel.TabIndex = 2;
            this.carNameLabel.Text = "- Name:";
            // 
            // frontWingPanel
            // 
            this.frontWingPanel.BackColor = System.Drawing.Color.Transparent;
            this.frontWingPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.frontWingPanel.Controls.Add(this.frontWingImage);
            this.frontWingPanel.Controls.Add(this.fwCostLabel);
            this.frontWingPanel.Controls.Add(this.fwAeroLabel);
            this.frontWingPanel.Location = new System.Drawing.Point(131, 63);
            this.frontWingPanel.Name = "frontWingPanel";
            this.frontWingPanel.Size = new System.Drawing.Size(452, 199);
            this.frontWingPanel.TabIndex = 20;
            // 
            // frontWingImage
            // 
            this.frontWingImage.Image = global::F1_Simulator.Properties.Resources.front_wing1;
            this.frontWingImage.Location = new System.Drawing.Point(120, 70);
            this.frontWingImage.Name = "frontWingImage";
            this.frontWingImage.Size = new System.Drawing.Size(400, 200);
            this.frontWingImage.TabIndex = 4;
            this.frontWingImage.TabStop = false;
            // 
            // fwCostLabel
            // 
            this.fwCostLabel.AutoSize = true;
            this.fwCostLabel.BackColor = System.Drawing.Color.Transparent;
            this.fwCostLabel.Font = new System.Drawing.Font("PenultimateLightItal", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fwCostLabel.Location = new System.Drawing.Point(3, 36);
            this.fwCostLabel.Name = "fwCostLabel";
            this.fwCostLabel.Size = new System.Drawing.Size(219, 25);
            this.fwCostLabel.TabIndex = 3;
            this.fwCostLabel.Text = "- Cost of Improvement:";
            // 
            // fwAeroLabel
            // 
            this.fwAeroLabel.AutoSize = true;
            this.fwAeroLabel.BackColor = System.Drawing.Color.Transparent;
            this.fwAeroLabel.Font = new System.Drawing.Font("PenultimateLightItal", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fwAeroLabel.Location = new System.Drawing.Point(3, 6);
            this.fwAeroLabel.Name = "fwAeroLabel";
            this.fwAeroLabel.Size = new System.Drawing.Size(268, 25);
            this.fwAeroLabel.TabIndex = 2;
            this.fwAeroLabel.Text = "- Aerodynamic Performance:";
            // 
            // rearWingPanel
            // 
            this.rearWingPanel.BackColor = System.Drawing.Color.Transparent;
            this.rearWingPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rearWingPanel.Controls.Add(this.rwCostLabel);
            this.rearWingPanel.Controls.Add(this.rwAeroLabel);
            this.rearWingPanel.Location = new System.Drawing.Point(131, 63);
            this.rearWingPanel.Name = "rearWingPanel";
            this.rearWingPanel.Size = new System.Drawing.Size(452, 199);
            this.rearWingPanel.TabIndex = 21;
            // 
            // rwCostLabel
            // 
            this.rwCostLabel.AutoSize = true;
            this.rwCostLabel.BackColor = System.Drawing.Color.Transparent;
            this.rwCostLabel.Font = new System.Drawing.Font("PenultimateLightItal", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rwCostLabel.Location = new System.Drawing.Point(3, 36);
            this.rwCostLabel.Name = "rwCostLabel";
            this.rwCostLabel.Size = new System.Drawing.Size(219, 25);
            this.rwCostLabel.TabIndex = 3;
            this.rwCostLabel.Text = "- Cost of Improvement:";
            // 
            // rwAeroLabel
            // 
            this.rwAeroLabel.AutoSize = true;
            this.rwAeroLabel.BackColor = System.Drawing.Color.Transparent;
            this.rwAeroLabel.Font = new System.Drawing.Font("PenultimateLightItal", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rwAeroLabel.Location = new System.Drawing.Point(3, 6);
            this.rwAeroLabel.Name = "rwAeroLabel";
            this.rwAeroLabel.Size = new System.Drawing.Size(268, 25);
            this.rwAeroLabel.TabIndex = 2;
            this.rwAeroLabel.Text = "- Aerodynamic Performance:";
            // 
            // chassisPanel
            // 
            this.chassisPanel.BackColor = System.Drawing.Color.Transparent;
            this.chassisPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.chassisPanel.Controls.Add(this.chassisCostLabel);
            this.chassisPanel.Controls.Add(this.chassisAeroLabel);
            this.chassisPanel.Location = new System.Drawing.Point(131, 63);
            this.chassisPanel.Name = "chassisPanel";
            this.chassisPanel.Size = new System.Drawing.Size(452, 199);
            this.chassisPanel.TabIndex = 22;
            // 
            // chassisCostLabel
            // 
            this.chassisCostLabel.AutoSize = true;
            this.chassisCostLabel.BackColor = System.Drawing.Color.Transparent;
            this.chassisCostLabel.Font = new System.Drawing.Font("PenultimateLightItal", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chassisCostLabel.Location = new System.Drawing.Point(3, 36);
            this.chassisCostLabel.Name = "chassisCostLabel";
            this.chassisCostLabel.Size = new System.Drawing.Size(219, 25);
            this.chassisCostLabel.TabIndex = 3;
            this.chassisCostLabel.Text = "- Cost of Improvement:";
            // 
            // chassisAeroLabel
            // 
            this.chassisAeroLabel.AutoSize = true;
            this.chassisAeroLabel.BackColor = System.Drawing.Color.Transparent;
            this.chassisAeroLabel.Font = new System.Drawing.Font("PenultimateLightItal", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chassisAeroLabel.Location = new System.Drawing.Point(3, 6);
            this.chassisAeroLabel.Name = "chassisAeroLabel";
            this.chassisAeroLabel.Size = new System.Drawing.Size(268, 25);
            this.chassisAeroLabel.TabIndex = 2;
            this.chassisAeroLabel.Text = "- Aerodynamic Performance:";
            // 
            // enginePanel
            // 
            this.enginePanel.BackColor = System.Drawing.Color.Transparent;
            this.enginePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.enginePanel.Controls.Add(this.engineCostReliabilityLabel);
            this.enginePanel.Controls.Add(this.engineCostPowerLabel);
            this.enginePanel.Controls.Add(this.engineReliabilityLabel);
            this.enginePanel.Controls.Add(this.enginePowerLabel);
            this.enginePanel.Location = new System.Drawing.Point(131, 63);
            this.enginePanel.Name = "enginePanel";
            this.enginePanel.Size = new System.Drawing.Size(452, 199);
            this.enginePanel.TabIndex = 23;
            // 
            // engineCostReliabilityLabel
            // 
            this.engineCostReliabilityLabel.AutoSize = true;
            this.engineCostReliabilityLabel.BackColor = System.Drawing.Color.Transparent;
            this.engineCostReliabilityLabel.Font = new System.Drawing.Font("PenultimateLightItal", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.engineCostReliabilityLabel.Location = new System.Drawing.Point(3, 96);
            this.engineCostReliabilityLabel.Name = "engineCostReliabilityLabel";
            this.engineCostReliabilityLabel.Size = new System.Drawing.Size(306, 25);
            this.engineCostReliabilityLabel.TabIndex = 5;
            this.engineCostReliabilityLabel.Text = "- Cost of reliability improvement";
            // 
            // engineCostPowerLabel
            // 
            this.engineCostPowerLabel.AutoSize = true;
            this.engineCostPowerLabel.BackColor = System.Drawing.Color.Transparent;
            this.engineCostPowerLabel.Font = new System.Drawing.Font("PenultimateLightItal", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.engineCostPowerLabel.Location = new System.Drawing.Point(3, 66);
            this.engineCostPowerLabel.Name = "engineCostPowerLabel";
            this.engineCostPowerLabel.Size = new System.Drawing.Size(280, 25);
            this.engineCostPowerLabel.TabIndex = 4;
            this.engineCostPowerLabel.Text = "- Cost of power improvement";
            // 
            // engineReliabilityLabel
            // 
            this.engineReliabilityLabel.AutoSize = true;
            this.engineReliabilityLabel.BackColor = System.Drawing.Color.Transparent;
            this.engineReliabilityLabel.Font = new System.Drawing.Font("PenultimateLightItal", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.engineReliabilityLabel.Location = new System.Drawing.Point(3, 36);
            this.engineReliabilityLabel.Name = "engineReliabilityLabel";
            this.engineReliabilityLabel.Size = new System.Drawing.Size(112, 25);
            this.engineReliabilityLabel.TabIndex = 3;
            this.engineReliabilityLabel.Text = "- Reliability";
            // 
            // enginePowerLabel
            // 
            this.enginePowerLabel.AutoSize = true;
            this.enginePowerLabel.BackColor = System.Drawing.Color.Transparent;
            this.enginePowerLabel.Font = new System.Drawing.Font("PenultimateLightItal", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enginePowerLabel.Location = new System.Drawing.Point(3, 6);
            this.enginePowerLabel.Name = "enginePowerLabel";
            this.enginePowerLabel.Size = new System.Drawing.Size(87, 25);
            this.enginePowerLabel.TabIndex = 2;
            this.enginePowerLabel.Text = "- Power:";
            // 
            // upgradeCarLabel
            // 
            this.upgradeCarLabel.AutoSize = true;
            this.upgradeCarLabel.BackColor = System.Drawing.Color.Transparent;
            this.upgradeCarLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.upgradeCarLabel.Font = new System.Drawing.Font("PenultimateLightItal", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.upgradeCarLabel.ForeColor = System.Drawing.Color.Black;
            this.upgradeCarLabel.Location = new System.Drawing.Point(0, 310);
            this.upgradeCarLabel.Name = "upgradeCarLabel";
            this.upgradeCarLabel.Size = new System.Drawing.Size(149, 25);
            this.upgradeCarLabel.TabIndex = 24;
            this.upgradeCarLabel.Text = "> Upgrade Car";
            this.upgradeCarLabel.Click += new System.EventHandler(this.upgradeCarLabel_Click);
            this.upgradeCarLabel.MouseEnter += new System.EventHandler(this.upgradeCarLabel_MouseEnter);
            this.upgradeCarLabel.MouseLeave += new System.EventHandler(this.upgradeCarLabel_MouseLeave);
            // 
            // budgetHistoryLabel
            // 
            this.budgetHistoryLabel.AutoSize = true;
            this.budgetHistoryLabel.BackColor = System.Drawing.Color.Transparent;
            this.budgetHistoryLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.budgetHistoryLabel.Font = new System.Drawing.Font("PenultimateLightItal", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.budgetHistoryLabel.ForeColor = System.Drawing.Color.Black;
            this.budgetHistoryLabel.Location = new System.Drawing.Point(15, 90);
            this.budgetHistoryLabel.Name = "budgetHistoryLabel";
            this.budgetHistoryLabel.Size = new System.Drawing.Size(153, 22);
            this.budgetHistoryLabel.TabIndex = 25;
            this.budgetHistoryLabel.Text = "> Budget history";
            this.budgetHistoryLabel.Click += new System.EventHandler(this.budgetHistoryLabel_Click);
            this.budgetHistoryLabel.MouseEnter += new System.EventHandler(this.budgetHistoryLabel_MouseEnter);
            this.budgetHistoryLabel.MouseLeave += new System.EventHandler(this.budgetHistoryLabel_MouseLeave);
            // 
            // clickBudgetLabel
            // 
            this.clickBudgetLabel.AutoSize = true;
            this.clickBudgetLabel.BackColor = System.Drawing.Color.Transparent;
            this.clickBudgetLabel.Cursor = System.Windows.Forms.Cursors.Default;
            this.clickBudgetLabel.Font = new System.Drawing.Font("PenultimateLightItal", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clickBudgetLabel.ForeColor = System.Drawing.Color.Black;
            this.clickBudgetLabel.Location = new System.Drawing.Point(29, 29);
            this.clickBudgetLabel.Name = "clickBudgetLabel";
            this.clickBudgetLabel.Size = new System.Drawing.Size(95, 18);
            this.clickBudgetLabel.TabIndex = 26;
            this.clickBudgetLabel.Text = "(click to see)";
            // 
            // clickUpgradeLabel
            // 
            this.clickUpgradeLabel.AutoSize = true;
            this.clickUpgradeLabel.BackColor = System.Drawing.Color.Transparent;
            this.clickUpgradeLabel.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.clickUpgradeLabel.Font = new System.Drawing.Font("PenultimateLightItal", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clickUpgradeLabel.ForeColor = System.Drawing.Color.Black;
            this.clickUpgradeLabel.Location = new System.Drawing.Point(40, 330);
            this.clickUpgradeLabel.Name = "clickUpgradeLabel";
            this.clickUpgradeLabel.Size = new System.Drawing.Size(110, 15);
            this.clickUpgradeLabel.TabIndex = 27;
            this.clickUpgradeLabel.Text = "(click to upgrade)";
            // 
            // clickBudetLabel1
            // 
            this.clickBudetLabel1.AutoSize = true;
            this.clickBudetLabel1.BackColor = System.Drawing.Color.Transparent;
            this.clickBudetLabel1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.clickBudetLabel1.Font = new System.Drawing.Font("PenultimateLightItal", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clickBudetLabel1.ForeColor = System.Drawing.Color.Black;
            this.clickBudetLabel1.Location = new System.Drawing.Point(43, 108);
            this.clickBudetLabel1.Name = "clickBudetLabel1";
            this.clickBudetLabel1.Size = new System.Drawing.Size(79, 15);
            this.clickBudetLabel1.TabIndex = 28;
            this.clickBudetLabel1.Text = "(click to see)";
            // 
            // MyTeam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::F1_Simulator.Properties.Resources.bg;
            this.Controls.Add(this.clickBudetLabel1);
            this.Controls.Add(this.clickUpgradeLabel);
            this.Controls.Add(this.budgetHistoryLabel);
            this.Controls.Add(this.upgradeCarLabel);
            this.Controls.Add(this.teamLabel);
            this.Controls.Add(this.rearWingLabel);
            this.Controls.Add(this.chassisLabel);
            this.Controls.Add(this.engineLabel);
            this.Controls.Add(this.frontWingLabel);
            this.Controls.Add(this.backLabel);
            this.Controls.Add(this.carLabel);
            this.Controls.Add(this.driver2Label);
            this.Controls.Add(this.driver1Label);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.frontWingPanel);
            this.Controls.Add(this.carPanel);
            this.Controls.Add(this.teamPanel);
            this.Controls.Add(this.driver2panel);
            this.Controls.Add(this.driver1panel);
            this.Controls.Add(this.enginePanel);
            this.Controls.Add(this.chassisPanel);
            this.Controls.Add(this.rearWingPanel);
            this.Name = "MyTeam";
            this.Size = new System.Drawing.Size(888, 559);
            this.driver1panel.ResumeLayout(false);
            this.driver1panel.PerformLayout();
            this.driver2panel.ResumeLayout(false);
            this.driver2panel.PerformLayout();
            this.teamPanel.ResumeLayout(false);
            this.teamPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.teamColorBox)).EndInit();
            this.carPanel.ResumeLayout(false);
            this.carPanel.PerformLayout();
            this.frontWingPanel.ResumeLayout(false);
            this.frontWingPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.frontWingImage)).EndInit();
            this.rearWingPanel.ResumeLayout(false);
            this.rearWingPanel.PerformLayout();
            this.chassisPanel.ResumeLayout(false);
            this.chassisPanel.PerformLayout();
            this.enginePanel.ResumeLayout(false);
            this.enginePanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

       

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label driver1Label;
        private System.Windows.Forms.Label driver2Label;
        private System.Windows.Forms.Label carLabel;
        private System.Windows.Forms.Label backLabel;
        private System.Windows.Forms.Panel driver1panel;
        private System.Windows.Forms.Label frontWingLabel;
        private System.Windows.Forms.Label engineLabel;
        private System.Windows.Forms.Label chassisLabel;
        private System.Windows.Forms.Label rearWingLabel;
        private System.Windows.Forms.Label driver1NameSurnameLabel;
        private System.Windows.Forms.Label driver1SalaryLabel;
        private System.Windows.Forms.Label driver1SkillLabel;
        private System.Windows.Forms.Label driver1NumberLabel;
        private System.Windows.Forms.Label driver1PointsLabel;
        private System.Windows.Forms.Panel driver2panel;
        private System.Windows.Forms.Label driver2PointsLabel;
        private System.Windows.Forms.Label driver2SalaryLabel;
        private System.Windows.Forms.Label driver2SkillLabel;
        private System.Windows.Forms.Label driver2NumberLabel;
        private System.Windows.Forms.Label driver2NameSurnameLabel;
        private System.Windows.Forms.Label teamLabel;
        private System.Windows.Forms.Panel teamPanel;
        private System.Windows.Forms.Label teamPointsLabel;
        private System.Windows.Forms.Label teamColorLabel;
        private System.Windows.Forms.Label teamBudgetLabel;
        private System.Windows.Forms.Label teamNameLabel;
        private System.Windows.Forms.PictureBox teamColorBox;
        private System.Windows.Forms.Panel carPanel;
        private System.Windows.Forms.Label carWeightLabel;
        private System.Windows.Forms.Label carNameLabel;
        private System.Windows.Forms.Panel frontWingPanel;
        private System.Windows.Forms.Label fwCostLabel;
        private System.Windows.Forms.Label fwAeroLabel;
        private System.Windows.Forms.Panel rearWingPanel;
        private System.Windows.Forms.Label rwCostLabel;
        private System.Windows.Forms.Label rwAeroLabel;
        private System.Windows.Forms.Panel chassisPanel;
        private System.Windows.Forms.Label chassisCostLabel;
        private System.Windows.Forms.Label chassisAeroLabel;
        private System.Windows.Forms.Panel enginePanel;
        private System.Windows.Forms.Label engineReliabilityLabel;
        private System.Windows.Forms.Label enginePowerLabel;
        private System.Windows.Forms.Label engineCostReliabilityLabel;
        private System.Windows.Forms.Label engineCostPowerLabel;
        private System.Windows.Forms.Label upgradeCarLabel;
        private System.Windows.Forms.Label budgetHistoryLabel;
        private System.Windows.Forms.Label carWeightReductionCostLabel;
        private System.Windows.Forms.Label clickBudgetLabel;
        private System.Windows.Forms.Label clickUpgradeLabel;
        private System.Windows.Forms.Label clickBudetLabel1;
        private System.Windows.Forms.PictureBox frontWingImage;
    }
}
