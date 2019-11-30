using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.IO;
// https://github.com/matthewmichel/DiplomacyAid

namespace DiplomacyAid
{
    public partial class Form1 : Form
    {
        private bool _loggedIn = false;

        List<Control> toolbarControls = new List<Control>();

        static List<Territory> territoryList = new List<Territory>();

        public enum Phase
        {
            Diplomacy,
            Order_Writing,
            Order_Execution,
            Results,
            Redistribution,
            BeginningGame
        }

        public enum Season
        {
            Fall,
            Spring
        }

        private Phase _currentPhase;
        private Season _currentSeason = Season.Spring;

        public Season CurrentSeason
        {
            get
            {
                return _currentSeason;
            }
            set
            {
                _currentSeason = value;
            }
        }

        public Phase CurrentPhase
        {
            get
            {
                return _currentPhase;
            }
            set
            {
                _currentPhase = value;
                ReloadSeasonAndPhase();
            }
        }

        public bool LoggedIn
        {
            get
            {
                return _loggedIn;
            }
            set
            {
                _loggedIn = value;

                // Turn visibility on if logged in
                if(_loggedIn)
                {
                    foreach(Control c in this.Controls)
                    {
                        c.Visible = true;
                    }
                    loginSignoutMenu_Placeholder.Text = "Sign Out";
                    logIn_ToolstripItem.Visible = false;
                    ReloadSeasonAndPhase();
                }
                else if(!_loggedIn)
                {
                    foreach(Control c in this.Controls)
                    {
                        c.Visible = false;
                    }
                    menuStrip1.Visible = true;
                    loginSignoutMenu_Placeholder.Text = "Log In";
                    signOut_ToolstripItem.Visible = false;
                }
            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Instantiate toolbar items into the toolbar list
            toolbarControls.Add(menuStrip1);

            // Turn visibility off
            welcome_Lbl.Visible = false;

            // Open log in form if not logged in.
            if (!LoggedIn)
            {
                LogInForm loginForm = new LogInForm(this);
                loginForm.Show();
            }
        }

        private void Welcome_Lbl_Click(object sender, EventArgs e)
        {

        }

        private void LogInToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            if (LoggedIn)
            {
                MessageBox.Show("You are already logged in.");
            }
            else
            {
                Application.Run(new LogInForm(this));
            }
        }

        private void SignOut_ToolstripItem_Click(object sender, EventArgs e)
        {
            LoggedIn = false;
        }

        private void DiplomacyPhase_Btn_Click(object sender, EventArgs e)
        {
            CurrentPhase = Phase.Diplomacy;
        }

        private void OrderWritingPhase_Btn_Click(object sender, EventArgs e)
        {
            int[] test = { 0, 1, 2 };
            CurrentPhase = Phase.Order_Writing;
            Territory newTerritory = new Territory(1, "test", false, false, true, test);
            string json = JsonConvert.SerializeObject(newTerritory);
            output_Txt.Text = json;
            using(StreamWriter w = new StreamWriter("TerritoryList.json"))
            {
                w.Write(json);
            }
        }

        private void OrderExecutionPhase_Btn_Click(object sender, EventArgs e)
        {
            CurrentPhase = Phase.Order_Execution;
            string outputTxt = "";

            using (StreamReader r = new StreamReader("TerritoryList.json"))
            {
                string json = r.ReadToEnd();
                dynamic array = JsonConvert.DeserializeObject(json);
                foreach (var item in array)
                {
                    outputTxt += item["borderTerr"];
                    Territory newTerritory = CreateTerritory(item["id"] as string, item["name"] as string, item["isCapitol"] as string, item["isCoast"] as string, item["isSupplyPoint"] as string, item["borderTerr"] as string[]);
                    territoryList.Add(newTerritory);
                    //Console.WriteLine("{0} {1}", item.temp, item.vcc);
                    //outputTxt += " ";
                    //outputTxt += item["isSupplyPoint"];
                }

            }

            foreach(Territory t in territoryList)
            {
                outputTxt += $" {t.TerritoryId}";
            }

            output_Txt.Text = outputTxt;
        }

        private void ResultsPhase_Btn_Click(object sender, EventArgs e)
        {
            CurrentPhase = Phase.Results;
        }

        private void RedistributionPhase_Btn_Click(object sender, EventArgs e)
        {
            CurrentPhase = Phase.Redistribution;
        }

        private Territory CreateTerritory(string id, string name, string isCapital, string isCoast, string isSupplyPoint, string[] borderingTerritories)
        {
            int intId;
            bool boolIsCapitol = isCapital == "true" ? true : false;
            bool boolIsCoast = isCoast == "true" ? true : false;
            bool boolIsSupplyPoint = isSupplyPoint == "true" ? true : false;
            bool idConvertableToInt = int.TryParse(id, out intId);
            int[] borderingTerritory = new int[borderingTerritories.Length];

            foreach(string s in borderingTerritories)
            {
                int terrId = int.Parse(s);
                borderingTerritory.Append(terrId);
            }

            return new Territory(intId, name, boolIsCapitol, boolIsCoast, boolIsSupplyPoint, borderingTerritory);

        }


    }
}
