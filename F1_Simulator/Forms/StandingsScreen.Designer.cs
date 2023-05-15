using F1_Simulator.Classes;
using System;

namespace F1_Simulator.Forms
{
    partial class StandingsScreen
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
            this.titleLabel = new System.Windows.Forms.Label();
            this.driversLabel = new System.Windows.Forms.Label();
            this.teamsLabel = new System.Windows.Forms.Label();
            this.driverBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.backLabel = new System.Windows.Forms.Label();
            this.driversStandingsList = new System.Windows.Forms.ListView();
            this.driversPositionColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.driversNameSurnameColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.driversTeamNameColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.driversPointsColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.teamsStandingsList = new System.Windows.Forms.ListView();
            this.teamsPostitionColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.teamsTeamColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.teamsPointsColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.teamBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.standingsScreenBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.driverBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teamBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.standingsScreenBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.BackColor = System.Drawing.Color.Transparent;
            this.titleLabel.Font = new System.Drawing.Font("PenultimateLightItal", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(278, -1);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(137, 33);
            this.titleLabel.TabIndex = 1;
            this.titleLabel.Text = "Standings";
            // 
            // driversLabel
            // 
            this.driversLabel.AutoSize = true;
            this.driversLabel.BackColor = System.Drawing.Color.Transparent;
            this.driversLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.driversLabel.Font = new System.Drawing.Font("PenultimateLightItal", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.driversLabel.ForeColor = System.Drawing.Color.Black;
            this.driversLabel.Location = new System.Drawing.Point(144, 22);
            this.driversLabel.Name = "driversLabel";
            this.driversLabel.Size = new System.Drawing.Size(173, 25);
            this.driversLabel.TabIndex = 4;
            this.driversLabel.Text = "Drivers Standings";
            this.driversLabel.Click += new System.EventHandler(this.driversLabel_Click);
            this.driversLabel.MouseEnter += new System.EventHandler(this.driversLabel_MouseEnter);
            this.driversLabel.MouseLeave += new System.EventHandler(this.driversLabel_MouseLeave);
            // 
            // teamsLabel
            // 
            this.teamsLabel.AutoSize = true;
            this.teamsLabel.BackColor = System.Drawing.Color.Transparent;
            this.teamsLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.teamsLabel.Font = new System.Drawing.Font("PenultimateLightItal", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teamsLabel.ForeColor = System.Drawing.Color.Black;
            this.teamsLabel.Location = new System.Drawing.Point(374, 22);
            this.teamsLabel.Name = "teamsLabel";
            this.teamsLabel.Size = new System.Drawing.Size(155, 25);
            this.teamsLabel.TabIndex = 5;
            this.teamsLabel.Text = "Teams Standings";
            this.teamsLabel.Click += new System.EventHandler(this.teamsLabel_Click);
            this.teamsLabel.MouseEnter += new System.EventHandler(this.teamsLabel_MouseEnter);
            this.teamsLabel.MouseLeave += new System.EventHandler(this.teamsLabel_MouseLeave);
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
            this.backLabel.Size = new System.Drawing.Size(108, 50);
            this.backLabel.TabIndex = 11;
            this.backLabel.Text = "< Back to \r\nMain Menu";
            this.backLabel.Click += new System.EventHandler(this.backLabel_Click);
            this.backLabel.MouseEnter += new System.EventHandler(this.backLabel_MouseEnter);
            this.backLabel.MouseLeave += new System.EventHandler(this.backLabel_MouseLeave);
            // 
            // driversStandingsList
            // 
            this.driversStandingsList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.driversPositionColumn,
            this.driversNameSurnameColumn,
            this.driversTeamNameColumn,
            this.driversPointsColumn});
            this.driversStandingsList.GridLines = true;
            this.driversStandingsList.HideSelection = false;
            this.driversStandingsList.Location = new System.Drawing.Point(165, 50);
            this.driversStandingsList.Name = "driversStandingsList";
            this.driversStandingsList.Size = new System.Drawing.Size(305, 377);
            this.driversStandingsList.TabIndex = 12;
            this.driversStandingsList.UseCompatibleStateImageBehavior = false;
            this.driversStandingsList.View = System.Windows.Forms.View.Details;
            // 
            // driversPositionColumn
            // 
            this.driversPositionColumn.Text = "Pos.";
            this.driversPositionColumn.Width = 40;
            // 
            // driversNameSurnameColumn
            // 
            this.driversNameSurnameColumn.Text = "Driver";
            this.driversNameSurnameColumn.Width = 150;
            // 
            // driversTeamNameColumn
            // 
            this.driversTeamNameColumn.Text = "Team";
            this.driversTeamNameColumn.Width = 150;
            // 
            // driversPointsColumn
            // 
            this.driversPointsColumn.Text = "Points";
            // 
            // teamsStandingsList
            // 
            this.teamsStandingsList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.teamsPostitionColumn,
            this.teamsTeamColumn,
            this.teamsPointsColumn});
            this.teamsStandingsList.GridLines = true;
            this.teamsStandingsList.HideSelection = false;
            this.teamsStandingsList.Location = new System.Drawing.Point(198, 50);
            this.teamsStandingsList.Name = "teamsStandingsList";
            this.teamsStandingsList.Size = new System.Drawing.Size(253, 200);
            this.teamsStandingsList.TabIndex = 13;
            this.teamsStandingsList.UseCompatibleStateImageBehavior = false;
            this.teamsStandingsList.View = System.Windows.Forms.View.Details;
            // 
            // teamsPostitionColumn
            // 
            this.teamsPostitionColumn.Text = "Pos.";
            this.teamsPostitionColumn.Width = 40;
            // 
            // teamsTeamColumn
            // 
            this.teamsTeamColumn.Text = "Team";
            this.teamsTeamColumn.Width = 220;
            // 
            // teamsPointsColumn
            // 
            this.teamsPointsColumn.Text = "Points";
            this.teamsPointsColumn.Width = 70;
            // 
            // teamBindingSource
            // 
            this.teamBindingSource.DataSource = typeof(F1_Simulator.Classes.Team);
            // 
            // standingsScreenBindingSource
            // 
            this.standingsScreenBindingSource.DataSource = typeof(F1_Simulator.Forms.StandingsScreen);
            // 
            // StandingsScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::F1_Simulator.Properties.Resources.bg;
            this.Controls.Add(this.teamsStandingsList);
            this.Controls.Add(this.driversStandingsList);
            this.Controls.Add(this.backLabel);
            this.Controls.Add(this.teamsLabel);
            this.Controls.Add(this.driversLabel);
            this.Controls.Add(this.titleLabel);
            this.Name = "StandingsScreen";
            this.Size = new System.Drawing.Size(888, 559);
            ((System.ComponentModel.ISupportInitialize)(this.driverBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teamBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.standingsScreenBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }



        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label driversLabel;
        private System.Windows.Forms.Label teamsLabel;
        private System.Windows.Forms.BindingSource driverBindingSource;
        private System.Windows.Forms.BindingSource standingsScreenBindingSource;
        private System.Windows.Forms.BindingSource teamBindingSource;
        private System.Windows.Forms.Label backLabel;
        private System.Windows.Forms.ListView driversStandingsList;
        private System.Windows.Forms.ColumnHeader driversPositionColumn;
        private System.Windows.Forms.ColumnHeader driversNameSurnameColumn;
        private System.Windows.Forms.ColumnHeader driversTeamNameColumn;
        private System.Windows.Forms.ColumnHeader driversPointsColumn;
        private System.Windows.Forms.ListView teamsStandingsList;
        private System.Windows.Forms.ColumnHeader teamsPostitionColumn;
        private System.Windows.Forms.ColumnHeader teamsTeamColumn;
        private System.Windows.Forms.ColumnHeader teamsPointsColumn;
    }
}
