using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace F1_Simulator.Classes
{
    internal class Controller
    {
        public DateTime Date;
        public Player Player;
        public Season Season;
        public Controller()
        {
            this.Date = DateTime.Now;
        }

        public void CreatePlayer(string Name, string TeamName, string CarName)
        {
            this.Player = new Player(Name, TeamName, CarName);
        }

        public void updatePlayersTeamColor(Color color)
        {
            this.Player.Team.Color = color;
        }

        public void SpendPlayersMoney(float  amount)
        {
            this.Player.Team.Budget -= amount;
        }

        public void AddMoneyToPlayersbudget(float amount)
        {
            this.Player.Team.Budget += amount;
        }
    }
}
