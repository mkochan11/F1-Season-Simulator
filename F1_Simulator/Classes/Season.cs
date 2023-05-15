using F1_Simulator.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace F1_Simulator.Classes
{
    internal class Season
    {
        public int Year;
        public int RaceWeek;
        public int NumberOfRaces;
        Random random;
        public List<Driver> Drivers;
        public List<Team>  Teams;
        public List<GrandPrix> GrandPrixs;
        public List<Circuit> Circuits; 
        
        
        public Season(int Year, int NumberOfRaces)
        {
            this.Year = Year;
            RaceWeek = 1;
            this.NumberOfRaces = NumberOfRaces;
            Drivers = new List<Driver>();
            Teams = new List<Team>();
            Circuits = new List<Circuit>();
            GrandPrixs = new List<GrandPrix>();
            random = new Random();
            this.GenerateDrivers();
        }

        public void GenerateDrivers()
        {
            string[] driversNames = { "Alexander", "Antonio", "Benjamin", "Carlos", "Christian", "Daniel", "David", "Diego", "Edward", "Emanuel", "Ethan", "Felipe", "Francisco", "Gabriel", "George", "Gustavo", "Hector", "Henry", "Hugo", "Isaac", "Ivan", "Jack", "Jacob", "James", "Javier", "Jefferson", "Jeremy", "Jesse", "Joaquín", "John", "Jonathan", "Jordan", "Joseph", "Juan", "Julian", "Kevin", "Leonardo", "Liam", "Lucas", "Luis", "Luke", "Manuel", "Marcus", "Mario", "Mark", "Martin", "Matías", "Matthew", "Miguel", "Nathan", "Nathaniel", "Nicolas", "Oliver", "Oscar", "Pablo", "Patrick", "Paul", "Peter", "Philip", "Rafael", "Raul", "Richard", "Robert", "Rodrigo", "Ruben", "Samuel", "Sebastian", "Simon", "Stephen", "Steven", "Thomas", "Timothy", "Tyler", "Vicente", "Victor", "Vincent", "Walter", "William", "Xavier", "Yahir", "Zachary" };
            string[] driversSurnames = { "Adams", "Allen", "Anderson", "Baker", "Barnes", "Bell", "Bennett", "Brown", "Butler", "Campbell", "Carter", "Clark", "Coleman", "Callins", "Cook", "Copper", "Cox", "Davis", "Diaz", "Edwards", "Evans", "Flores", "Foster", "Garcia", "Gonzalez", "Green", "Griffin", "Hall", "Harris", "Hernandez", "Hill", "Howard", "Hughes", "Jackson", "James", "Jenkins", "Johnson", "Jones", "Kelly", "King", "Lee", "Lewis", "Long", "Lopez", "Matin", "Martinez", "Miller", "Mitchell", "Moore", "Morgan", "Norris", "Murphy", "Nelson", "Nguyen", "Parker", "Perez", "Peterson", "Phillips", "Ramirez", "Reed", "Richardson", "Rivera", "Roberts", "Rodriguez", "Ross", "Sanchez", "Scott", "Simmons", "Smith", "Stewart", "Taylor", "Thompson", "Turner", "Walker", "Ward", "Washington", "Watson", "White", "Williams", "Wilson", "Wood", "Wright", "Young", "Muller" };
            int[] driversNumbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32, 33, 34, 35, 36, 37, 38, 39, 40, 41, 42, 43, 44, 45, 46, 47, 48, 49, 50, 51, 52, 53, 54, 55, 56, 57, 58, 59, 60, 61, 62, 63, 64, 65, 66, 67, 68, 69, 70, 71, 72, 73, 74, 75, 76, 77, 78, 79, 80, 81, 82, 83, 84, 85, 86, 87, 88, 89, 90, 91, 92, 93, 94, 95, 96, 97, 98, 99 };
            List<string> driversNamesList;
            List<string> driversSurnamesList;
            List<int> driversNumbersList;
            driversNamesList = new List<string>();
            driversSurnamesList = new List<string>();
            driversNumbersList = new List<int>();
            Dictionary<string, Driver> driver = new Dictionary<string, Driver>();

            foreach (string driverName in driversNames)
            {
                driversNamesList.Add(driverName);
            }
            foreach(string driverSurname in driversSurnames)
            {
                driversSurnamesList.Add(driverSurname);
            }
            foreach(int driverNumber in driversNumbers)
            {
                driversNumbersList.Add(driverNumber);
            }
            for(int i = 0; i < 22; i++)
            {
                int Name = random.Next(0, driversNamesList.Count);
                int Surname = random.Next(0, driversSurnamesList.Count);
                float Skill = random.Next(85, 96);
                int Number = random.Next(0, driversNumbersList.Count);
                float rand = random.Next(10000, 20000);
                double RaceSalary = Math.Round((((Skill - 79)/16 * 700000) + ((Skill - 84)*rand))/1000) * 1000;
                Drivers.Add(driver["Driver_" + Number.ToString()] = new Driver(driversNamesList.ElementAt(Name), driversSurnamesList.ElementAt(Surname), driversNumbersList.ElementAt(Number), (int)Skill, RaceSalary, 0));
                driversNamesList.RemoveAt(Name);
                driversSurnamesList.RemoveAt(Surname);
                driversNumbersList.RemoveAt(Number);
            }
        }

        public void GenerateTeams(List<Driver> availableDrivers)
        {
            string[] teamsNames = { "Mercedes", "Red Bull Racing", "McLaren", "Ferrari", "Alpine", "Alpha Tauri", "Aston Martin", "Alfa Romeo Racing", "Williams", "Haas" };
            string[] teamsObjectsNames = { "Mercedes", "RedBull", "McLaren", "Ferrari", "Alpine", "AlphaTauri", "AstonMartin", "AlfaRomeo", "Williams", "Haas" };
            string[] teamsCarNames = {"W14", "RB-19", "MCL60", "SF-23", "A523", "AT04", "AMR23", "C43", "FW45", "VF-23"};
            Color[] colors = { Color.MediumSpringGreen, Color.Blue, Color.Orange, Color.Red, Color.Pink, Color.Gray, Color.Green, Color.DarkRed, Color.DeepSkyBlue, Color.Snow };
            Dictionary<string, Team> teams = new Dictionary<string, Team>();
            for(int i = 0; i < 10; i++)
            {
                float budget = random.Next(5000000, 10000000);
                Car car = new Car(teamsCarNames[i], 75, 90, 765, 790, 70, 85, 800, 815);
                Teams.Add(teams["Team_" + teamsObjectsNames[i].ToString()] = new Team(teamsNames[i], budget, colors[i], car)); // adding new Team to Teams

                int driver1 = random.Next(0, availableDrivers.Count());
                teams["Team_" + teamsObjectsNames[i].ToString()].Driver1 = availableDrivers.ElementAt(driver1); // assign object in available drivers at index driver1 to Driver1 in Team
                availableDrivers.ElementAt(driver1).Team = teams["Team_" + teamsObjectsNames[i].ToString()].Name; // assign Team name to Driver1
                availableDrivers.ElementAt(driver1).Color = colors[i];
                availableDrivers.RemoveAt(driver1); // remove Driver1 from available Drivers List
                
                int driver2 = random.Next(0, availableDrivers.Count());
                teams["Team_" + teamsObjectsNames[i].ToString()].Driver2 = availableDrivers.ElementAt(driver2);
                availableDrivers.ElementAt(driver2).Team = teams["Team_" + teamsObjectsNames[i].ToString()].Name;
                availableDrivers.ElementAt(driver2).Color = colors[i];
                availableDrivers.RemoveAt(driver2);
            }
        }

        public void GenerateGrandPrixs()
        {
            string[] grandPrixsNames = { "Bahrain Grand Prix", "Saudi Arabian Grand Prix", "Australian Grand Prix", "Azerbaijan Grand Prix", "Miami Grand Prix", "Gran Premio Emilia-Romagna", "Grand Prix de Monaco", "Grand Premio de Espana", "Grand Prix du Canada", "Grosses Preis von Osterreich", "British Grand Prix", "Hungarian Grand Prix", "Belgian Grand Prix", "Dutch Grand Prix", "Gran Premio D'Italia", "Singapore Grand Prix", "Japanese Grand Prix", "Qatar Grand Prix", "United States Grand Prix", "Gran Premio de la Ciudad de Mexico", "Grande Premio de Sao Paulo", "Las Vegas Grand Prix", "Abu Dhabi Grand Prix" };
            int[] grandPrixsLaps = { 57, 50, 58, 51, 57, 63, 78, 66, 70, 71, 52, 70, 44, 72, 53, 61, 53, 57, 56, 71, 71, 50, 58 };
            string[] circuitsNames = { "Bahrain International Circuit", "Jeddah Corniche Circuit", "Albert Park Circuit", "Baku City Circuit", "Miami International Autodrome", "Autodromo Enzo E Dino Ferrari", "Circuit de Monaco", "Circuit de Barcelona-Catalunya", "Circuit Gilles-Villeneuve", "Red Bull Ring", "Silverstone Circuit", "Hungaroring", "Circuit de Spa-Francorchamps", "Circuit Zandvoort", "Autodromo Nazionale Monza", "Marina Bay Street Circuit", "Suzuka International Racing Course", "Losail International Circuit", "Circuit of the Americas", "Autodromo Hermanos Rodriguez", "Autodromo Jose Carlos Pace", "Las Vegas Strip Circuit", "Yas Marina Circuit" };
            string[] circuitsCountries = { "Bahrain", "Saudi Arabia", "Australia", "Azerbaijan", "United States", "Italy", "Monaco", "Spain", "Canada", "Austria", "Great Britain", "Hungary", "Belgium", "Netherlands", "Italy", "Singapore", "Japan", "Qatar", "United States", "Mexico", "Brazil", "United States", "UAE" };
            string[] circuitsCities = { "Sakhir", "Jeddah", "Melbourne", "Baku", "Miami", "Imola", "Monte Carlo", "Barcelona", "Montreal", "Spielberg", "Silverstone", "Budapest", "Stavelot", "Zandvoort", "Monza", "Marina Bay", "Suzuka", "Lusail", "Austin", "Mexico City", "Sao Paulo", "Paradise", "Abu Dhabi" };
            string[] circuitsTypes = { "Race", "Street", "Street", "Street", "Street", "Race", "Street", "Race", "Street", "Race", "Race", "Race", "Race", "Race", "Race", "Street", "Race", "Race", "Race", "Race", "Race", "Street", "Race" };
            float[] circuitsLengths = { 5.412f, 6.175f, 5.278f, 6.003f, 5.412f, 4.909f, 3.337f, 4.675f, 4.361f, 4.318f, 5.891f, 4.381f, 7.004f, 4.259f, 5.793f, 5.063f, 5.807f, 5.380f, 5.513f, 4.304f, 4.309f, 6.12f, 5.281f };
            float[] circuitsAPImportances = { 0.6f, 0.4f, 0.6f, 0.4f, 0.4f, 0.6f, 1f, 0.8f, 0.4f, 0.8f, 0.8f, 1f, 0.4f, 0.8f, 0.2f, 1f, 0.8f, 0.8f, 0.8f, 1f, 0.8f, 0.4f, 0.6f };
            float[] circuitsEPImportances = { 0.75f, 0.83f, 0.81f, 0.72f, 0.69f, 0.71f, 0.57f, 0.73f, 0.73f, 0.77f, 0.81f, 0.65f, 0.8f, 0.71f, 0.83f, 0.6f, 0.77f, 0.78f, 0.72f, 0.68f, 0.74f, 0.8f, 0.78f };
            float[] circuitsTyreStresses = { 0.53f, 0.46f, 0.53f, 0.6f, 0.46f, 0.53f, 0.66f, 0.66f, 0.6f, 0.6f, 0.67f, 0.67f, 0.6f, 0.73f, 0.6f, 0.67f, 0.67f, 0.73f, 0.66f, 0.6f, 0.62f, 0.58f, 0.6f };
            Image[] circuitsLayouts = { global::F1_Simulator.Properties.Resources.Bahrain, global::F1_Simulator.Properties.Resources.jeddah, global::F1_Simulator.Properties.Resources.Melbourne, global::F1_Simulator.Properties.Resources.baku, global::F1_Simulator.Properties.Resources.miami, global::F1_Simulator.Properties.Resources.imola, global::F1_Simulator.Properties.Resources.monaco, global::F1_Simulator.Properties.Resources.barcelona, global::F1_Simulator.Properties.Resources.canada, global::F1_Simulator.Properties.Resources.austria, global::F1_Simulator.Properties.Resources.silverstone, global::F1_Simulator.Properties.Resources.hungary,
                                       global::F1_Simulator.Properties.Resources.spa, global::F1_Simulator.Properties.Resources.zandvoort, global::F1_Simulator.Properties.Resources.monza, global::F1_Simulator.Properties.Resources.singapore, global::F1_Simulator.Properties.Resources.japan, global::F1_Simulator.Properties.Resources.qatar, global::F1_Simulator.Properties.Resources.cota, global::F1_Simulator.Properties.Resources.mexico, global::F1_Simulator.Properties.Resources.brazil, global::F1_Simulator.Properties.Resources.las_vegas, global::F1_Simulator.Properties.Resources.abu_dhabi};
            Image[] grandPrixsFlags = { global::F1_Simulator.Properties.Resources.bahrain_flag, global::F1_Simulator.Properties.Resources.arabia_flag, global::F1_Simulator.Properties.Resources.australia_flag, global::F1_Simulator.Properties.Resources.azerbaijan_flag, global::F1_Simulator.Properties.Resources.usa_flag, global::F1_Simulator.Properties.Resources.italy_flag, global::F1_Simulator.Properties.Resources.monaco_flag, global::F1_Simulator.Properties.Resources.spain_flag, global::F1_Simulator.Properties.Resources.canada_flag, global::F1_Simulator.Properties.Resources.austria_flag, global::F1_Simulator.Properties.Resources.uk_flag, global::F1_Simulator.Properties.Resources.hungary_flag
                                       , global::F1_Simulator.Properties.Resources.belgium_flag, global::F1_Simulator.Properties.Resources.netherlands_flag, global::F1_Simulator.Properties.Resources.italy_flag, global::F1_Simulator.Properties.Resources.singapore_flag, global::F1_Simulator.Properties.Resources.japan_flag, global::F1_Simulator.Properties.Resources.qatar_flag, global::F1_Simulator.Properties.Resources.usa_flag, global::F1_Simulator.Properties.Resources.mexico_flag, global::F1_Simulator.Properties.Resources.brazil_flag, global::F1_Simulator.Properties.Resources.usa_flag, global::F1_Simulator.Properties.Resources.uae_flag};
            Dictionary<string, Circuit> circuits = new Dictionary<string, Circuit>();
            Dictionary<string, GrandPrix> grandPrixs = new Dictionary<string, GrandPrix>();
            for (int i = 0; i < 23; i++)
            {
                Circuits.Add(circuits["Circuit_" + circuitsCities[i]] = new Circuit(circuitsNames[i], circuitsCountries[i], circuitsCities[i], circuitsTypes[i], circuitsLengths[i], circuitsAPImportances[i], circuitsEPImportances[i], circuitsTyreStresses[i], circuitsLayouts[i]));
            }

            GrandPrixs.Add(grandPrixs["GrandPrix_" + circuitsCities[0]] = new GrandPrix(1, grandPrixsNames[0], grandPrixsLaps[0], Circuits.ElementAt(0), grandPrixsFlags[0])); // first Grand Prix of the Season - Bahrain GP
            
            for (int i = 1; i < this.NumberOfRaces-1; i++)
            {
                GrandPrixs.Add(grandPrixs["GrandPrix_" + circuitsCities[i]] = new GrandPrix(i + 1, grandPrixsNames[i], grandPrixsLaps[i], Circuits.ElementAt(i), grandPrixsFlags[i]));
            }

            GrandPrixs.Add(grandPrixs["GrandPrix_" + circuitsCities[22]] = new GrandPrix(this.NumberOfRaces, grandPrixsNames[22], grandPrixsLaps[22], Circuits.ElementAt(22), grandPrixsFlags[22])); // last Grand Prix of the Season - Abu Dhabi GP
        }

    }
}
