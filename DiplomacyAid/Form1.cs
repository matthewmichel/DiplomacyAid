using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// https://github.com/matthewmichel/DiplomacyAid

namespace DiplomacyAid
{
    public partial class Form1 : Form
    {
        private bool _loggedIn = false;

        List<Control> toolbarControls = new List<Control>();

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
            CurrentPhase = Phase.Order_Writing;
        }

        private void OrderExecutionPhase_Btn_Click(object sender, EventArgs e)
        {
            CurrentPhase = Phase.Order_Execution;
        }

        private void ResultsPhase_Btn_Click(object sender, EventArgs e)
        {
            CurrentPhase = Phase.Results;
        }

        private void RedistributionPhase_Btn_Click(object sender, EventArgs e)
        {
            CurrentPhase = Phase.Redistribution;
        }
    }
}
