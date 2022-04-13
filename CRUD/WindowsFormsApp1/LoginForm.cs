using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class LoginForm : Form
    {
        private DataBaseConnection db = new DataBaseConnection();
        public LoginForm()
        {
            InitializeComponent();
        }
        private void LoginForm_Load(object sender, EventArgs e)
        {
            db.GetConnection();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            //maakt connectie
            SqlConnection con = db.GetConnection();
            //voert query uit en kijkt of het match
            SqlDataAdapter query = new SqlDataAdapter("SELECT COUNT(*) FROM [User] WHERE username='" + emailTextBox.Text + "' AND password='" + passwordTextBox.Text + "'", con);
            //open data connectie
            con.Open();
            //maakt een virtuele data
            DataTable dt = new DataTable();
            //vul de data
            query.Fill(dt);

            if (dt.Rows[0][0].ToString() == "1") {
                //roept object
                MainMenu menu = new MainMenu();
                //verstop huidge
                this.Hide();
                //laat nieuw menu zien
                menu.ShowDialog();
                //sluit huidige
                this.Close();
            }
            else
            {
                //geeft foutmelding
                MessageBox.Show("Ongeldig gebruiksnaam of wachtwoord");
            }

        }
    }
}
