using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiplomacyAid
{
    public partial class LogInForm : Form
    {
        Form1 mainForm;
        public LogInForm(Form1 f)
        {
            InitializeComponent();
            mainForm = f;
        }

        private void LogIn_Btn_Click(object sender, EventArgs e)
        {
            if(username_Txt.Text == "gamemaster" && password_Txt.Text == "password")
            {
                mainForm.LoggedIn = true;
                this.Close();
            }
            else
            {
                MessageBox.Show("Incorrect username or password.");
            }
        }

        private void LogInForm_Load(object sender, EventArgs e)
        {
            this.BringToFront();
        }
    }
}
