using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class createUser : Form
    {
        private DataBaseConnection db = new DataBaseConnection();
        private userController user = new userController();

        public createUser()
        {
            InitializeComponent();
        }

        private void createUser_Load(object sender, EventArgs e)
        {
            db.GetConnection();
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            try 
            {
                string insert = user.updateInsert(
                    this.nameTextBox.Text,
                    this.emailTextBox.Text,
                    this.postalCodeTextBox.Text,
                    this.cityTextBox.Text
                    );

                MessageBox.Show("Gebruiker aangemaakt");

                this.nameTextBox.Clear();
                this.emailTextBox.Clear();
                this.postalCodeTextBox.Clear();
                this.cityTextBox.Clear();
            }
            catch(SqlException error) 
            {
                MessageBox.Show("Error " + error);
            }
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            //roep object usermenu
            UserMenu userMenuShow = new UserMenu();
            //verstop huidege functie
            this.Hide();
            //roep object aan
            userMenuShow.ShowDialog();
            //sluit huidge form
            this.Close();
        }
    }
}
