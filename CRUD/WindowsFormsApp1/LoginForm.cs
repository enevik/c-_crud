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

        private void loginButton_Click(object sender, EventArgs e)
        {
            //Verbeteren en in database zetten
            //een test
            //TODO
            SqlConnection con = db.GetConnection();
            con.Open();
            SqlDataAdapter query = new SqlDataAdapter();

            DataTable dt = new DataTable();
            query.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1") {
                MessageBox.Show("Werkt");
            }
            else
            {
                MessageBox.Show("Ongeldig gebruiksnaam of wachtwoord");
            }

        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            db.GetConnection();
        }
    }
}
