namespace F1_Simulator.Forms
{
    partial class BudgetHistoryScreen
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
            this.budgetHistoryGridView = new System.Windows.Forms.DataGridView();
            this.backLabel = new System.Windows.Forms.Label();
            this.RaceWeekColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EventColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AmountColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.budgetHistoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.budgetLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.budgetHistoryGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.budgetHistoryBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.BackColor = System.Drawing.Color.Transparent;
            this.titleLabel.Font = new System.Drawing.Font("PenultimateLightItal", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(275, 10);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(211, 33);
            this.titleLabel.TabIndex = 2;
            this.titleLabel.Text = "Budget History";
            // 
            // budgetHistoryGridView
            // 
            this.budgetHistoryGridView.AllowUserToResizeColumns = false;
            this.budgetHistoryGridView.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.budgetHistoryGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.budgetHistoryGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RaceWeekColumn,
            this.EventColumn,
            this.AmountColumn});
            this.budgetHistoryGridView.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.budgetHistoryGridView.Location = new System.Drawing.Point(157, 46);
            this.budgetHistoryGridView.Name = "budgetHistoryGridView";
            this.budgetHistoryGridView.Size = new System.Drawing.Size(401, 332);
            this.budgetHistoryGridView.TabIndex = 3;
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
            this.backLabel.Size = new System.Drawing.Size(181, 25);
            this.backLabel.TabIndex = 11;
            this.backLabel.Text = "< Back to My Team";
            this.backLabel.Click += new System.EventHandler(this.backLabel_Click);
            this.backLabel.MouseEnter += new System.EventHandler(this.backLabel_MouseEnter);
            this.backLabel.MouseLeave += new System.EventHandler(this.backLabel_MouseLeave);
            // 
            // RaceWeekColumn
            // 
            this.RaceWeekColumn.DataPropertyName = "RaceWeek";
            this.RaceWeekColumn.HeaderText = "Race Week";
            this.RaceWeekColumn.Name = "RaceWeekColumn";
            this.RaceWeekColumn.ReadOnly = true;
            // 
            // EventColumn
            // 
            this.EventColumn.DataPropertyName = "Event";
            this.EventColumn.HeaderText = "Event";
            this.EventColumn.Name = "EventColumn";
            this.EventColumn.ReadOnly = true;
            this.EventColumn.Width = 295;
            // 
            // AmountColumn
            // 
            this.AmountColumn.DataPropertyName = "Amount";
            this.AmountColumn.HeaderText = "Amount ($)";
            this.AmountColumn.Name = "AmountColumn";
            this.AmountColumn.ReadOnly = true;
            this.AmountColumn.Width = 110;
            // 
            // budgetHistoryBindingSource
            // 
            this.budgetHistoryBindingSource.DataSource = typeof(F1_Simulator.Classes.BudgetHistory);
            // 
            // budgetLabel
            // 
            this.budgetLabel.AutoSize = true;
            this.budgetLabel.BackColor = System.Drawing.Color.Transparent;
            this.budgetLabel.Font = new System.Drawing.Font("PenultimateLightItal", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.budgetLabel.Location = new System.Drawing.Point(12, 27);
            this.budgetLabel.Name = "budgetLabel";
            this.budgetLabel.Size = new System.Drawing.Size(90, 25);
            this.budgetLabel.TabIndex = 22;
            this.budgetLabel.Text = "Budget: ";
            // 
            // BudgetHistoryScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::F1_Simulator.Properties.Resources.bg;
            this.Controls.Add(this.budgetLabel);
            this.Controls.Add(this.backLabel);
            this.Controls.Add(this.budgetHistoryGridView);
            this.Controls.Add(this.titleLabel);
            this.Name = "BudgetHistoryScreen";
            this.Size = new System.Drawing.Size(888, 559);
            ((System.ComponentModel.ISupportInitialize)(this.budgetHistoryGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.budgetHistoryBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.BindingSource budgetHistoryBindingSource;
        private System.Windows.Forms.DataGridView budgetHistoryGridView;
        private System.Windows.Forms.Label backLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn RaceWeekColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn EventColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn AmountColumn;
        private System.Windows.Forms.Label budgetLabel;
    }
}
