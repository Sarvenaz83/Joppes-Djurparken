using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zoo
{
    public partial class Login : Form
    {
        private Dictionary<string, string> userCredentials;
        public Login()
        {
            InitializeComponent();
            InitializeUserCredentials();
        }
        private void InitializeUserCredentials()
        {
            userCredentials = new Dictionary<string, string>
            {
                {"lion", "lion123" },
                {"appa", "appa123" },
                {"tiger", "tiger123" }
            };
        }
        private void buttonLogin_Click(object sender, EventArgs e)
        {
            string username = textBoxUsername.Text;
            string password = textBoxPassword.Text;
            if (userCredentials.ContainsKey(username) && userCredentials[username] == password)
            {
                //Inloggning lyckades
                //Öppna en ny sida för djurskötarens funktionalitet
                SkötareDashboard skötareDashboard = new SkötareDashboard();
                skötareDashboard.Show();
                this.Close(); //Stäng inloggningssidan
            }
            else
            {
                MessageBox.Show("Felaktigt användarnamn eller lösenord.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
