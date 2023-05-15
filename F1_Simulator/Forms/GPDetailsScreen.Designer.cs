namespace F1_Simulator.Forms
{
    partial class GPDetailsScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GPDetailsScreen));
            this.titleLabel = new System.Windows.Forms.Label();
            this.circuitLayoutImage = new System.Windows.Forms.PictureBox();
            this.backLabel = new System.Windows.Forms.Label();
            this.flagImage = new System.Windows.Forms.PictureBox();
            this.circuitNameLabel = new System.Windows.Forms.Label();
            this.circuitName = new System.Windows.Forms.Label();
            this.circuitTitleLabel = new System.Windows.Forms.Label();
            this.circuitTypeLabel = new System.Windows.Forms.Label();
            this.circuitType = new System.Windows.Forms.Label();
            this.circuitLengthLabel = new System.Windows.Forms.Label();
            this.circuitLength = new System.Windows.Forms.Label();
            this.circuitDownforceLabel = new System.Windows.Forms.Label();
            this.circuitDownforce = new System.Windows.Forms.Label();
            this.circuitFullThrottleLabel = new System.Windows.Forms.Label();
            this.circuitFullThrottle = new System.Windows.Forms.Label();
            this.circuitTyreStressLabel = new System.Windows.Forms.Label();
            this.circuitTyreStress = new System.Windows.Forms.Label();
            this.GPCountryLabel = new System.Windows.Forms.Label();
            this.GPCountry = new System.Windows.Forms.Label();
            this.GPCityLabel = new System.Windows.Forms.Label();
            this.GPCity = new System.Windows.Forms.Label();
            this.GPRaceWeekLabel = new System.Windows.Forms.Label();
            this.GPRaceWeek = new System.Windows.Forms.Label();
            this.GPLapsLabel = new System.Windows.Forms.Label();
            this.GPLaps = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.circuitLayoutImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flagImage)).BeginInit();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.BackColor = System.Drawing.Color.Transparent;
            this.titleLabel.Font = new System.Drawing.Font("PenultimateLightItal", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(200, 5);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(242, 33);
            this.titleLabel.TabIndex = 3;
            this.titleLabel.Text = "Grand Prix Details";
            // 
            // circuitLayoutImage
            // 
            this.circuitLayoutImage.BackColor = System.Drawing.Color.Transparent;
            this.circuitLayoutImage.Image = global::F1_Simulator.Properties.Resources.zandvoort;
            this.circuitLayoutImage.Location = new System.Drawing.Point(20, 27);
            this.circuitLayoutImage.Name = "circuitLayoutImage";
            this.circuitLayoutImage.Size = new System.Drawing.Size(300, 225);
            this.circuitLayoutImage.TabIndex = 4;
            this.circuitLayoutImage.TabStop = false;
            // 
            // backLabel
            // 
            this.backLabel.AutoSize = true;
            this.backLabel.BackColor = System.Drawing.Color.Transparent;
            this.backLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.backLabel.Font = new System.Drawing.Font("PenultimateLightItal", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backLabel.ForeColor = System.Drawing.Color.Black;
            this.backLabel.Location = new System.Drawing.Point(11, 391);
            this.backLabel.Name = "backLabel";
            this.backLabel.Size = new System.Drawing.Size(101, 50);
            this.backLabel.TabIndex = 13;
            this.backLabel.Text = "< Back to\r\n Calendar";
            this.backLabel.Click += new System.EventHandler(this.backLabel_Click);
            this.backLabel.MouseEnter += new System.EventHandler(this.backLabel_MouseEnter);
            this.backLabel.MouseLeave += new System.EventHandler(this.backLabel_MouseLeave);
            // 
            // flagImage
            // 
            this.flagImage.BackColor = System.Drawing.Color.Transparent;
            this.flagImage.Image = global::F1_Simulator.Properties.Resources.usa_flag;
            this.flagImage.Location = new System.Drawing.Point(305, 40);
            this.flagImage.Name = "flagImage";
            this.flagImage.Size = new System.Drawing.Size(60, 40);
            this.flagImage.TabIndex = 14;
            this.flagImage.TabStop = false;
            // 
            // circuitNameLabel
            // 
            this.circuitNameLabel.AutoSize = true;
            this.circuitNameLabel.BackColor = System.Drawing.Color.Transparent;
            this.circuitNameLabel.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.circuitNameLabel.Font = new System.Drawing.Font("PenultimateLightItal", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.circuitNameLabel.ForeColor = System.Drawing.Color.Black;
            this.circuitNameLabel.Location = new System.Drawing.Point(15, 240);
            this.circuitNameLabel.Name = "circuitNameLabel";
            this.circuitNameLabel.Size = new System.Drawing.Size(70, 25);
            this.circuitNameLabel.TabIndex = 15;
            this.circuitNameLabel.Text = "Name: ";
            // 
            // circuitName
            // 
            this.circuitName.AutoSize = true;
            this.circuitName.BackColor = System.Drawing.Color.Transparent;
            this.circuitName.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.circuitName.Font = new System.Drawing.Font("PenultimateLightItal", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.circuitName.ForeColor = System.Drawing.Color.Black;
            this.circuitName.Location = new System.Drawing.Point(60, 240);
            this.circuitName.Name = "circuitName";
            this.circuitName.Size = new System.Drawing.Size(59, 25);
            this.circuitName.TabIndex = 16;
            this.circuitName.Text = "Name";
            // 
            // circuitTitleLabel
            // 
            this.circuitTitleLabel.AutoSize = true;
            this.circuitTitleLabel.BackColor = System.Drawing.Color.Transparent;
            this.circuitTitleLabel.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.circuitTitleLabel.Font = new System.Drawing.Font("PenultimateLightItal", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.circuitTitleLabel.ForeColor = System.Drawing.Color.Black;
            this.circuitTitleLabel.Location = new System.Drawing.Point(5, 210);
            this.circuitTitleLabel.Name = "circuitTitleLabel";
            this.circuitTitleLabel.Size = new System.Drawing.Size(132, 28);
            this.circuitTitleLabel.TabIndex = 17;
            this.circuitTitleLabel.Text = "Circuit Info";
            // 
            // circuitTypeLabel
            // 
            this.circuitTypeLabel.AutoSize = true;
            this.circuitTypeLabel.BackColor = System.Drawing.Color.Transparent;
            this.circuitTypeLabel.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.circuitTypeLabel.Font = new System.Drawing.Font("PenultimateLightItal", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.circuitTypeLabel.ForeColor = System.Drawing.Color.Black;
            this.circuitTypeLabel.Location = new System.Drawing.Point(15, 263);
            this.circuitTypeLabel.Name = "circuitTypeLabel";
            this.circuitTypeLabel.Size = new System.Drawing.Size(63, 25);
            this.circuitTypeLabel.TabIndex = 18;
            this.circuitTypeLabel.Text = "Type: ";
            // 
            // circuitType
            // 
            this.circuitType.AutoSize = true;
            this.circuitType.BackColor = System.Drawing.Color.Transparent;
            this.circuitType.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.circuitType.Font = new System.Drawing.Font("PenultimateLightItal", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.circuitType.ForeColor = System.Drawing.Color.Black;
            this.circuitType.Location = new System.Drawing.Point(53, 263);
            this.circuitType.Name = "circuitType";
            this.circuitType.Size = new System.Drawing.Size(52, 25);
            this.circuitType.TabIndex = 19;
            this.circuitType.Text = "Type";
            // 
            // circuitLengthLabel
            // 
            this.circuitLengthLabel.AutoSize = true;
            this.circuitLengthLabel.BackColor = System.Drawing.Color.Transparent;
            this.circuitLengthLabel.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.circuitLengthLabel.Font = new System.Drawing.Font("PenultimateLightItal", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.circuitLengthLabel.ForeColor = System.Drawing.Color.Black;
            this.circuitLengthLabel.Location = new System.Drawing.Point(15, 286);
            this.circuitLengthLabel.Name = "circuitLengthLabel";
            this.circuitLengthLabel.Size = new System.Drawing.Size(84, 25);
            this.circuitLengthLabel.TabIndex = 20;
            this.circuitLengthLabel.Text = "Length: ";
            // 
            // circuitLength
            // 
            this.circuitLength.AutoSize = true;
            this.circuitLength.BackColor = System.Drawing.Color.Transparent;
            this.circuitLength.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.circuitLength.Font = new System.Drawing.Font("PenultimateLightItal", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.circuitLength.ForeColor = System.Drawing.Color.Black;
            this.circuitLength.Location = new System.Drawing.Point(69, 286);
            this.circuitLength.Name = "circuitLength";
            this.circuitLength.Size = new System.Drawing.Size(73, 25);
            this.circuitLength.TabIndex = 21;
            this.circuitLength.Text = "Length";
            // 
            // circuitDownforceLabel
            // 
            this.circuitDownforceLabel.AutoSize = true;
            this.circuitDownforceLabel.BackColor = System.Drawing.Color.Transparent;
            this.circuitDownforceLabel.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.circuitDownforceLabel.Font = new System.Drawing.Font("PenultimateLightItal", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.circuitDownforceLabel.ForeColor = System.Drawing.Color.Black;
            this.circuitDownforceLabel.Location = new System.Drawing.Point(15, 309);
            this.circuitDownforceLabel.Name = "circuitDownforceLabel";
            this.circuitDownforceLabel.Size = new System.Drawing.Size(119, 25);
            this.circuitDownforceLabel.TabIndex = 22;
            this.circuitDownforceLabel.Text = "Downforce:";
            // 
            // circuitDownforce
            // 
            this.circuitDownforce.AutoSize = true;
            this.circuitDownforce.BackColor = System.Drawing.Color.Transparent;
            this.circuitDownforce.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.circuitDownforce.Font = new System.Drawing.Font("PenultimateLightItal", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.circuitDownforce.ForeColor = System.Drawing.Color.Black;
            this.circuitDownforce.Location = new System.Drawing.Point(105, 309);
            this.circuitDownforce.Name = "circuitDownforce";
            this.circuitDownforce.Size = new System.Drawing.Size(32, 25);
            this.circuitDownforce.TabIndex = 23;
            this.circuitDownforce.Text = "Df";
            // 
            // circuitFullThrottleLabel
            // 
            this.circuitFullThrottleLabel.AutoSize = true;
            this.circuitFullThrottleLabel.BackColor = System.Drawing.Color.Transparent;
            this.circuitFullThrottleLabel.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.circuitFullThrottleLabel.Font = new System.Drawing.Font("PenultimateLightItal", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.circuitFullThrottleLabel.ForeColor = System.Drawing.Color.Black;
            this.circuitFullThrottleLabel.Location = new System.Drawing.Point(15, 332);
            this.circuitFullThrottleLabel.Name = "circuitFullThrottleLabel";
            this.circuitFullThrottleLabel.Size = new System.Drawing.Size(126, 25);
            this.circuitFullThrottleLabel.TabIndex = 24;
            this.circuitFullThrottleLabel.Text = "Full throttle:";
            // 
            // circuitFullThrottle
            // 
            this.circuitFullThrottle.AutoSize = true;
            this.circuitFullThrottle.BackColor = System.Drawing.Color.Transparent;
            this.circuitFullThrottle.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.circuitFullThrottle.Font = new System.Drawing.Font("PenultimateLightItal", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.circuitFullThrottle.ForeColor = System.Drawing.Color.Black;
            this.circuitFullThrottle.Location = new System.Drawing.Point(110, 332);
            this.circuitFullThrottle.Name = "circuitFullThrottle";
            this.circuitFullThrottle.Size = new System.Drawing.Size(26, 25);
            this.circuitFullThrottle.TabIndex = 25;
            this.circuitFullThrottle.Text = "Ff";
            // 
            // circuitTyreStressLabel
            // 
            this.circuitTyreStressLabel.AutoSize = true;
            this.circuitTyreStressLabel.BackColor = System.Drawing.Color.Transparent;
            this.circuitTyreStressLabel.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.circuitTyreStressLabel.Font = new System.Drawing.Font("PenultimateLightItal", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.circuitTyreStressLabel.ForeColor = System.Drawing.Color.Black;
            this.circuitTyreStressLabel.Location = new System.Drawing.Point(15, 355);
            this.circuitTyreStressLabel.Name = "circuitTyreStressLabel";
            this.circuitTyreStressLabel.Size = new System.Drawing.Size(113, 25);
            this.circuitTyreStressLabel.TabIndex = 26;
            this.circuitTyreStressLabel.Text = "Tyre stress:";
            // 
            // circuitTyreStress
            // 
            this.circuitTyreStress.AutoSize = true;
            this.circuitTyreStress.BackColor = System.Drawing.Color.Transparent;
            this.circuitTyreStress.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.circuitTyreStress.Font = new System.Drawing.Font("PenultimateLightItal", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.circuitTyreStress.ForeColor = System.Drawing.Color.Black;
            this.circuitTyreStress.Location = new System.Drawing.Point(100, 355);
            this.circuitTyreStress.Name = "circuitTyreStress";
            this.circuitTyreStress.Size = new System.Drawing.Size(26, 25);
            this.circuitTyreStress.TabIndex = 27;
            this.circuitTyreStress.Text = "Ff";
            // 
            // GPCountryLabel
            // 
            this.GPCountryLabel.AutoSize = true;
            this.GPCountryLabel.BackColor = System.Drawing.Color.Transparent;
            this.GPCountryLabel.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.GPCountryLabel.Font = new System.Drawing.Font("PenultimateLightItal", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GPCountryLabel.ForeColor = System.Drawing.Color.Black;
            this.GPCountryLabel.Location = new System.Drawing.Point(271, 90);
            this.GPCountryLabel.Name = "GPCountryLabel";
            this.GPCountryLabel.Size = new System.Drawing.Size(106, 28);
            this.GPCountryLabel.TabIndex = 29;
            this.GPCountryLabel.Text = "Country:";
            // 
            // GPCountry
            // 
            this.GPCountry.AutoSize = true;
            this.GPCountry.BackColor = System.Drawing.Color.Transparent;
            this.GPCountry.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.GPCountry.Font = new System.Drawing.Font("PenultimateLightItal", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GPCountry.ForeColor = System.Drawing.Color.Black;
            this.GPCountry.Location = new System.Drawing.Point(348, 90);
            this.GPCountry.Name = "GPCountry";
            this.GPCountry.Size = new System.Drawing.Size(100, 28);
            this.GPCountry.TabIndex = 30;
            this.GPCountry.Text = "Country";
            // 
            // GPCityLabel
            // 
            this.GPCityLabel.AutoSize = true;
            this.GPCityLabel.BackColor = System.Drawing.Color.Transparent;
            this.GPCityLabel.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.GPCityLabel.Font = new System.Drawing.Font("PenultimateLightItal", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GPCityLabel.ForeColor = System.Drawing.Color.Black;
            this.GPCityLabel.Location = new System.Drawing.Point(271, 120);
            this.GPCityLabel.Name = "GPCityLabel";
            this.GPCityLabel.Size = new System.Drawing.Size(61, 28);
            this.GPCityLabel.TabIndex = 31;
            this.GPCityLabel.Text = "City:";
            // 
            // GPCity
            // 
            this.GPCity.AutoSize = true;
            this.GPCity.BackColor = System.Drawing.Color.Transparent;
            this.GPCity.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.GPCity.Font = new System.Drawing.Font("PenultimateLightItal", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GPCity.ForeColor = System.Drawing.Color.Black;
            this.GPCity.Location = new System.Drawing.Point(312, 120);
            this.GPCity.Name = "GPCity";
            this.GPCity.Size = new System.Drawing.Size(55, 28);
            this.GPCity.TabIndex = 32;
            this.GPCity.Text = "City";
            // 
            // GPRaceWeekLabel
            // 
            this.GPRaceWeekLabel.AutoSize = true;
            this.GPRaceWeekLabel.BackColor = System.Drawing.Color.Transparent;
            this.GPRaceWeekLabel.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.GPRaceWeekLabel.Font = new System.Drawing.Font("PenultimateLightItal", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GPRaceWeekLabel.ForeColor = System.Drawing.Color.Black;
            this.GPRaceWeekLabel.Location = new System.Drawing.Point(271, 150);
            this.GPRaceWeekLabel.Name = "GPRaceWeekLabel";
            this.GPRaceWeekLabel.Size = new System.Drawing.Size(122, 28);
            this.GPRaceWeekLabel.TabIndex = 33;
            this.GPRaceWeekLabel.Text = "Race Week:";
            // 
            // GPRaceWeek
            // 
            this.GPRaceWeek.AutoSize = true;
            this.GPRaceWeek.BackColor = System.Drawing.Color.Transparent;
            this.GPRaceWeek.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.GPRaceWeek.Font = new System.Drawing.Font("PenultimateLightItal", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GPRaceWeek.ForeColor = System.Drawing.Color.Black;
            this.GPRaceWeek.Location = new System.Drawing.Point(359, 150);
            this.GPRaceWeek.Name = "GPRaceWeek";
            this.GPRaceWeek.Size = new System.Drawing.Size(44, 28);
            this.GPRaceWeek.TabIndex = 34;
            this.GPRaceWeek.Text = "RW";
            // 
            // GPLapsLabel
            // 
            this.GPLapsLabel.AutoSize = true;
            this.GPLapsLabel.BackColor = System.Drawing.Color.Transparent;
            this.GPLapsLabel.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.GPLapsLabel.Font = new System.Drawing.Font("PenultimateLightItal", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GPLapsLabel.ForeColor = System.Drawing.Color.Black;
            this.GPLapsLabel.Location = new System.Drawing.Point(271, 180);
            this.GPLapsLabel.Name = "GPLapsLabel";
            this.GPLapsLabel.Size = new System.Drawing.Size(64, 28);
            this.GPLapsLabel.TabIndex = 35;
            this.GPLapsLabel.Text = "Laps:";
            // 
            // GPLaps
            // 
            this.GPLaps.AutoSize = true;
            this.GPLaps.BackColor = System.Drawing.Color.Transparent;
            this.GPLaps.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.GPLaps.Font = new System.Drawing.Font("PenultimateLightItal", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GPLaps.ForeColor = System.Drawing.Color.Black;
            this.GPLaps.Location = new System.Drawing.Point(315, 180);
            this.GPLaps.Name = "GPLaps";
            this.GPLaps.Size = new System.Drawing.Size(37, 28);
            this.GPLaps.TabIndex = 36;
            this.GPLaps.Text = "Lp";
            // 
            // GPDetailsScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.Controls.Add(this.GPLaps);
            this.Controls.Add(this.GPLapsLabel);
            this.Controls.Add(this.GPRaceWeek);
            this.Controls.Add(this.GPRaceWeekLabel);
            this.Controls.Add(this.GPCity);
            this.Controls.Add(this.GPCityLabel);
            this.Controls.Add(this.GPCountry);
            this.Controls.Add(this.GPCountryLabel);
            this.Controls.Add(this.circuitTyreStress);
            this.Controls.Add(this.circuitTyreStressLabel);
            this.Controls.Add(this.circuitFullThrottle);
            this.Controls.Add(this.circuitFullThrottleLabel);
            this.Controls.Add(this.circuitDownforce);
            this.Controls.Add(this.circuitDownforceLabel);
            this.Controls.Add(this.circuitLength);
            this.Controls.Add(this.circuitLengthLabel);
            this.Controls.Add(this.circuitType);
            this.Controls.Add(this.circuitTypeLabel);
            this.Controls.Add(this.circuitTitleLabel);
            this.Controls.Add(this.circuitName);
            this.Controls.Add(this.circuitNameLabel);
            this.Controls.Add(this.flagImage);
            this.Controls.Add(this.backLabel);
            this.Controls.Add(this.circuitLayoutImage);
            this.Controls.Add(this.titleLabel);
            this.Name = "GPDetailsScreen";
            this.Size = new System.Drawing.Size(888, 570);
            ((System.ComponentModel.ISupportInitialize)(this.circuitLayoutImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flagImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        public System.Windows.Forms.PictureBox circuitLayoutImage;
        private System.Windows.Forms.Label backLabel;
        private System.Windows.Forms.PictureBox flagImage;
        private System.Windows.Forms.Label circuitNameLabel;
        private System.Windows.Forms.Label circuitName;
        private System.Windows.Forms.Label circuitTitleLabel;
        private System.Windows.Forms.Label circuitTypeLabel;
        private System.Windows.Forms.Label circuitType;
        private System.Windows.Forms.Label circuitLengthLabel;
        private System.Windows.Forms.Label circuitLength;
        private System.Windows.Forms.Label circuitDownforceLabel;
        private System.Windows.Forms.Label circuitDownforce;
        private System.Windows.Forms.Label circuitFullThrottleLabel;
        private System.Windows.Forms.Label circuitFullThrottle;
        private System.Windows.Forms.Label circuitTyreStressLabel;
        private System.Windows.Forms.Label circuitTyreStress;
        private System.Windows.Forms.Label GPCountryLabel;
        private System.Windows.Forms.Label GPCountry;
        private System.Windows.Forms.Label GPCityLabel;
        private System.Windows.Forms.Label GPCity;
        private System.Windows.Forms.Label GPRaceWeekLabel;
        private System.Windows.Forms.Label GPRaceWeek;
        private System.Windows.Forms.Label GPLapsLabel;
        private System.Windows.Forms.Label GPLaps;
    }
}
