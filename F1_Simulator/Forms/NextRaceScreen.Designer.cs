namespace F1_Simulator.Forms
{
    partial class NextRaceScreen
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
            this.gpLabel = new System.Windows.Forms.Label();
            this.flagImage = new System.Windows.Forms.PictureBox();
            this.circuitLayoutImage = new System.Windows.Forms.PictureBox();
            this.backLabel = new System.Windows.Forms.Label();
            this.gpDetailsLabel = new System.Windows.Forms.Label();
            this.simulateLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.flagImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.circuitLayoutImage)).BeginInit();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.BackColor = System.Drawing.Color.Transparent;
            this.titleLabel.Font = new System.Drawing.Font("PenultimateLightItal", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(270, 14);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(132, 33);
            this.titleLabel.TabIndex = 4;
            this.titleLabel.Text = "Next Race";
            // 
            // gpLabel
            // 
            this.gpLabel.AutoSize = true;
            this.gpLabel.BackColor = System.Drawing.Color.Transparent;
            this.gpLabel.Font = new System.Drawing.Font("PenultimateLightItal", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpLabel.Location = new System.Drawing.Point(220, 47);
            this.gpLabel.Name = "gpLabel";
            this.gpLabel.Size = new System.Drawing.Size(141, 31);
            this.gpLabel.TabIndex = 5;
            this.gpLabel.Text = "Grand Prix";
            // 
            // flagImage
            // 
            this.flagImage.BackColor = System.Drawing.Color.Transparent;
            this.flagImage.Image = global::F1_Simulator.Properties.Resources.usa_flag;
            this.flagImage.Location = new System.Drawing.Point(285, 88);
            this.flagImage.Name = "flagImage";
            this.flagImage.Size = new System.Drawing.Size(60, 40);
            this.flagImage.TabIndex = 15;
            this.flagImage.TabStop = false;
            // 
            // circuitLayoutImage
            // 
            this.circuitLayoutImage.BackColor = System.Drawing.Color.Transparent;
            this.circuitLayoutImage.Image = global::F1_Simulator.Properties.Resources.zandvoort;
            this.circuitLayoutImage.Location = new System.Drawing.Point(205, 134);
            this.circuitLayoutImage.Name = "circuitLayoutImage";
            this.circuitLayoutImage.Size = new System.Drawing.Size(300, 225);
            this.circuitLayoutImage.TabIndex = 16;
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
            this.backLabel.Size = new System.Drawing.Size(114, 50);
            this.backLabel.TabIndex = 17;
            this.backLabel.Text = "< Back to\r\n Main Menu";
            this.backLabel.Click += new System.EventHandler(this.backLabel_Click);
            this.backLabel.MouseEnter += new System.EventHandler(this.backLabel_MouseEnter);
            this.backLabel.MouseLeave += new System.EventHandler(this.backLabel_MouseLeave);
            // 
            // gpDetailsLabel
            // 
            this.gpDetailsLabel.AutoSize = true;
            this.gpDetailsLabel.BackColor = System.Drawing.Color.Transparent;
            this.gpDetailsLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gpDetailsLabel.Font = new System.Drawing.Font("PenultimateLightItal", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpDetailsLabel.ForeColor = System.Drawing.Color.Black;
            this.gpDetailsLabel.Location = new System.Drawing.Point(237, 314);
            this.gpDetailsLabel.Name = "gpDetailsLabel";
            this.gpDetailsLabel.Size = new System.Drawing.Size(211, 25);
            this.gpDetailsLabel.TabIndex = 18;
            this.gpDetailsLabel.Text = "> Grand Prix details <";
            this.gpDetailsLabel.Click += new System.EventHandler(this.gpDetailsLabel_Click);
            this.gpDetailsLabel.MouseEnter += new System.EventHandler(this.gpDetailsLabel_MouseEnter);
            this.gpDetailsLabel.MouseLeave += new System.EventHandler(this.gpDetailsLabel_MouseLeave);
            // 
            // simulateLabel
            // 
            this.simulateLabel.AutoSize = true;
            this.simulateLabel.BackColor = System.Drawing.Color.Transparent;
            this.simulateLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.simulateLabel.Font = new System.Drawing.Font("PenultimateLightItal", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simulateLabel.ForeColor = System.Drawing.Color.Black;
            this.simulateLabel.Location = new System.Drawing.Point(498, 391);
            this.simulateLabel.Name = "simulateLabel";
            this.simulateLabel.Size = new System.Drawing.Size(219, 28);
            this.simulateLabel.TabIndex = 19;
            this.simulateLabel.Text = "Simulate Next Race >\r\n";
            this.simulateLabel.MouseEnter += new System.EventHandler(this.simulateLabel_MouseEnter);
            this.simulateLabel.MouseLeave += new System.EventHandler(this.simulateLabel_MouseLeave);
            // 
            // NextRaceScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::F1_Simulator.Properties.Resources.bg;
            this.Controls.Add(this.simulateLabel);
            this.Controls.Add(this.gpDetailsLabel);
            this.Controls.Add(this.backLabel);
            this.Controls.Add(this.circuitLayoutImage);
            this.Controls.Add(this.flagImage);
            this.Controls.Add(this.gpLabel);
            this.Controls.Add(this.titleLabel);
            this.Name = "NextRaceScreen";
            this.Size = new System.Drawing.Size(888, 570);
            ((System.ComponentModel.ISupportInitialize)(this.flagImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.circuitLayoutImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label gpLabel;
        private System.Windows.Forms.PictureBox flagImage;
        public System.Windows.Forms.PictureBox circuitLayoutImage;
        private System.Windows.Forms.Label backLabel;
        private System.Windows.Forms.Label gpDetailsLabel;
        private System.Windows.Forms.Label simulateLabel;
    }
}
