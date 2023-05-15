using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace F1_Simulator.Classes
{
    internal class BudgetHistory
    {
        public string Amount { get; set; }
        public string Event { get; set; }
        public int RaceWeek { get; set; }

        public BudgetHistory(string Amount, string Event, int RaceWeek)
        {
            this.Amount = Amount;
            this.Event = Event;
            this.RaceWeek = RaceWeek;
        }

    }
}
