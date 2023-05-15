using System.Windows.Forms;

namespace F1_Simulator.Forms
{
    partial class CalendarScreen
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
            this.grandPrixsList = new System.Windows.Forms.ListView();
            this.RaceWeekColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.GrandPrixColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.titleLabel = new System.Windows.Forms.Label();
            this.backLabel = new System.Windows.Forms.Label();
            this.gpDetailsLabel = new System.Windows.Forms.Label();
            this.gpResultsLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // grandPrixsList
            // 
            this.grandPrixsList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.RaceWeekColumn,
            this.GrandPrixColumn});
            this.grandPrixsList.FullRowSelect = true;
            this.grandPrixsList.GridLines = true;
            this.grandPrixsList.HideSelection = false;
            this.grandPrixsList.Location = new System.Drawing.Point(200, 30);
            this.grandPrixsList.Name = "grandPrixsList";
            this.grandPrixsList.Size = new System.Drawing.Size(285, 395);
            this.grandPrixsList.TabIndex = 0;
            this.grandPrixsList.UseCompatibleStateImageBehavior = false;
            this.grandPrixsList.View = System.Windows.Forms.View.Details;
            this.grandPrixsList.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.onItemSelectionChanged);
            // 
            // RaceWeekColumn
            // 
            this.RaceWeekColumn.Text = "RaceWeek";
            this.RaceWeekColumn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.RaceWeekColumn.Width = 75;
            // 
            // GrandPrixColumn
            // 
            this.GrandPrixColumn.Text = "GrandPrix";
            this.GrandPrixColumn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.GrandPrixColumn.Width = 250;
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.BackColor = System.Drawing.Color.Transparent;
            this.titleLabel.Font = new System.Drawing.Font("PenultimateLightItal", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(278, 0);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(127, 33);
            this.titleLabel.TabIndex = 2;
            this.titleLabel.Text = "Calendar";
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
            this.backLabel.TabIndex = 12;
            this.backLabel.Text = "< Back to \r\nMain Menu";
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
            this.gpDetailsLabel.Location = new System.Drawing.Point(11, 61);
            this.gpDetailsLabel.Name = "gpDetailsLabel";
            this.gpDetailsLabel.Size = new System.Drawing.Size(195, 25);
            this.gpDetailsLabel.TabIndex = 13;
            this.gpDetailsLabel.Text = "> Grand Prix Details";
            this.gpDetailsLabel.Click += new System.EventHandler(this.gpDetailsLabel_Click);
            this.gpDetailsLabel.MouseEnter += new System.EventHandler(this.gpDetailsLabel_MouseEnter);
            this.gpDetailsLabel.MouseLeave += new System.EventHandler(this.gpDetailsLabel_MouseLeave);
            // 
            // gpResultsLabel
            // 
            this.gpResultsLabel.AutoSize = true;
            this.gpResultsLabel.BackColor = System.Drawing.Color.Transparent;
            this.gpResultsLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gpResultsLabel.Font = new System.Drawing.Font("PenultimateLightItal", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpResultsLabel.ForeColor = System.Drawing.Color.Black;
            this.gpResultsLabel.Location = new System.Drawing.Point(11, 96);
            this.gpResultsLabel.Name = "gpResultsLabel";
            this.gpResultsLabel.Size = new System.Drawing.Size(198, 25);
            this.gpResultsLabel.TabIndex = 14;
            this.gpResultsLabel.Text = "> Grand Prix Results";
            this.gpResultsLabel.Click += new System.EventHandler(this.gpResultsLabel_Click);
            this.gpResultsLabel.MouseEnter += new System.EventHandler(this.gpResultsLabel_MouseEnter);
            this.gpResultsLabel.MouseLeave += new System.EventHandler(this.gpResultsLabel_MouseLeave);
            // 
            // CalendarScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::F1_Simulator.Properties.Resources.bg;
            this.Controls.Add(this.gpResultsLabel);
            this.Controls.Add(this.gpDetailsLabel);
            this.Controls.Add(this.backLabel);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.grandPrixsList);
            this.Name = "CalendarScreen";
            this.Size = new System.Drawing.Size(888, 559);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView grandPrixsList;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.ColumnHeader RaceWeekColumn;
        private System.Windows.Forms.ColumnHeader GrandPrixColumn;
        private System.Windows.Forms.Label backLabel;
        private System.Windows.Forms.Label gpDetailsLabel;
        private System.Windows.Forms.Label gpResultsLabel;
    }
}
