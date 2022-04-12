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
    public partial class UserMenu : Form
    {
        private DataBaseConnection db = new DataBaseConnection();
        private userController user = new userController();
        
        public UserMenu()
        {
           InitializeComponent();
        }

        private void UserMenu_Load(object sender, EventArgs e)
        {
            db.GetConnection();
            userGridView.DataSource = user.GetUsers();
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            //Maak een object
            createUser createUser = new createUser();
            //verberg de correcte form dus MainMenu
            this.Hide();
            //laat de user form zien
            createUser.ShowDialog();
            //sluit form dus MainMenu wordt gesloten, zo dat processor niet overbelast wordt.
            this.Close();
        }

        //TODO Haal gegevens op van de tabel
        private void updateButton_Click(object sender, EventArgs e)
        {
            updateUser updateUser = new updateUser();
            //verberg de correcte form dus MainMenu
            this.Hide();
            //laat de user form zien
            updateUser.ShowDialog();
            //sluit form dus MainMenu wordt gesloten, zo dat processor niet overbelast wordt.
            this.Close();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            userController deleteUser = new userController();

            string rowIndex = userGridView.CurrentCell.RowIndex.ToString();
            int row = Convert.ToInt32(rowIndex);

            try
            {

                string delete = deleteUser.deleteData(
                     userGridView.Rows[row].Cells[row].Value.ToString()
                  );

                MessageBox.Show("Gebruiker verwijdert!");

                userGridView.DataSource = user.GetUsers();

            }
            catch (SqlException error)
            {
                MessageBox.Show("Error " + error);
            }
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            userGridView.DataSource = user.GetUsers();
        }
    }
}
