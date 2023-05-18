namespace F1_Simulator.Forms
{
    partial class MainMenu
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
            this.label1 = new System.Windows.Forms.Label();
            this.labelRaceWeek = new System.Windows.Forms.Label();
            this.myTeamLabel = new System.Windows.Forms.Label();
            this.standingsLabel = new System.Windows.Forms.Label();
            this.calendarLabel = new System.Windows.Forms.Label();
            this.nextRaceLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("PenultimateLightItal", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(280, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Main Menu";
            // 
            // labelRaceWeek
            // 
            this.labelRaceWeek.AutoSize = true;
            this.labelRaceWeek.BackColor = System.Drawing.Color.Transparent;
            this.labelRaceWeek.Font = new System.Drawing.Font("PenultimateLightItal", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRaceWeek.Location = new System.Drawing.Point(275, 50);
            this.labelRaceWeek.Name = "labelRaceWeek";
            this.labelRaceWeek.Size = new System.Drawing.Size(93, 22);
            this.labelRaceWeek.TabIndex = 1;
            this.labelRaceWeek.Text = "Race Week";
            // 
            // myTeamLabel
            // 
            this.myTeamLabel.AutoSize = true;
            this.myTeamLabel.BackColor = System.Drawing.Color.Transparent;
            this.myTeamLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.myTeamLabel.Font = new System.Drawing.Font("PenultimateLightItal", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myTeamLabel.ForeColor = System.Drawing.Color.Black;
            this.myTeamLabel.Location = new System.Drawing.Point(288, 120);
            this.myTeamLabel.Name = "myTeamLabel";
            this.myTeamLabel.Size = new System.Drawing.Size(136, 28);
            this.myTeamLabel.TabIndex = 2;
            this.myTeamLabel.Text = "> My Team <";
            this.myTeamLabel.Click += new System.EventHandler(this.labelMyTeam_Click);
            this.myTeamLabel.MouseEnter += new System.EventHandler(this.MyTeamLabel_MouseEnter);
            this.myTeamLabel.MouseLeave += new System.EventHandler(this.MyTeamLabel_MouseLeave);
            // 
            // standingsLabel
            // 
            this.standingsLabel.AutoSize = true;
            this.standingsLabel.BackColor = System.Drawing.Color.Transparent;
            this.standingsLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.standingsLabel.Font = new System.Drawing.Font("PenultimateLightItal", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.standingsLabel.ForeColor = System.Drawing.Color.Black;
            this.standingsLabel.Location = new System.Drawing.Point(281, 155);
            this.standingsLabel.Name = "standingsLabel";
            this.standingsLabel.Size = new System.Drawing.Size(153, 28);
            this.standingsLabel.TabIndex = 3;
            this.standingsLabel.Text = "> Standings <";
            this.standingsLabel.Click += new System.EventHandler(this.standingsLabel_Click);
            this.standingsLabel.MouseEnter += new System.EventHandler(this.standingsLabel_MouseEnter);
            this.standingsLabel.MouseLeave += new System.EventHandler(this.standingsLabel_MouseLeave);
            // 
            // calendarLabel
            // 
            this.calendarLabel.AutoSize = true;
            this.calendarLabel.BackColor = System.Drawing.Color.Transparent;
            this.calendarLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.calendarLabel.Font = new System.Drawing.Font("PenultimateLightItal", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calendarLabel.ForeColor = System.Drawing.Color.Black;
            this.calendarLabel.Location = new System.Drawing.Point(285, 190);
            this.calendarLabel.Name = "calendarLabel";
            this.calendarLabel.Size = new System.Drawing.Size(144, 28);
            this.calendarLabel.TabIndex = 4;
            this.calendarLabel.Text = "> Calendar <";
            this.calendarLabel.Click += new System.EventHandler(this.calendarLabel_Click);
            this.calendarLabel.MouseEnter += new System.EventHandler(this.calendarLabel_MouseEnter);
            this.calendarLabel.MouseLeave += new System.EventHandler(this.calendarLabel_MouseLeave);
            // 
            // nextRaceLabel
            // 
            this.nextRaceLabel.AutoSize = true;
            this.nextRaceLabel.BackColor = System.Drawing.Color.Transparent;
            this.nextRaceLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.nextRaceLabel.Font = new System.Drawing.Font("PenultimateLightItal", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nextRaceLabel.ForeColor = System.Drawing.Color.Black;
            this.nextRaceLabel.Location = new System.Drawing.Point(282, 225);
            this.nextRaceLabel.Name = "nextRaceLabel";
            this.nextRaceLabel.Size = new System.Drawing.Size(151, 28);
            this.nextRaceLabel.TabIndex = 5;
            this.nextRaceLabel.Text = "> Next Race <";
            this.nextRaceLabel.Click += new System.EventHandler(this.nextRaceLabel_Click);
            this.nextRaceLabel.MouseEnter += new System.EventHandler(this.nextRaceLabel_MouseEnter);
            this.nextRaceLabel.MouseLeave += new System.EventHandler(this.nextRaceLabel_MouseLeave);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::F1_Simulator.Properties.Resources.bg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Controls.Add(this.nextRaceLabel);
            this.Controls.Add(this.calendarLabel);
            this.Controls.Add(this.standingsLabel);
            this.Controls.Add(this.myTeamLabel);
            this.Controls.Add(this.labelRaceWeek);
            this.Controls.Add(this.label1);
            this.Name = "MainMenu";
            this.Size = new System.Drawing.Size(888, 559);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelRaceWeek;
        private System.Windows.Forms.Label myTeamLabel;
        private System.Windows.Forms.Label standingsLabel;
        private System.Windows.Forms.Label calendarLabel;
        private System.Windows.Forms.Label nextRaceLabel;
    }
}
