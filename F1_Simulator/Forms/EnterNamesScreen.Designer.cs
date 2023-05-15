using System;

namespace F1_Simulator.Forms
{
    partial class EnterNamesScreen
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
            this.labelEnterName = new System.Windows.Forms.Label();
            this.textBoxPlayerName = new System.Windows.Forms.TextBox();
            this.labelEmptyName = new System.Windows.Forms.Label();
            this.labelEnterTeamName = new System.Windows.Forms.Label();
            this.textBoxTeamName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.carNameTextBox = new System.Windows.Forms.TextBox();
            this.okLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelEnterName
            // 
            this.labelEnterName.AutoSize = true;
            this.labelEnterName.BackColor = System.Drawing.Color.Transparent;
            this.labelEnterName.Font = new System.Drawing.Font("PenultimateLightItal", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEnterName.Location = new System.Drawing.Point(281, 117);
            this.labelEnterName.Name = "labelEnterName";
            this.labelEnterName.Size = new System.Drawing.Size(151, 22);
            this.labelEnterName.TabIndex = 2;
            this.labelEnterName.Text = "Enter your name:";
            // 
            // textBoxPlayerName
            // 
            this.textBoxPlayerName.Location = new System.Drawing.Point(258, 139);
            this.textBoxPlayerName.Name = "textBoxPlayerName";
            this.textBoxPlayerName.Size = new System.Drawing.Size(160, 20);
            this.textBoxPlayerName.TabIndex = 3;
            // 
            // labelEmptyName
            // 
            this.labelEmptyName.AutoSize = true;
            this.labelEmptyName.BackColor = System.Drawing.Color.Transparent;
            this.labelEmptyName.Font = new System.Drawing.Font("PenultimateLightItal", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmptyName.ForeColor = System.Drawing.Color.Red;
            this.labelEmptyName.Location = new System.Drawing.Point(304, 298);
            this.labelEmptyName.Name = "labelEmptyName";
            this.labelEmptyName.Size = new System.Drawing.Size(83, 17);
            this.labelEmptyName.TabIndex = 5;
            this.labelEmptyName.Text = "Enter names";
            // 
            // labelEnterTeamName
            // 
            this.labelEnterTeamName.AutoSize = true;
            this.labelEnterTeamName.BackColor = System.Drawing.Color.Transparent;
            this.labelEnterTeamName.Font = new System.Drawing.Font("PenultimateLightItal", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEnterTeamName.Location = new System.Drawing.Point(265, 167);
            this.labelEnterTeamName.Name = "labelEnterTeamName";
            this.labelEnterTeamName.Size = new System.Drawing.Size(194, 22);
            this.labelEnterTeamName.TabIndex = 7;
            this.labelEnterTeamName.Text = "Enter your Team name:";
            // 
            // textBoxTeamName
            // 
            this.textBoxTeamName.Location = new System.Drawing.Point(258, 188);
            this.textBoxTeamName.Name = "textBoxTeamName";
            this.textBoxTeamName.Size = new System.Drawing.Size(160, 20);
            this.textBoxTeamName.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("PenultimateLightItal", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(268, 217);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 22);
            this.label1.TabIndex = 12;
            this.label1.Text = "Enter your Car name:";
            // 
            // carNameTextBox
            // 
            this.carNameTextBox.Location = new System.Drawing.Point(258, 238);
            this.carNameTextBox.Name = "carNameTextBox";
            this.carNameTextBox.Size = new System.Drawing.Size(160, 20);
            this.carNameTextBox.TabIndex = 13;
            // 
            // okLabel
            // 
            this.okLabel.AutoSize = true;
            this.okLabel.BackColor = System.Drawing.Color.Transparent;
            this.okLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.okLabel.Font = new System.Drawing.Font("PenultimateLightItal", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.okLabel.ForeColor = System.Drawing.Color.Black;
            this.okLabel.Location = new System.Drawing.Point(318, 265);
            this.okLabel.Name = "okLabel";
            this.okLabel.Size = new System.Drawing.Size(44, 28);
            this.okLabel.TabIndex = 14;
            this.okLabel.Text = "Ok";
            this.okLabel.Click += new System.EventHandler(this.okLabel_Click);
            this.okLabel.MouseEnter += new System.EventHandler(this.okLabel_MouseEnter);
            this.okLabel.MouseLeave += new System.EventHandler(this.okLabel_MouseLeave);
            // 
            // EnterNamesScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::F1_Simulator.Properties.Resources.bg;
            this.Controls.Add(this.okLabel);
            this.Controls.Add(this.carNameTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxTeamName);
            this.Controls.Add(this.labelEnterTeamName);
            this.Controls.Add(this.labelEmptyName);
            this.Controls.Add(this.textBoxPlayerName);
            this.Controls.Add(this.labelEnterName);
            this.Name = "EnterNamesScreen";
            this.Size = new System.Drawing.Size(888, 559);
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private System.Windows.Forms.Label labelEnterName;
        private System.Windows.Forms.TextBox textBoxPlayerName;
        private System.Windows.Forms.Label labelEmptyName;
        private System.Windows.Forms.Label labelEnterTeamName;
        private System.Windows.Forms.TextBox textBoxTeamName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox carNameTextBox;
        private System.Windows.Forms.Label okLabel;
    }
}
