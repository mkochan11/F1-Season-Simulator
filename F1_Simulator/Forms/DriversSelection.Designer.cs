using System.Data;
using System.Windows.Forms;

namespace F1_Simulator.Forms
{
    partial class DriversSelection
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.checkBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Surname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DriverName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Skill = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RaceSalary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.okLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.Font = new System.Drawing.Font("PenultimateLightItal", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(211, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(238, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "Choose your Drivers";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("PenultimateLightItal", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(269, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(261, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Your starting budget:  5 000 000$";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.checkBoxColumn,
            this.Number,
            this.Surname,
            this.DriverName,
            this.Skill,
            this.RaceSalary});
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dataGridView1.Location = new System.Drawing.Point(96, 49);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(443, 357);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // checkBoxColumn
            // 
            this.checkBoxColumn.HeaderText = "";
            this.checkBoxColumn.Name = "checkBoxColumn";
            this.checkBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.checkBoxColumn.Width = 20;
            // 
            // Number
            // 
            this.Number.DataPropertyName = "Number";
            this.Number.HeaderText = "Number";
            this.Number.Name = "Number";
            // 
            // Surname
            // 
            this.Surname.DataPropertyName = "Surname";
            this.Surname.HeaderText = "Surname";
            this.Surname.Name = "Surname";
            // 
            // DriverName
            // 
            this.DriverName.DataPropertyName = "Name";
            this.DriverName.HeaderText = "Name";
            this.DriverName.Name = "DriverName";
            // 
            // Skill
            // 
            this.Skill.DataPropertyName = "Skill";
            this.Skill.HeaderText = "Skill";
            this.Skill.Name = "Skill";
            // 
            // RaceSalary
            // 
            this.RaceSalary.DataPropertyName = "RaceSalary";
            this.RaceSalary.HeaderText = "Race Salary";
            this.RaceSalary.Name = "RaceSalary";
            // 
            // okLabel
            // 
            this.okLabel.AutoSize = true;
            this.okLabel.BackColor = System.Drawing.Color.Transparent;
            this.okLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.okLabel.Font = new System.Drawing.Font("PenultimateLightItal", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.okLabel.ForeColor = System.Drawing.Color.Black;
            this.okLabel.Location = new System.Drawing.Point(307, 409);
            this.okLabel.Name = "okLabel";
            this.okLabel.Size = new System.Drawing.Size(44, 28);
            this.okLabel.TabIndex = 15;
            this.okLabel.Text = "Ok";
            this.okLabel.Click += new System.EventHandler(this.okLabel_Click);
            this.okLabel.MouseEnter += new System.EventHandler(this.okLabel_MouseEnter);
            this.okLabel.MouseLeave += new System.EventHandler(this.okLabel_MouseLeave);
            // 
            // DriversSelection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::F1_Simulator.Properties.Resources.bg;
            this.Controls.Add(this.okLabel);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Name = "DriversSelection";
            this.Size = new System.Drawing.Size(888, 559);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private DataGridViewCheckBoxColumn checkBoxColumn;
        private DataGridViewTextBoxColumn Number;
        private DataGridViewTextBoxColumn Surname;
        private DataGridViewTextBoxColumn DriverName;
        private DataGridViewTextBoxColumn Skill;
        private DataGridViewTextBoxColumn RaceSalary;
        private Label okLabel;
    }
}
