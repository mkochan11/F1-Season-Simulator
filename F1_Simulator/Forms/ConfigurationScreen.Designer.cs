namespace F1_Simulator.Forms
{
    partial class ConfigurationScreen
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
            this.components = new System.ComponentModel.Container();
            this.labelWelcome = new System.Windows.Forms.Label();
            this.labelTeamColor = new System.Windows.Forms.Label();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.buttonChooseColor = new System.Windows.Forms.Button();
            this.labelColorNotChosen = new System.Windows.Forms.Label();
            this.labelNoOfRaces = new System.Windows.Forms.Label();
            this.numericNoRaces = new System.Windows.Forms.NumericUpDown();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.okLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericNoRaces)).BeginInit();
            this.SuspendLayout();
            // 
            // labelWelcome
            // 
            this.labelWelcome.AutoSize = true;
            this.labelWelcome.BackColor = System.Drawing.Color.Transparent;
            this.labelWelcome.Font = new System.Drawing.Font("PenultimateLightItal", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWelcome.Location = new System.Drawing.Point(245, 100);
            this.labelWelcome.Name = "labelWelcome";
            this.labelWelcome.Size = new System.Drawing.Size(136, 25);
            this.labelWelcome.TabIndex = 7;
            this.labelWelcome.Text = "welcomeLabel";
            this.labelWelcome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelWelcome.UseMnemonic = false;
            // 
            // labelTeamColor
            // 
            this.labelTeamColor.AutoSize = true;
            this.labelTeamColor.BackColor = System.Drawing.Color.Transparent;
            this.labelTeamColor.Font = new System.Drawing.Font("PenultimateLightItal", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTeamColor.Location = new System.Drawing.Point(260, 170);
            this.labelTeamColor.Name = "labelTeamColor";
            this.labelTeamColor.Size = new System.Drawing.Size(155, 22);
            this.labelTeamColor.TabIndex = 9;
            this.labelTeamColor.Text = "Your Team Color:";
            // 
            // buttonChooseColor
            // 
            this.buttonChooseColor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonChooseColor.Location = new System.Drawing.Point(375, 168);
            this.buttonChooseColor.Name = "buttonChooseColor";
            this.buttonChooseColor.Size = new System.Drawing.Size(57, 18);
            this.buttonChooseColor.TabIndex = 10;
            this.buttonChooseColor.Text = "Choose";
            this.buttonChooseColor.UseVisualStyleBackColor = true;
            this.buttonChooseColor.Click += new System.EventHandler(this.buttonChooseColour_Click);
            // 
            // labelColorNotChosen
            // 
            this.labelColorNotChosen.AutoSize = true;
            this.labelColorNotChosen.BackColor = System.Drawing.Color.Transparent;
            this.labelColorNotChosen.Font = new System.Drawing.Font("PenultimateLightItal", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelColorNotChosen.ForeColor = System.Drawing.Color.Red;
            this.labelColorNotChosen.Location = new System.Drawing.Point(436, 172);
            this.labelColorNotChosen.Name = "labelColorNotChosen";
            this.labelColorNotChosen.Size = new System.Drawing.Size(83, 14);
            this.labelColorNotChosen.TabIndex = 12;
            this.labelColorNotChosen.Text = "Choose color";
            // 
            // labelNoOfRaces
            // 
            this.labelNoOfRaces.AutoSize = true;
            this.labelNoOfRaces.BackColor = System.Drawing.Color.Transparent;
            this.labelNoOfRaces.Font = new System.Drawing.Font("PenultimateLightItal", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNoOfRaces.Location = new System.Drawing.Point(263, 205);
            this.labelNoOfRaces.Name = "labelNoOfRaces";
            this.labelNoOfRaces.Size = new System.Drawing.Size(152, 22);
            this.labelNoOfRaces.TabIndex = 13;
            this.labelNoOfRaces.Text = "Number of races:";
            // 
            // numericNoRaces
            // 
            this.numericNoRaces.Location = new System.Drawing.Point(375, 203);
            this.numericNoRaces.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.numericNoRaces.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericNoRaces.Name = "numericNoRaces";
            this.numericNoRaces.Size = new System.Drawing.Size(34, 20);
            this.numericNoRaces.TabIndex = 14;
            this.numericNoRaces.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericNoRaces.Value = new decimal(new int[] {
            23,
            0,
            0,
            0});
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // okLabel
            // 
            this.okLabel.AutoSize = true;
            this.okLabel.BackColor = System.Drawing.Color.Transparent;
            this.okLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.okLabel.Font = new System.Drawing.Font("PenultimateLightItal", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.okLabel.ForeColor = System.Drawing.Color.Black;
            this.okLabel.Location = new System.Drawing.Point(321, 242);
            this.okLabel.Name = "okLabel";
            this.okLabel.Size = new System.Drawing.Size(44, 28);
            this.okLabel.TabIndex = 15;
            this.okLabel.Text = "Ok";
            this.okLabel.Click += new System.EventHandler(this.okLabel_Click);
            this.okLabel.MouseEnter += new System.EventHandler(this.okLabel_MouseEnter);
            this.okLabel.MouseLeave += new System.EventHandler(this.okLabel_MouseLeave);
            // 
            // ConfigurationScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::F1_Simulator.Properties.Resources.bg;
            this.Controls.Add(this.okLabel);
            this.Controls.Add(this.numericNoRaces);
            this.Controls.Add(this.labelNoOfRaces);
            this.Controls.Add(this.labelColorNotChosen);
            this.Controls.Add(this.buttonChooseColor);
            this.Controls.Add(this.labelTeamColor);
            this.Controls.Add(this.labelWelcome);
            this.Name = "ConfigurationScreen";
            this.Size = new System.Drawing.Size(888, 559);
            ((System.ComponentModel.ISupportInitialize)(this.numericNoRaces)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelWelcome;
        private System.Windows.Forms.Label labelTeamColor;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button buttonChooseColor;
        private System.Windows.Forms.Label labelColorNotChosen;
        private System.Windows.Forms.Label labelNoOfRaces;
        private System.Windows.Forms.NumericUpDown numericNoRaces;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label okLabel;
    }
}
