using F1_Simulator.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace F1_Simulator.Forms
{
    partial class BudgetHistoryScreen : UserControl
    {
        Start Start;
        public BudgetHistoryScreen()
        {
            InitializeComponent();
        }

        public void Initialize(Start start)
        {
            Start = start;
            this.budgetLabel.Text = "Budget: " + Start.GetPlayerTeam().Budget.ToString() + "$";
            if (budgetHistoryGridView.DataSource == null)
            {
                budgetHistoryGridView.DataSource = Start.GetPlayerTeam().BudgetHistory;
            }
            budgetHistoryGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        // Handling back label - mouse interaction
        private void backLabel_Click(object sender, EventArgs e)
        {
            this.Start.MyTeamScreen_Load();
            this.Hide();
        }
        private void backLabel_MouseEnter(object sender, EventArgs e)
        {
            this.backLabel.ForeColor = Color.Firebrick;
        }
        private void backLabel_MouseLeave(object sender, EventArgs e)
        {
            this.backLabel.ForeColor = Color.Black;
        }
    }
}
